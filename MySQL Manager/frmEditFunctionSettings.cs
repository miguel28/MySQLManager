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
	public partial class frmEditFunctionSettings : Form
	{
		public SpecialFunction function;
		private string tableName;
		private DBConnection dbCon;

		public frmEditFunctionSettings(SpecialFunction _function, DBConnection _dbCon, string _tableName)
		{
			InitializeComponent();
			function = _function;
			dbCon = _dbCon;
			tableName = _tableName;
		}

		private void PopulateFunction()
		{
			if (function == null)
				return;

			txtFunctionName.Text = function.Name;
			lstAvailableColumns.DataSource = dbCon.GetAllColumns(tableName);
			lstSelectedColumns.DataSource = function.Parameters;
		}

	}
}
