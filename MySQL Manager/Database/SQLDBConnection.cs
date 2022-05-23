using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MySQL_Manager.Database
{
    public class SQLDBConnection : IDBConnection
    {
        private SqlConnection connection;
        public SQLDBConnection(string serv, string db, string user, string pass)
        {
            server = serv;
            database = db;
            uid = user;
            password = pass;
            string connectionString;
            connectionString = string.Format("Data Source={0}; Initial Catalog={1};User ID={2};Password={3};", server, database, uid, password);

            connection = new SqlConnection(connectionString);
        }

        public SQLDBConnection(DBConnectionInfo info)
        {
            server = info.Server;
            database = info.Database;
            uid = info.User;
            password = info.Password;
            string connectionString;
            connectionString = string.Format("Data Source={0}; Initial Catalog={1};User ID={2};Password={3};Connection Timeout={4};", server, database, uid, password, info.ConnectionTimeout);

            connection = new SqlConnection(connectionString);

        }

        protected override bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (SqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                /*switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator " + ex.ToString() );
                        break;
                    case 53:
                        MessageBox.Show("Cannot connect to server. Timeout Contact administrator " + ex.ToString());
                        break;
                    case 2:
                        MessageBox.Show("Cannot connect to server. Server NotFound   Contact administrator" + ex.ToString());
                        break;
                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again" + ex.ToString());
                        break;
                }*/
                return false;
            }
        }

        protected override bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public override List<string> GetAllColumns(string table)
        {
            string query = string.Format(@"SELECT
  	COLUMN_NAME
FROM
  	INFORMATION_SCHEMA.COLUMNS
WHERE
	TABLE_CATALOG = '{0}' AND TABLE_NAME = '{1}'", database, table);
            List<string> tables = new List<string>();

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                SqlCommand cmd = new SqlCommand(query, connection);
                //Create a data reader and Execute the command
                SqlDataReader dataReader = cmd.ExecuteReader();

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

        public override List<string> GetAllTables()
        {
            string query = string.Format(@"SELECT TABLE_NAME
FROM INFORMATION_SCHEMA.TABLES
WHERE TABLE_TYPE = 'BASE TABLE' AND TABLE_CATALOG = '{0}'", database);
            List<string> tables = new List<string>();

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                SqlCommand cmd = new SqlCommand(query, connection);
                //Create a data reader and Execute the command
                SqlDataReader dataReader = cmd.ExecuteReader();

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
            string query = string.Format(@"select 
        st.name [Table],
        sc.name [Column],
        sep.value [Description]
    from sys.tables st
    inner join sys.columns sc on st.object_id = sc.object_id
    left join sys.extended_properties sep on st.object_id = sep.major_id
                                         and sc.column_id = sep.minor_id
                                         and sep.name = 'MS_Description'

where st.name = '{0}'", table_name);

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                SqlCommand cmd = new SqlCommand(query, connection);
                //Create a data reader and Execute the command
                SqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    if (dataReader[2] is DBNull)
                        tables.Add("");
                    else
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

        public override List<string> GetColsNullable(string table_name)
        {
            List<string> tables = new List<string>();
            string query = string.Format(@"SELECT
  	IS_NULLABLE
FROM
  	INFORMATION_SCHEMA.COLUMNS
WHERE
	TABLE_CATALOG = '{0}' AND TABLE_NAME = '{1}'", database, table_name);

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                SqlCommand cmd = new SqlCommand(query, connection);
                //Create a data reader and Execute the command
                SqlDataReader dataReader = cmd.ExecuteReader();

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

        public override List<string> GetColsType(string table_name)
        {
            List<string> tables = new List<string>();
            string query = string.Format(@"SELECT DATA_TYPE,CHARACTER_MAXIMUM_LENGTH FROM INFORMATION_SCHEMA.COLUMNS 
WHERE TABLE_NAME = '{0}' AND TABLE_CATALOG = '{1}'", table_name, database);

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                SqlCommand cmd = new SqlCommand(query, connection);
                //Create a data reader and Execute the command
                SqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    if (!(dataReader[1] is DBNull))
                    {
                        tables.Add(string.Format("{0}({1})", (string)dataReader[0], dataReader[1].ToString()));
                    }
                    else 
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

        public override List<string> GetDefaultValue(string table_name)
        {
            List<string> tables = new List<string>();
            string query = string.Format(@"SELECT COLUMN_DEFAULT FROM INFORMATION_SCHEMA.COLUMNS 
WHERE TABLE_NAME = '{0}' AND TABLE_CATALOG = '{1}'", table_name, database);

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                SqlCommand cmd = new SqlCommand(query, connection);
                //Create a data reader and Execute the command
                SqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    if (!(dataReader[0] is DBNull))
                        tables.Add((string)dataReader[0]);
                    else
                        tables.Add("");
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

        public override bool InsertReg(string table, List<string> Columns, List<string> data)
        {
            string query = "INSERT INTO " + table + " ";
            query += "(";
            foreach (string col in Columns)
                query += col + ",";
            query += ")";

            query += " VALUES(";
            foreach (string dat in data)
                query += "'" + dat + "',";
            query += ")";
            query = query.Replace(",)", ")");

            if (this.OpenConnection() == true)
            {
                try
                {
                    //Create Command
                    SqlCommand cmd = new SqlCommand(query, connection);
                    //Create a data reader and Execute the command
                    SqlDataReader dataReader = cmd.ExecuteReader();

                    //close Data Reader
                    dataReader.Close();

                    //close Connection
                    this.CloseConnection();

                    //return list to be displayed
                }
                catch(Exception ex)
                {
                    return false;
                }
                return true;
            }
            else return false;
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
                SqlCommand cmd = new SqlCommand(query, connection);
                //Create a data reader and Execute the command
                SqlDataReader dataReader = cmd.ExecuteReader();

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
                query += Columns[i] + "='" + data[i] + "', ";
            query += "@ WHERE " + Columns[0] + "='" + data[0] + "'";
            query = query.Replace(", @", "");

            if (this.OpenConnection() == true)
            {
                //Create Command
                SqlCommand cmd = new SqlCommand(query, connection);
                //Create a data reader and Execute the command
                SqlDataReader dataReader = cmd.ExecuteReader();

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();
            }
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
                SqlCommand cmd = new SqlCommand(query, connection);
                //Create a data reader and Execute the command
                SqlDataReader dataReader = cmd.ExecuteReader();

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
      
        public override int Insert(string expression)
        {
            string query = expression;
            int ret = -1;
            if (this.OpenConnection())
            {
                try
                {
                    //Create Command
                    SqlCommand cmd = new SqlCommand(query, connection);
                    //Create a data reader and Execute the command
                    SqlDataReader dataReader = cmd.ExecuteReader();

                    while (dataReader.Read())
                    {
                        object ad = dataReader.GetSqlValue(0);
                        ret = int.Parse(ad.ToString());
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
    }
}
