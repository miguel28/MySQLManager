using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.ComponentModel;
using MySQL_Manager.Database;

namespace MySQL_Manager
{
    public delegate void GeneratorProgressChangeCalback(int progress, string gen);
    public delegate void GeneratorDoneCalback();

    public class CodeGeneratorCollections : List<ICodeGenerator>
    {
        #region Static Methods
        public static CodeGeneratorCollections CreateGeneratorList(string[] names)
        {
            CodeGeneratorCollections coll = new CodeGeneratorCollections();
            foreach(string name in names)
            {
                coll.Add((ICodeGenerator)Assembly.GetExecutingAssembly().CreateInstance("MySQL_Manager." + name));
            }

            return coll;
        }

        public static string[] GetAllGeneratorsNames()
        {
            List<string> ret = new List<string>();

            Assembly AutomatedTestAssemble = typeof(ICodeGenerator).Assembly;
            Type[] Types = AutomatedTestAssemble.GetTypes();

            foreach (Type t in Types)
            {
                if (typeof(ICodeGenerator).IsAssignableFrom(t) && !t.FullName.Contains("ICodeGenerator"))
                {
                    ret.Add(t.ToString().Replace("MySQL_Manager.", ""));
                }
            }
            return ret.ToArray();
        }

        public static CodeGeneratorCollections GetAllGenerators()
        {
            return CreateGeneratorList(GetAllGeneratorsNames());
        }

        #endregion

        private BackgroundWorker worker;

        public event GeneratorProgressChangeCalback ProgressChange;
        public event GeneratorDoneCalback Done;

        public CodeGeneratorCollections()
        {
            worker = new BackgroundWorker();
            worker.WorkerSupportsCancellation = true;
            worker.WorkerReportsProgress = true;
            worker.ProgressChanged += Worker_ProgressChanged;
            worker.RunWorkerCompleted += Worker_RunWorkerCompleted;
            worker.DoWork += Worker_DoWork;
        }

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            int i = 0;
            foreach(ICodeGenerator gen in this)
            {
                gen.GenerateCode();
                i++;
                worker.ReportProgress((int)(((float)i / (float)this.Count)*100), gen.GetName());
            }
        }

        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Done?.Invoke();
        }

        private void Worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            ProgressChange.Invoke(e.ProgressPercentage, (string)e.UserState);
        }

        public void SetData(IDBConnection db, TableSetting set)
        {
            this.ForEach(x => x.SetData(db, set));
        }

        public void GenerateCodes()
        {
            worker.RunWorkerAsync();
        }

        public bool IsWorking
        {
            get
            {
                return worker.IsBusy;
            }
        }

        public string GetCodeFrom(string genname)
        {
            string ret = "";
            List <ICodeGenerator> l = this.Where(x => x.GetName().Equals(genname)).ToList();

            if (l.Count > 0)
                ret = l[0].GeneratedCode;

            return ret;
        }
    }
}
