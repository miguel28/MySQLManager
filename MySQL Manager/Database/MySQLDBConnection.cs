using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace MySQL_Manager.Database
{
    public class MySQLDBConnection : IDBConnection
    {
        private MySqlConnection connection;

        //Constructor
        public MySQLDBConnection(string serv, string db, string user, string pass)
        {
            server = serv;
            database = db;
            uid = user;
            password = pass;
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        public MySQLDBConnection(DBConnectionInfo info)
        {
            server = info.Server;
            database = info.Database;
            uid = info.User;
            password = info.Password;
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            connection = new MySqlConnection(connectionString);

        }

        //open connection to database
        protected override bool OpenConnection()
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                    connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
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
        //Close connection
        protected override bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        #region DatabaseInformation
        public override List<string> GetAllTables()
        {
            string query = "SHOW TABLES";
            List<string> tables = new List<string>();

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

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

        public override List<string> GetAllColumns(string table)
        {
            string query = "desc " + table;
            List<string> tables = new List<string>();

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

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
            string query = "SELECT COLUMN_TYPE FROM INFORMATION_SCHEMA.COLUMNS WHERE table_name = '"
                + table_name + "' AND TABLE_SCHEMA = '" + database + "'";

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

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

        public override List<string> GetDefaultValue(string table_name)
        {
            List<string> tables = new List<string>();
            string query = "DESCRIBE "
                + table_name;

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    if (!(dataReader[4] is DBNull))
                        tables.Add((string)dataReader[4]);
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

        public override List<string> GetColsComment(string table_name)
        {
            List<string> tables = new List<string>();
            string query = "SHOW FULL COLUMNS FROM " + table_name;

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    tables.Add((string)dataReader[8]);
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
            string query = "SHOW FULL COLUMNS FROM " + table_name;

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    tables.Add((string)dataReader[3]);
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
        #endregion

        #region Records
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
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

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
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    //Create a data reader and Execute the command
                    MySqlDataReader dataReader = cmd.ExecuteReader();

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
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

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
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

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
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    //Create a data reader and Execute the command
                    MySqlDataReader dataReader = cmd.ExecuteReader();

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
        #endregion
    }
}
