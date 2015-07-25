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

namespace MySQL_Manager
{
    public partial class frmManagerMain : Form
    {
        private DBConnection dbCon;

        public frmManagerMain(DBConnection db)
        {
            InitializeComponent();
            dbCon = db;
            lstTables.DataSource = dbCon.GetAllTables();
            txtFolder.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        }
        private void btnBackup_Click(object sender, EventArgs e)
        {
            List<string> tables = dbCon.GetAllTables();
            foreach(string table in tables)
                BackupTable(table);

            MessageBox.Show("All tables Exported Successfuly! ", "File export", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnBackupselected_Click(object sender, EventArgs e)
        {
            string table = (string)lstTables.SelectedItem;
            if (!string.IsNullOrEmpty(table))
            {
                BackupTable(table);
                MessageBox.Show("Table: " + table + " Exported Successfuly! ", "File export", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please Select a table to export", "File export error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDesktop_Click(object sender, EventArgs e)
        {
            txtFolder.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        }
        private void btnCustom_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.ShowNewFolderButton = true;
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtFolder.Text = dialog.SelectedPath;
            }
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            lstTables.DataSource = dbCon.GetAllTables();
        }
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Excel Files (*.xlsx)|*.xlsx";
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtImportFile.Text = dialog.FileName;
            }
        }
        private void btnRestoreToSelected_Click(object sender, EventArgs e)
        {
            if (lstTables.SelectedItem != null)
                RestoreTable((string)lstTables.SelectedItem, txtImportFile.Text);
        }

        private void BackupTable(string table)
        {
            List<string> cols = dbCon.GetAllColumns(table);
            List<string>[] regs = dbCon.SelectAll(table, cols.Count);

            FileInfo info = new FileInfo(txtFolder.Text + "\\Exported " + table + ".xlsx");

            if (info.Exists)
                info.Delete();

            using (var package = new ExcelPackage(info))
            {
                ExcelWorkbook book = package.Workbook;
                ExcelWorksheet worksheet = book.Worksheets.Add("Exported");

                for (int i = 0; i < cols.Count; i++)
                {
                    worksheet.Cells[1, i + 1].Value = cols[i];
                    for (int j = 0; j < regs[i].Count; j++)
                        worksheet.Cells[2 + j, i + 1].Value = regs[i][j];

                    worksheet.Column(i + 1).AutoFit();
                }

                package.Save();
            }
        }
        private void RestoreTable(string table, string filename)
        {
            List<string> cols = dbCon.GetAllColumns(table);
            FileInfo info = new FileInfo(filename);

            using (var package = new ExcelPackage(info))
            {
                ExcelWorkbook book = package.Workbook;
                if (book.Worksheets.Count == 0)
                {
                    MessageBox.Show("The selected Workbook does not have sheets, so can not be imported.", "Excel File Import Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                ExcelWorksheet worksheet = book.Worksheets[1];

                int numcols = worksheet.Dimension.End.Column;
                if (numcols != cols.Count)
                {
                    MessageBox.Show("The selected Workbook does math the number of columns with the database, so can not be imported.", "Excel File Import Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int numRows = worksheet.Dimension.End.Row;
                for (int i = 2; i <= numRows; i++)
                {
                    string id = worksheet.Cells[i, 1].Value.ToString();
                    if (string.IsNullOrEmpty(id)) // if is null insert a nuew row in the data base
                    {
                        List<string> nCols = new List<string>(cols);
                        nCols.RemoveAt(0);

                        List<string> data = new List<string>();
                        for (int j = 2; j <= cols.Count; j++)
                            data.Add((string)worksheet.Cells[i, j].Value);

                        FileterList(ref nCols);
                        FileterList(ref data);

                        dbCon.InsertReg(table, nCols, data);
                    }
                    else // If not then update 
                    {
                        List<string> data = new List<string>();
                        for (int j = 1; j <= cols.Count; j++)
                        {
                            object val = worksheet.Cells[i, j].Value;
                            if (val == null)
                                data.Add("");
                            else
                                data.Add(val.ToString());
                        }
                            

                        FileterList(ref cols);
                        FileterList(ref data);
                        dbCon.UpdateReg(table, cols, data);
                    }
                }
            }

            MessageBox.Show("File Imported Successfuly! ", "File import", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FileterList(ref List<string> list)
        {
            for (int i = 0; i < list.Count; i++)
                list[i] = list[i].Replace("'", "\'");
        }

        private void btnGenerateCode_Click(object sender, EventArgs e)
        {
            string table = (string)lstTables.SelectedItem;
            if (!string.IsNullOrEmpty(table))
            {
                TableSetting setting = TableSetting.LoadTableSetting(table);
                CodeGenerator generator = new CodeGenerator(dbCon, setting);
                generator.GenerateCode();

                txtGeneratedCode.Text = generator.GeneratedCode;
            }

           
        }

    }
}
