using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MySQL_Manager
{
    public class WF_Datagridview_Generator : ICodeGenerator
    {
        private List<string> colstype;
        private List<string> colscomment;
        private List<string> colsnulable;
        private List<string> tables;
        private List<string> colsdefault;

        private string common;

        private string elementlow;
        private string element;
        private string single;
        private string Plural;
        private string plural;
        private string model_name;
        private string Single;

        public override void GenerateCode()
        {
            cols = dbCon.GetAllColumns(setting.TableName);
            colstype = dbCon.GetColsType(setting.TableName);
            colscomment = dbCon.GetColsComment(setting.TableName);
            colsnulable = dbCon.GetColsNullable(setting.TableName);
            colsdefault = dbCon.GetDefaultValue(setting.TableName);

            tables = dbCon.GetAllTables();

            common = cols[0].Replace("id", "");

            elementlow = setting.TableName.Replace("tbl_", "");
            element = elementlow[0].ToString().ToUpper() + elementlow.Substring(1);
            model_name = setting.TableName.Replace("tbl", "mdl");
            single = elementlow;

            if (single.EndsWith("s"))
                single = single.Substring(0, single.Length - 1);
            plural = elementlow;
            if (!plural.EndsWith("s"))
                plural = plural + 's';

            Plural = plural[0].ToString().ToUpper() + plural.Substring(1);
            Single = single[0].ToString().ToUpper() + single.Substring(1);

            GenerateModelClass();
        }

        private void GenerateModelClass()
        {
            string file_text = File.ReadAllText(@"Code Generator\Templates\WF_Datagridview_Template.txt");
            StringReplacer replacer = new StringReplacer(file_text);
            StringBuilder populate_cell_setup = new StringBuilder();
            StringBuilder cell_validation = new StringBuilder();
            StringBuilder row_insert = new StringBuilder();
            StringBuilder row_insert_query = new StringBuilder();
            StringBuilder row_update_query = new StringBuilder();

            s.Clear();
            for(int i =0; i< cols.Count; i++)
            {
                string type = base.ConvertType(dbCon, colstype[i]);
                s.AppendLine(string.Format("\t\t\tDataGridViewTextBoxColumn col{0} = new DataGridViewTextBoxColumn();", i.ToString()));
                s.AppendLine(string.Format("\t\t\tcol{0}.HeaderText = \"{1}\";", i.ToString(), SanitizeColumnName(cols[i], single)));
                s.AppendLine(string.Format("\t\t\tcol{0}.Name = \"c{1}\";", i.ToString(), cols[i]));
                s.AppendLine(string.Format("\t\t\t//col{0}.Width = 50;", i.ToString(), cols[i]));
                if (i == 0 )
                    s.AppendLine(string.Format("\t\t\tcol{0}.ReadOnly = true;", i.ToString(), cols[i], Plural));
                s.AppendLine(string.Format("\t\t\tdgv{2}.Columns.Add(col{0});", i.ToString(), cols[i], Plural));

                s.AppendLine();

                populate_cell_setup.AppendLine(string.Format("\t\t\t\trow.Cells.Add(new DataGridViewTextBoxCell()"));
                populate_cell_setup.AppendLine("\t\t\t\t{");
                populate_cell_setup.AppendLine(string.Format("\t\t\t\t\tValue = {0}.{1}", single, cols[i]));
                populate_cell_setup.AppendLine("\t\t\t\t});");
                populate_cell_setup.AppendLine();

                if (type == "int")
                {
                    cell_validation.AppendLine(string.Format("\t\t\tif(e.ColumnIndex == {1})", cols[i], i.ToString()));
                    cell_validation.AppendLine("\t\t\t{");
                    cell_validation.AppendLine(string.Format("\t\t\t\tint val{0};", i.ToString()));
                    cell_validation.AppendLine(string.Format("\t\t\t\te.Cancel = !int.TryParse(e.FormattedValue.ToString(), out val{0});", i.ToString()));
                    cell_validation.AppendLine("\t\t\t}");
                }
                if (type == "float")
                {
                    cell_validation.AppendLine(string.Format("\t\t\tif(e.ColumnIndex == {1})", cols[i], i.ToString()));
                    cell_validation.AppendLine("\t\t\t{");
                    cell_validation.AppendLine(string.Format("\t\t\t\tfloat val{0};", i.ToString()));
                    cell_validation.AppendLine(string.Format("\t\t\t\te.Cancel = !float.TryParse(e.FormattedValue.ToString(), out val{0});", i.ToString()));
                    cell_validation.AppendLine("\t\t\t}");
                }

                row_insert.AppendLine(string.Format("\t\t\t\trow.Cells[{0}].Value = newobj.{1};", i.ToString(), cols[i]));

                if (i > 0)
                {
                    string defaultval = colsdefault[i].ToString().Trim();
                    if (!string.IsNullOrEmpty(defaultval))
                        defaultval = "NULL";
                    if (defaultval == "NULL")
                        row_insert_query.Append(defaultval + ",");
                    else
                        row_insert_query.Append("'" + defaultval + "',");
                    row_update_query.AppendLine(string.Format("\t\t\tif(e.ColumnIndex == {0})", i.ToString()));
                    row_update_query.AppendLine("\t\t\t{");
                    row_update_query.AppendLine(string.Format("\t\t\t\tobj_update += \"{1} = '\" + row.Cells[{0}].Value.ToString() + \"'\";", i.ToString(), cols[i]));
                    row_update_query.AppendLine(string.Format("\t\t\t\tobj.{1} = ({2})Convert.ChangeType(row.Cells[{0}].Value, typeof({2}));", i.ToString(), cols[i], type));
                    row_update_query.AppendLine("\t\t\t}");
                }
            }
            row_insert_query = row_insert_query.Remove(row_insert_query.Length - 1, 1);

            replacer.AddField("%table_name%", setting.TableName);
            replacer.AddField("%class_name%", Single);
            replacer.AddField("%key%", cols[0]);
            replacer.AddField("%plural%", plural);
            replacer.AddField("%Plural%", Plural);
            replacer.AddField("%single%", single);
            replacer.AddField("%Single%", Single);
            replacer.AddField("%columns_setup%", s.ToString());
            replacer.AddField("%num_fields%", cols.Count.ToString());
            replacer.AddField("%populate_cell_setup%", populate_cell_setup.ToString());
            replacer.AddField("%cell_validation%", cell_validation.ToString());
            replacer.AddField("%row_insert%", row_insert.ToString());
            replacer.AddField("%row_insert_query%", row_insert_query.ToString());
            replacer.AddField("%row_update_query%", row_update_query.ToString());

            _genetaredCode = replacer.Process();
        }
    }
}
