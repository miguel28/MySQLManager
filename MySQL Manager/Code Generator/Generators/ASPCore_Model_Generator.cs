using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MySQL_Manager
{
    public class ASPCore_Model_Generator : ICodeGenerator
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
            string file_text = File.ReadAllText(@"Code Generator\Templates\ASPNetCore_Model_Template.txt");
            StringReplacer replacer = new StringReplacer(file_text);
            
            replacer.AddField("%model_name%", model_name);
            replacer.AddField("%Single%", Single);
            replacer.AddField("%Plural%", Plural);
            replacer.AddField("%id_field%", cols[0]);

            _genetaredCode = replacer.Process();
        }
    }
}
