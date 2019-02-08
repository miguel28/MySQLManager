using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySQL_Manager.Database
{
    public abstract class IDBConnection
    {
        protected string server;
        protected string database;
        protected string uid;
        protected string password;

        //open connection to database
        protected abstract bool OpenConnection();
        //Close connection
        protected abstract bool CloseConnection();

        #region DatabaseInformation
        public abstract List<string> GetAllTables();

        public abstract List<string> GetAllColumns(string table);

        public abstract List<string> GetColsType(string table_name);

        public abstract List<string> GetDefaultValue(string table_name);

        public abstract List<string> GetColsComment(string table_name);

        public abstract List<string> GetColsNullable(string table_name);
        #endregion

        #region Records
        public abstract List<string>[] SelectAll(string table, int cols);
        public abstract void InsertReg(string table, List<string> Columns, List<string> data);
        public abstract void UpdateReg(string table, List<string> Columns, List<string> data);
        #endregion
    }
}
