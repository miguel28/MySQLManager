using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using MySQL_Manager.Database;

namespace MySQL_Manager
{
    public partial class frmConnection : Form
    {
        private const string FILE = "databases.txt";
        private const string FILE_SERVERS = "servers.txt";
        private const string FILE_USERS = "users.txt";
        private AutcompleteClass databases = new AutcompleteClass(FILE);
        private AutcompleteClass servers = new AutcompleteClass(FILE_SERVERS);
        private AutcompleteClass users = new AutcompleteClass(FILE_USERS);

        public frmConnection()
        {
            InitializeComponent();
            LoadDatabasesFile();

            if (cboxServ.Items.Count > 0)
                cboxServ.SelectedIndex = 0;

            if (cboxDatabase.Items.Count>0)
                cboxDatabase.SelectedIndex = 0;

        }

        private void LoadDatabasesFile()
        {
            databases.Load();
            if (databases.HasData)
                cboxDatabase.DataSource = databases.Data;

            servers.Load();
            if (servers.HasData)
                cboxServ.DataSource = servers.Data;

            users.Load();
            if (users.HasData)
            {
                AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
                collection.AddRange(users.Data.ToArray());

                txtUser.AutoCompleteCustomSource = collection;
            }

            var connectiontypes = Assembly.GetAssembly(typeof(IDBConnection)).GetTypes().Where(x => x.IsSubclassOf(typeof(IDBConnection))).ToList();
            cboxConnType.Items.Clear();
            cboxConnType.DataSource = connectiontypes;
        }

        private void CommitChangedDB()
        {
            if (cboxDatabase.SelectedIndex >= 0)
                databases.AddIfNotExist(cboxDatabase.Items[cboxDatabase.SelectedIndex] as String);

            if (!string.IsNullOrEmpty(cboxDatabase.SelectedText))
                databases.AddIfNotExist(cboxDatabase.SelectedText);

            if (!string.IsNullOrEmpty(cboxDatabase.Text))
                databases.AddIfNotExist(cboxDatabase.Text);

            if (cboxServ.SelectedIndex >= 0)
                servers.AddIfNotExist(cboxServ.Items[cboxServ.SelectedIndex] as String);

            if (!string.IsNullOrEmpty(cboxServ.SelectedText))
                servers.AddIfNotExist(cboxServ.SelectedText);

            if (!string.IsNullOrEmpty(cboxServ.Text))
                servers.AddIfNotExist(cboxServ.Text);

            if (!string.IsNullOrEmpty(txtUser.Text))
                users.AddIfNotExist(txtUser.Text);
        }

        private void btnCreateConnection_Click(object sender, EventArgs e)
        {
            DBConnectionInfo config = new DBConnectionInfo
            {
                Server = cboxServ.Text,
                Database = cboxDatabase.Text,
                User = txtUser.Text,
                Password = txtPass.Text
            };
            IDBConnection con = Activator.CreateInstance(cboxConnType.SelectedItem as Type, config) as IDBConnection;

            CommitChangedDB();

            frmManagerMain main = new frmManagerMain(con);
            this.Hide();
            main.ShowDialog();
            this.Show();
        }


    }
}
