using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySQL_Manager.Database;

namespace MySQL_Manager
{
    public abstract class ICodeGenerator: IDisposable
    {
        protected IDBConnection dbCon;
        protected TableSetting setting;
        protected StringBuilder s = new StringBuilder();
        protected List<string> cols;
        protected string _genetaredCode = "";

        public void SetData(IDBConnection db, TableSetting set)
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

        public string SanitizeColumnName(string input, string common = "")
        {
            if (!string.IsNullOrEmpty(common))
                input = input.Replace(common, "");
            input = input.Replace("_", " ");
            input = input.Trim();
            if (input.Length>=2)
                input = input[0].ToString().ToUpper() + input.Substring(1);
            return input.Trim();
        }

        public string ConvertType(IDBConnection conn, string t)
        {
            string type = t.ToLower().Trim();

            if (type.Contains("bigint"))
            {
                type = "Int64";
            }

            if (type.Contains("integer"))
            {
                type = "int";
            }

            if (type.Contains("real"))
            {
                type = "float";
            }

            if (type.Contains("char") || type.Contains("text"))
            {
                type = "string";
            }

            if (type.Contains("date"))
            {
                type = "Nullable<DateTime>";
            }
            else if (type.Contains("time"))
            {
                type = "Nullable<TimeSpan>";
            }

            return type;
        }
    }
}
