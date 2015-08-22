using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySQL_Manager
{
    public partial class frmEditSetting : Form
    {
		TableSetting setting;
		DBConnection dbCon;
		public frmEditSetting(TableSetting _setting, DBConnection _dbCon)
        {
            InitializeComponent();
			setting = _setting;
			dbCon = _dbCon;
        }

		private void PopulateSettings()
		{
			txtClassName.Text = setting.ClassName;
			lstFunctions.DataSource = setting.SpecialFunctions;
			this.Text = "Generator Settings - " + setting.TableName;
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			frmEditFunctionSettings form = new frmEditFunctionSettings(null, dbCon, setting.TableName);
			form.ShowDialog();
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			if (lstFunctions.SelectedIndex < 0)
				return;

			frmEditFunctionSettings form = new frmEditFunctionSettings((SpecialFunction)lstFunctions.SelectedItem, dbCon, setting.TableName);
			form.ShowDialog();
			SpecialFunction modFunction = form.function;

		}

		private void btnRemove_Click(object sender, EventArgs e)
		{
			if (lstFunctions.SelectedIndex < 0)
				return;
			
			lstFunctions.Items.RemoveAt(lstFunctions.SelectedIndex);
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			setting.Save();
			Dispose();
		}
    }
}
