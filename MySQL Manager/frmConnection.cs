using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MySQL_Manager
{
    public partial class frmConnection : Form
    {
        public frmConnection()
        {
            InitializeComponent();
            cboxServ.SelectedIndex = 0;
            cboxDatabase.SelectedIndex = 0;
        }

        private void btnCreateConnection_Click(object sender, EventArgs e)
        {
            DBConnection con = new DBConnection((string)cboxServ.SelectedItem, (string)cboxDatabase.SelectedItem, txtUser.Text, txtPass.Text);
            frmManagerMain main = new frmManagerMain(con);
            this.Hide();
            main.ShowDialog();
            this.Show();
        }
    }
}
