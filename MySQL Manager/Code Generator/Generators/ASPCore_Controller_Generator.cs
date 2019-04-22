using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MySQL_Manager
{
    public class ASPCore_Controller_Generator : ICodeGenerator
    {
        private List<string> colstype;
        private List<string> colscomment;
        private List<string> colsnulable;

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

            common = cols[0].Replace("id", "");

            elementlow = setting.TableName.Replace("tbl_", "");
            element = elementlow[0].ToString().ToUpper() + elementlow.Substring(1);
            model_name = setting.TableName.Replace("tbl", "Mdl");
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
            string file_text = File.ReadAllText(@"Code Generator\Templates\ASPNetCore_Controller_Template.txt");
            StringReplacer replacer = new StringReplacer(file_text);

            StringBuilder sb = new StringBuilder();
            int col = 1;
            foreach(string name in cols)
                sb.AppendLine(string.Format("\t\t\t\tworksheet.Cells[1, {0}].Value = \"{1}\";", col++, name));

            replacer.AddField("%headers%", sb.ToString());
            sb.Clear();

            col = 1;
            for (int i = 0; i < cols.Count; i++)
            {
                string type = colstype[i];

                if (type.Contains("bigint"))
                {
                    type = "Int64";
                }

                if (type.Contains("char") || type.Contains("text"))
                {
                    type = "string";
                }

                if (type.Contains("date"))
                {
                    type = "Nullable<DateTime>";
                }
                else if (type.Contains("time"))
                {
                    type = "Nullable<TimeSpan>";
                }

                sb.AppendLine(string.Format("\t\t\t\t\tworksheet.Cells[i, {0}].Value = ({2})report.{1};", col++, cols[i], type));
            }

            replacer.AddField("%line_data%", sb.ToString());
            sb.Clear();

            col = 1;
            for (int i = 0; i < cols.Count; i++)
            {
                string type = colstype[i];

                if (type.Contains("bigint"))
                {
                    type = "Int64";
                }

                if (type.Contains("char") || type.Contains("text"))
                {
                    type = "string";
                }

                if (type.Contains("date"))
                {
                    type = "Nullable<DateTime>";
                }
                else if (type.Contains("time"))
                {
                    type = "Nullable<TimeSpan>";
                }

                if (type.Equals("Int64"))
                    sb.AppendLine(string.Format("\t\t\t\t\telement.{1} = Convert.ToInt64(worksheet.Cells[i, col++].Value);", col++, cols[i], type));
                else if (colsnulable[i].Equals("YES") && type.Equals("string"))
                {
                    sb.AppendLine(string.Format("\t\t\t\t\telement.{1} = worksheet.Cells[i, col++].Value.ToString();", col++, cols[i], type));
                } 
                else
                    sb.AppendLine(string.Format("\t\t\t\t\telement.{1} = ({2})worksheet.Cells[i, col++].Value;", col++, cols[i], type));
            }

            replacer.AddField("%table_name%", setting.TableName);
            replacer.AddField("%line_data2%", sb.ToString());
            sb.Clear();

            replacer.AddField("%model_name%", model_name);
            replacer.AddField("%Single%", Single);
            replacer.AddField("%Plural%", Plural);
            replacer.AddField("%single%", single);
            replacer.AddField("%plural%", plural);
            replacer.AddField("%id_field%", cols[0]);
            replacer.AddField("%columns%", cols.Count.ToString());

            _genetaredCode = replacer.Process();
        }
    }
}
