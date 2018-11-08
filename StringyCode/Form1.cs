using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StringyCode
{
    public partial class frmStringy : Form
    {
        public frmStringy()
        {
            InitializeComponent();
        }

        private void btnStringy_Click(object sender, EventArgs e)
        {
            string[] lines = Clipboard.GetText().Split('\n');
            StringBuilder s = new StringBuilder();
            foreach (string line in lines)
            {
                s.AppendLine("s.AppendLine(\"" + line.Replace("\"", "\\\"").Replace("\r", "") + "\");");
            }
            Clipboard.SetText(s.ToString());
            s.Clear();
        }
    }
}
