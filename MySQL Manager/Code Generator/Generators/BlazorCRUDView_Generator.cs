using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;

namespace MySQL_Manager
{
    public class BlazorCRUDView_Generator : ICodeGenerator
    {
        private List<string> colstype;
        private List<string> colscomment;
        private List<string> colsnulable;
        private List<string> default_values = null;

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
            default_values = dbCon.GetDefaultValue(setting.TableName);

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

            for (int i = 0; i < cols.Count - 1; i++)
            {
                string type = base.ConvertType(dbCon, colstype[i]);
                if (IsTypeNumber(type))
                    default_values[i] = "0";
                if (string.IsNullOrEmpty(default_values[i]))
                    default_values[i] = "";
            }

            GenerateModelClass();
        }

        private void GenerateModelClass()
        {
            string file_text = File.ReadAllText(@"Code Generator\Templates\BlazorCRUDView_Template.txt");
            StringReplacer replacer = new StringReplacer(file_text);

            StringBuilder sb = new StringBuilder();
            int col = 0;
            foreach(string name in cols)
                sb.AppendLine(string.Format("\t\t\t\t<th>{0}</th>", SanitizeColumnName(name, common)));

            replacer.AddField("%headers%", sb.ToString());
            sb.Clear();

            col = 0;
            for (int i = 0; i < cols.Count; i++)
            {
                string type = base.ConvertType(dbCon, colstype[i]);
                string c = cols[i];
                sb.AppendLine($"\t\t\t\t\t<td>@{single}.{c}</td>");
            }
            replacer.AddField("%table_row%", sb.ToString());
            sb.Clear();

            StringBuilder s = sb;

            for (int i = 1; i < cols.Count; i++)
            {
                string ctype = colstype[i];
                if (ctype.Contains("varchar"))
                {
                    string len = ctype.Replace("varchar(", "").Replace(")", "");
                    if (colscomment[i].Contains("password"))
                    {
                        s.AppendLine("\t\t\t\t\t\t<label class=\"col-3 col-form-label\">" + SanitizeColumnName(cols[i], common) + ":</label>");
                        s.AppendLine("\t\t\t\t\t\t<InputText class=\"col-8 form-control\" type=\"password\" @bind-Value=\"@edit_" + single + "." + cols[i] + "\" />");
                        s.AppendLine("\t\t\t\t\t\t<ValidationMessage For=\"@(() => edit_" + single + "." + cols[i] + ")\" />");
                    }
                    else if (colscomment[i].Contains("COMBO="))
                    {

                        string[] data = colscomment[i].Replace("COMBO=(", "").Replace(")", "").Replace(";", "").Split(',');
                        List<Tuple<string, string>> inputd = new List<Tuple<string, string>>();
                        foreach (string input in data)
                        {
                            string iinput = input.Trim();
                            if (iinput.Contains("="))
                            {
                                string[] valuekey = iinput.Split('=');
                                inputd.Add(new Tuple<string, string>(valuekey[0], valuekey[1]));
                            }
                            else
                            {
                                inputd.Add(new Tuple<string, string>(iinput, iinput));
                            }
                        }

                        s.AppendLine("\t\t\t\t\t\t<div class=\"form-group\">");
                        s.AppendLine("\t\t\t\t\t\t\t<select class=\"form-control\" @bind=\"@edit_" + single + "." + cols[i] + " >");

                        s.AppendLine("\t\t\t\t\t\t\t\t<option value=\"\"></option>");
                        foreach (string input in data)
                        {
                            string iinput = input.Trim();
                            if (iinput.Contains("="))
                            {
                                string[] valuekey = iinput.Split('=');

                                s.AppendLine("\t\t\t\t\t\t\t\t<option value='" + valuekey[0] + "'>" + valuekey[1] + "</option>");
                            }
                            else
                            {
                                s.AppendLine("\t\t\t\t\t\t\t\t<option value='" + iinput + "'>" + iinput + "</option>");
                            }

                        }
                        s.AppendLine("\t\t\t\t\t\t\t</select>");
                        s.AppendLine("\t\t\t\t\t\t\t<ValidationMessage For=\"@(() => edit_" + single + "." + cols[i] + ")\" />");
                        s.AppendLine("\t\t\t\t\t\t</div>");
                    }
                    else if (IsTypeNumber(ctype))
                    {
                        s.AppendLine("\t\t\t\t\t\t<label class=\"col-3 col-form-label\">" + SanitizeColumnName(cols[i], common) + ":</label>");
                        s.AppendLine("\t\t\t\t\t\t<InputNumber @bind-Value=@edit_" + single + "." + cols[i] + " @bind -Value:format=\"F2\"/>");
                        s.AppendLine("\t\t\t\t\t\t<ValidationMessage For=\"@(() => edit_" + single + "." + cols[i] + ")\" />");
                    }
                    else
                    {
                        s.AppendLine("\t\t\t\t\t\t<label class=\"col-3 col-form-label\">" + SanitizeColumnName(cols[i], common) + ":</label>");
                        s.AppendLine("\t\t\t\t\t\t<InputText class=\"form-control\" @bind-Value=\"@edit_" + single + "." + cols[i] + "\" />");
                        s.AppendLine("\t\t\t\t\t\t<ValidationMessage For=\"@(() => edit_" + single + "." + cols[i] + ")\" />");
                    }
                }
                else if (ctype.Contains("int(1)") || ctype.Contains("tinyint"))
                {
                    s.AppendLine("\t\t\t\t\t\t<div class=\"checkbox\">");
                    s.AppendLine("\t\t\t\t\t\t\t<label><input type=\"checkbox\" bind=\"@edit_" + single + "." + cols[i] + "\" > " + SanitizeColumnName(cols[i], common) + ":</label>");
                    s.AppendLine("\t\t\t\t\t\t</div>");
                }
                else if (ctype.Contains("text"))
                {
                    s.AppendLine("\t\t\t\t\t\t<RadzenCard>");
                    s.AppendLine("\t\t\t\t\t\t\t<RadzenText TextStyle=\"TextStyle.Subtitle2\" TagName=\"TagName.H3\">" + SanitizeColumnName(cols[i], common) + "</RadzenText>");
                    s.AppendLine("\t\t\t\t\t\t\t<RadzenTextArea Change=@(args => OnChange(args, \"" + SanitizeColumnName(cols[i], common) + "\")) class=\"w-100\" aria-label=\"" + SanitizeColumnName(cols[i], common) + "\" />");
                    s.AppendLine("\t\t\t\t\t\t</RadzenCard>");
                }
                else if (ctype.Contains("date"))
                {
                    s.AppendLine("\t\t\t\t\t\t<div class=\"form-group\">");
                    s.AppendLine("\t\t\t\t\t\t\t<label for=\"txt_" + cols[i] + "\"> " + SanitizeColumnName(cols[i], common) + ":</label>");
                    s.AppendLine("\t\t\t\t\t\t\t<div class=\"input-group date form_date\" data-date=\"\" data-date-format=\"dd MM yyyy\" data-link-field=\"dtp1_" + cols[i] + "\" data-link-format=\"yyyy-mm-dd\">");
                    s.AppendLine("\t\t\t\t\t\t\t\t<DateInput TValue=\"DateOnly\" @bind-Value=\"edit_" + single + "." + cols[i] + " Placeholder=\"Enter Date\" />");
                    s.AppendLine("\t\t\t\t\t\t\t</div>");
                    s.AppendLine("\t\t\t\t\t\t</div>");
                }
                else
                {
                    s.AppendLine("\t\t\t\t\t\t<label class=\"col-3 col-form-label\">" + SanitizeColumnName(cols[i], common) + ":</label>");
                    s.AppendLine("\t\t\t\t\t\t<InputText class=\"form-control\" @bind-Value=@edit_" + single + "." + cols[i] + " @bind-Value=\"@edit_" + single + "." + cols[i] + "\" >");
                    s.AppendLine("\t\t\t\t\t\t<ValidationMessage For=\"@(() => edit_" + single + "." + cols[i] + ")\" />");
                }
            }

            replacer.AddField("%input_widgets%", sb.ToString());
            sb.Clear();

            s.AppendLine("\t\tedit_" + single + " = new " + Single + "()");
            s.AppendLine("\t\t{");
            for (int i = 0; i < cols.Count - 1; i++)
            {
                string type = base.ConvertType(dbCon, colstype[i]);
                if (IsTypeNumber(type))
                {
                    if (string.IsNullOrEmpty(default_values[i]))
                        s.AppendLine("\t\t\t" + cols[i] + " = 0,");
                    else
                        s.AppendLine("\t\t\t" + cols[i] + " = " + default_values[i] + ",");
                }
                else
                    s.AppendLine("\t\t\t" + cols[i] + " = \"" + default_values[i] + "\",");
            }
            string type1 = colstype.Last().ToLower();
            if (IsTypeNumber(type1))
                s.AppendLine("\t\t\t" + cols.Last() + " = " + default_values.Last() + "");
            else
                s.AppendLine("\t\t\t" + cols.Last() + " =\"" + default_values.Last() + "\"");


            s.AppendLine("\t\t};");
            replacer.AddField("%initialization%", sb.ToString());
            sb.Clear();

            for (int i = 1; i < cols.Count; i++)
            {
                if (colstype[i].Contains("int(1)") || colstype[i].Contains("tinyint"))
                {
                    s.AppendLine("\t\t\t<p><b>" + SanitizeColumnName(cols[i], common) + ": </b>@edit_" + single + "." + cols[i] + "</p>");
                }
                else
                {
                    s.AppendLine("\t\t\t<p><b>" + SanitizeColumnName(cols[i], common) + ": </b>@edit_" + single + "." + cols[i] + "</p>");
                }
            }
            replacer.AddField("%detail_data%", sb.ToString());
            sb.Clear();

            for (int i = 1; i < cols.Count; i++)
            {
                if (colstype[i].Contains("int(1)") || colstype[i].Contains("tinyint"))
                {
                    s.AppendLine("\t\t\t<p><b>" + SanitizeColumnName(cols[i], common) + ": </b>@edit_" + single + "." + cols[i] + "</p>");
                }
                else
                {
                    s.AppendLine("\t\t\t<p><b>" + SanitizeColumnName(cols[i], common) + ": </b>@edit_" + single + "." + cols[i] + "</p>");
                }
            }
            replacer.AddField("%detail_data%", sb.ToString());
            sb.Clear();

            col = 0;
            for (int i = 0; i < cols.Count; i++)
            {
                string type = base.ConvertType(dbCon, colstype[i]);
                sb.AppendLine(string.Format("\t\t\t\t\tworksheet.Cells[i, {0}].Value = ({2})report.{1};", col++, cols[i], type));
            }

            replacer.AddField("%line_data%", sb.ToString());
            sb.Clear();

            col = 1;
            for (int i = 0; i < cols.Count; i++)
            {
                string type = base.ConvertType(dbCon, colstype[i]);

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
