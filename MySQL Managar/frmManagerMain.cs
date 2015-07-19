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
using OfficeOpenXml;

namespace MySQL_Managar
{
    public partial class frmManagerMain : Form
    {
        private DBConnection dbCon;

        public frmManagerMain(DBConnection db)
        {
            InitializeComponent();
            dbCon = db;
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            List<string> tables = dbCon.GetAllTables();

            foreach(string table in tables)
            {
                List<string> cols = dbCon.GetAllColumns(table);
                List<string>[] regs = dbCon.SelectAll(table, cols.Count);

                FileInfo info = new FileInfo("Exported " + table + ".xlsx");

                if(info.Exists)
                    info.Delete();

                using (var package = new ExcelPackage(info))
                {
                    ExcelWorkbook book = package.Workbook;
                    ExcelWorksheet worksheet = book.Worksheets.Add("Exported");

                    for(int i = 0 ; i< cols.Count; i++)
                    {
                        worksheet.Cells[1, i + 1].Value = cols[i];
                        for(int j = 0; j < regs[i].Count ; j++)
                            worksheet.Cells[2 +j, i + 1].Value = regs[i][j];

                        worksheet.Column(i + 1).AutoFit();
                    }

                    package.Save();
                }
            }


        }
    }
}
