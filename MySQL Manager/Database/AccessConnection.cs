using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace MySQL_Manager.Database
{
    public class AccessConnection : IDBConnection
    {
        private OleDbConnection connection = new OleDbConnection();

        public AccessConnection(string filename, string db, string user, string pass)
        {
            server = filename;
            database = db;
            uid = user;
            password = pass;
            string connectionString;
            connectionString = string.Format("Provider=Microsoft.Jet.OLEDB.4.0; Data Source={0};", server, database, uid, password);

            connection = new OleDbConnection(connectionString);
        }

        public override List<string> GetAllColumns(string table)
        {
            throw new NotImplementedException();
        }

        public override List<string> GetAllTables()
        {
            throw new NotImplementedException();
        }

        public override List<string> GetColsComment(string table_name)
        {
            throw new NotImplementedException();
        }

        public override List<string> GetColsNullable(string table_name)
        {
            throw new NotImplementedException();
        }

        public override List<string> GetColsType(string table_name)
        {
            throw new NotImplementedException();
        }

        public override List<string> GetDefaultValue(string table_name)
        {
            throw new NotImplementedException();
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
                    OleDbCommand cmd = new OleDbCommand(query, connection);
                    //Create a data reader and Execute the command
                    var dataReader = cmd.ExecuteReader();

                    //close Data Reader
                    dataReader.Close();

                    //close Connection
                    

                    //return list to be displayed
                }
                catch (Exception ex)
                {
                    return false;
                }
                finally
                {
                    this.CloseConnection();
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
                OleDbCommand cmd = new OleDbCommand(query, connection);
                //Create a data reader and Execute the command
                var dataReader = cmd.ExecuteReader();

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
                OleDbCommand cmd = new OleDbCommand(query, connection);
                //Create a data reader and Execute the command
                var dataReader = cmd.ExecuteReader();

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();
            }
        }

        public virtual void DeleteReg(string table, string id)
        {
            string query = "DELETE FROM " + table + " WHERE record_id =" + id + "";

            if (this.OpenConnection() == true)
            {
                //Create Command
                OleDbCommand cmd = new OleDbCommand(query, connection);
                //Create a data reader and Execute the command
                var dataReader = cmd.ExecuteReader();

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();
            }
        }

        public virtual List<string> Get(string table, string id)
        {
            string query = string.Format("SELECT * FROM {0} WHERE record_data = '{1}'", table, id);
            List<string> result = new List<string>();

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                OleDbCommand cmd = new OleDbCommand(query, connection);
                //Create a data reader and Execute the command
                var dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    if (!(dataReader[0] is DBNull))
                    {
                        object ob = dataReader[0];
                        if (ob is string)
                            result.Add((string)dataReader[0]);
                        else
                            result.Add(ob.ToString());
                    }
                       
                    else
                        result.Add("");
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return result;
            }
            else
            {
                return result;
            }
        }

        protected override bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        protected override bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (OleDbException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.ErrorCode)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator " + ex.ToString());
                        break;
                    case 2:
                        MessageBox.Show("Cannot connect to server. Server NotFound   Contact administrator" + ex.ToString());
                        break;
                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again" + ex.ToString());
                        break;
                }
                return false;
            }
        }

        public override List<List<string>> Query(string expression)
        {
            return null;
        }

        public override int Insert(string expression)
        {
            return -1;
        }
    }
}
