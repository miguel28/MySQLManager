using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySQL_Manager
{
    public abstract class ICodeGenerator: IDisposable
    {
        protected DBConnection dbCon;
        protected TableSetting setting;
        protected StringBuilder s;
        protected List<string> cols;
        protected string _genetaredCode = "";

        public void SetData(DBConnection db, TableSetting set)
        {
            dbCon = db;
            setting = set;
        }

        public string GeneratedCode
        {
            get
            {
                return _genetaredCode;
            }
        }

        public abstract void GenerateCode();

        public void Dispose()
        {
            s.Clear();
        }

        public string GetName()
        {
            return this.GetType().ToString().Replace("MySQL_Manager.", "");
        }
    }
}
