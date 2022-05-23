using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace MySQL_Manager.Database
{
    public abstract class IDBConnection
    {
        protected string server;
        protected string database;
        protected string uid;
        protected string password;
        protected DBConnectionInfo configruation;

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
        public abstract bool InsertReg(string table, List<string> Columns, List<string> data);
        public abstract void UpdateReg(string table, List<string> Columns, List<string> data);

        public abstract List<List<string>> Query(string expression);
        public abstract int Insert(string expression);
        #endregion

        #region Object Construction Methods
        private static Dictionary<string, Type> DevicesTypes = new Dictionary<string, Type>();
        private static Dictionary<string, Type> DevicesTypesDecorator = new Dictionary<string, Type>();
        public static IDBConnection CreateByConfiguration(DBConnectionInfo config)
        {
            if (DevicesTypes.Count == 0)
            {
                Assembly assembly = typeof(IDBConnection).Assembly;
                Type[] Types = assembly.GetTypes();
                Types = Types.Where(t =>
                   typeof(IDBConnection).IsAssignableFrom(t) && !t.FullName.Contains("IDBConnection")).ToArray();

                DevicesTypes = Types.ToDictionary(z => z.Name);
            }

            IDBConnection connection = null;

            if (DevicesTypes.ContainsKey(config.DatabaseType))
            {
                Type t = DevicesTypes[config.DatabaseType];
                connection = (IDBConnection)Activator.CreateInstance(t, new object[] { config });
            }
            else if (DevicesTypesDecorator.ContainsKey(config.DatabaseType))
            {
                Type t = DevicesTypesDecorator[config.DatabaseType];
                connection = (IDBConnection)Activator.CreateInstance(t, new object[] { config });
            }

            return connection;
        }
        #endregion
    }
}
