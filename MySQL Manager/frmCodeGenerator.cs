using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FastColoredTextBoxNS;

namespace MySQL_Manager
{
    public partial class frmCodeGenerator : Form
    {
        private TableSetting tableSetting;
        private DBConnection dbCon;

        public frmCodeGenerator(DBConnection db, TableSetting setting)
        {
            InitializeComponent();
            tableSetting = setting;
            dbCon = db;
        }

        private CodeGeneratorCollections generators;

        private void btnGenerateCode_Click(object sender, EventArgs e)
        {
            if (generators != null)
            {
                if (generators.IsWorking)
                    return;
            }

            generators = CodeGeneratorCollections.GetAllGenerators();
            generators.SetData(dbCon, tableSetting);
            generators.Done += Generators_Done;
            generators.ProgressChange += Generators_ProgressChange;
            generators.GenerateCodes();
        }

        private void Generators_ProgressChange(int progress, string gen)
        {
            progressBar.Value = progress;
            Control[]controls = this.tabControl1.Controls.Find("txt_" + gen, true);
            if (controls.Length > 0)
            {
                FastColoredTextBox txt = (FastColoredTextBox)controls[0];
                txt.Text = generators.GetCodeFrom(gen);
            }
        }

        private void Generators_Done()
        {

        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            FastColoredTextBox txt = (FastColoredTextBox)tabControl1.SelectedTab.Controls[0];
            Clipboard.SetText(txt.Text);
        }
    }
}
