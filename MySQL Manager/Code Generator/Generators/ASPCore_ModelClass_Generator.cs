using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static Google.Protobuf.Reflection.FieldOptions.Types;
using System.Drawing;

namespace MySQL_Manager
{
    public class ASPCore_ModelClass_Generator : ICodeGenerator
    {
        private List<string> colstype;
        private List<string> colscomment;
        private List<string> colsnulable;
        private List<string> tables;

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
            string file_text = File.ReadAllText(@"Code Generator\Templates\ASPNetCore_ModelClass_Template.txt");
            StringReplacer replacer = new StringReplacer(file_text);

            s.Clear();
            for(int i =0; i< cols.Count; i++)
            {
                string type = base.ConvertType(dbCon, colstype[i]);

                if (i == 0) // primary key
                {
                    s.AppendLine(string.Format("\t\t[Key]", type, cols[i], "{", "}"));
                }
                else if (colsnulable[i].Contains("NO"))
                {
                    s.AppendLine(string.Format("\t\t[Required]", type, cols[i], "{", "}"));
                }

                if (type.Contains("string"))
                {
                    string ctype = colstype[i];
                    string len = ctype.Replace("varchar(", "").Replace(")", "");
                    s.AppendLine(string.Format("\t\t[MaxLength({0})]", len, cols[i], "{", "}"));
                }
                if (cols[i].ToLower().Contains("email"))
                {
                    s.AppendLine(string.Format("\t\t[EmailAddress]", cols[i], "{", "}"));
                }
                s.AppendLine(string.Format("\t\tpublic {0} {1} {2}get; set;{3}", type, cols[i], "{", "}"));
            }
            replacer.AddField("%table_name%", setting.TableName);
            replacer.AddField("%class_name%", Single);
            replacer.AddField("%fields%", s.ToString());

            s.Clear();
            for (int i = 0; i < tables.Count; i++)
            {
                string table = tables[i];
                table = table.Replace("tbl_", "");
                table = table[0].ToString().ToUpper() + table.Substring(1);

                string tsingle = table;
                string tplural = table;
                if (tsingle.EndsWith("s"))
                {
                    tsingle = tsingle.Substring(0, tsingle.Length - 1);
                }
                else
                {
                    tplural += 's';
                }  

                s.AppendLine(string.Format("\t\t public DbSet<{0}> {1} {2}get; set;{3}", tsingle, tplural, "{", "}"));
            }
            replacer.AddField("%db_set%", s.ToString());

            _genetaredCode = replacer.Process();
        }
    }
}
