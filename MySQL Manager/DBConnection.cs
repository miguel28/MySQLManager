using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace MySQL_Manager
{
    public class DBConnection
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        //Constructor
        public DBConnection(string serv, string db, string user, string pass)
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

        //open connection to database
        private bool OpenConnection()
        {
            try
            {
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
        private bool CloseConnection()
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

        public List<string> GetAllTables()
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

        public List<string> GetAllColumns(string table)
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

        public List<string> GetColsType(string table_name)
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

        public List<string> GetColsComment(string table_name)
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

        public List<string> GetColsNullable(string table_name)
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

        public List<string>[] SelectAll(string table, int cols)
        {
            string query = "SELECT * FROM " + table;

            //Create a list to store the result
            List<string>[] list = new List<string>[cols];
            for (int i = 0; i < cols; i++ )
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

        public void InsertReg(string table, List<string> Columns, List<string> data)
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
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
            }
        }
        public void UpdateReg(string table, List<string> Columns, List<string> data)
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
    }
}
