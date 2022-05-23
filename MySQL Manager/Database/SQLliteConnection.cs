using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data.SQLite.EF6;
using System.Windows.Forms;
using System.IO;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Core;
using System.Data.Entity.Core.EntityClient;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MySQL_Manager.Database
{
    [Table("tbl_item_categories")]
    public class Item_categories
    {
        [Key]
        public int category_id { get; set; }
        public string category_name {get; set;}
        public string category_desc {get; set;}
    }

    public class DWContext : DbContext
    {

        public DWContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {
        }

        public DbSet<Item_categories> Item_categories { get; set; }

        public DWContext(DbConnection Connection, bool contextOwnsConnection):
            base(Connection, contextOwnsConnection)
        {

        }

        /// <summary>
        /// Create a new EF6 dynamic data context using the specified provider connection string.
        /// </summary>
        /// <param name="providerConnectionString">Provider connection string to use. Usually a standart ADO.NET connection string.</param>
        /// <returns></returns>
        public static DWContext Create(string providerConnectionString)
        {
            var entityBuilder = new EntityConnectionStringBuilder();

            // use your ADO.NET connection string
            entityBuilder.ProviderConnectionString = providerConnectionString;

            entityBuilder.Provider = "System.Data.SQLite";

            // Set the Metadata location.
            entityBuilder.Metadata = @"res://*/Database.DWH.DWModel.csdl|res://*/Database.DWH.DWModel.ssdl|res://*/Database.DWH.DWModel.msl";

            return new DWContext(entityBuilder.ConnectionString);
        }
    }

    public class SQLliteConnection : IDBConnection
    {
        public SQLiteConnection connection = null;

        public SQLliteConnection(DBConnectionInfo connectioninfo)
        {
            base.configruation = connectioninfo;
            CheckFileIfExist();

            connection = new SQLiteConnection(string.Format("Data Source={0};Version=3;", configruation.Server));
        }

        private void CheckFileIfExist()
        {
            if (!File.Exists(configruation.Server)) // Server should contain filename
            {
                string directory = Path.GetDirectoryName(configruation.Server);
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }
                SQLiteConnection.CreateFile(configruation.Server);
            }
        }

        public override List<string> GetAllColumns(string table)
        {
            string query = string.Format("PRAGMA table_info({0}); ",table);
            List<string> tables = new List<string>();

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                SQLiteCommand cmd = new SQLiteCommand(query, connection);
                //Create a data reader and Execute the command
                SQLiteDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    tables.Add((string)dataReader[1]);
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return tables;
            }
            else
            {
                return tables;
            }
        }

        public override List<string> GetAllTables()
        {
            string query = @"SELECT 
    name
FROM
    sqlite_schema
WHERE
    type = 'table' AND
     name NOT LIKE 'sqlite_%';";
            List<string> tables = new List<string>();

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                SQLiteCommand cmd = new SQLiteCommand(query, connection);
                //Create a data reader and Execute the command
                SQLiteDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    tables.Add((string)dataReader[0]);
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return tables;
            }
            else
            {
                return tables;
            }
        }

        public override List<string> GetColsComment(string table_name)
        {
            List<string> tables = new List<string>();
            return tables;
        }

        public override List<string> GetColsNullable(string table_name)
        {
            List<string> tables = new List<string>();
            string query = string.Format("PRAGMA table_info({0}); ", table_name);

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                SQLiteCommand cmd = new SQLiteCommand(query, connection);
                //Create a data reader and Execute the command
                SQLiteDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    dynamic val = dataReader[3];
                    tables.Add(val.ToString());
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return tables;
            }
            else
            {
                return tables;
            }
        }

        public override List<string> GetColsType(string table_name)
        {
            List<string> tables = new List<string>();
            string query = string.Format("PRAGMA table_info({0}); ", table_name);

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                SQLiteCommand cmd = new SQLiteCommand(query, connection);
                //Create a data reader and Execute the command
                SQLiteDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    tables.Add((string)dataReader[2]);
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return tables;
            }
            else
            {
                return tables;
            }
        }

        public override List<string> GetDefaultValue(string table_name)
        {
            List<string> tables = new List<string>();
            string query = string.Format("PRAGMA table_info({0}); ", table_name);

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                SQLiteCommand cmd = new SQLiteCommand(query, connection);
                //Create a data reader and Execute the command
                SQLiteDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    dynamic val = dataReader[4];
                    tables.Add(val.ToString());
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return tables;
            }
            else
            {
                return tables;
            }
        }

        public override int Insert(string expression)
        {
            string query = expression;
            int ret = -1;
            if (this.OpenConnection())
            {
                try
                {
                    //Create Command
                    SQLiteCommand cmd = new SQLiteCommand(query, connection);
                    //Create a data reader and Execute the command
                    SQLiteDataReader dataReader = cmd.ExecuteReader();

                    while (dataReader.Read())
                    {
                        ret = dataReader.GetInt32(0);
                    }
                    //close Data Reader
                    dataReader.Close();

                    //close Connection
                    this.CloseConnection();

                    return ret;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    return -1;
                }
            }
            else return -1;
        }

        public override bool InsertReg(string table, List<string> Columns, List<string> data)
        {
            string query = "INSERT INTO " + table + " ";
            query += "(";
            foreach (string col in Columns)
                query += col + ",";
            query += ")";

            query += " VALUES(";
            foreach (string dat in data)
                query += "\"" + dat + "\",";
            query += ")";
            query = query.Replace(",)", ")");

            if (this.OpenConnection() == true)
            {
                try
                {
                    //Create Command
                    SQLiteCommand cmd = new SQLiteCommand(query, connection);
                    //Create a data reader and Execute the command
                    SQLiteDataReader dataReader = cmd.ExecuteReader();

                    //close Data Reader
                    dataReader.Close();

                    //close Connection
                    this.CloseConnection();
                }
                catch
                {
                    return false;
                }

                return true;
                //return list to be displayed
            }
            else
                return false;
        }

        public override List<List<string>> Query(string expression)
        {
            string query = expression;

            //Create a list to store the result
            List<List<string>> list = new List<List<string>>();

            //Open connection
            if (this.OpenConnection())
            {
                //Create Command
                SQLiteCommand cmd = new SQLiteCommand(query, connection);
                //Create a data reader and Execute the command
                SQLiteDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    List<string> dat = new List<string>();
                    for (int i = 0; i < dataReader.FieldCount; i++)
                        dat.Add(dataReader[i].ToString());
                    list.Add(dat);
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }

        public override List<string>[] SelectAll(string table, int cols)
        {
            string query = "SELECT * FROM " + table;

            //Create a list to store the result
            List<string>[] list = new List<string>[cols];
            for (int i = 0; i < cols; i++)
                list[i] = new List<string>();

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                SQLiteCommand cmd = new SQLiteCommand(query, connection);
                //Create a data reader and Execute the command
                SQLiteDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    for (int i = 0; i < cols; i++)
                        list[i].Add(dataReader[i].ToString());
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }

        public override void UpdateReg(string table, List<string> Columns, List<string> data)
        {
            string query = "UPDATE " + table + " SET ";
            for (int i = 1; i < Columns.Count; i++)
                query += Columns[i] + "=\"" + data[i] + "\", ";
            query += "@ WHERE " + Columns[0] + "=\"" + data[0] + "\"";
            query = query.Replace(", @", "");

            if (this.OpenConnection() == true)
            {
                //Create Command
                SQLiteCommand cmd = new SQLiteCommand(query, connection);
                //Create a data reader and Execute the command
                SQLiteDataReader dataReader = cmd.ExecuteReader();

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();
            }
        }

        protected override bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        protected override bool OpenConnection()
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                    connection.Open();
                return true;
            }
            catch (SQLiteException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.ErrorCode)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }
    }
}
