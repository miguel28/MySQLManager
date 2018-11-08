using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MySQL_Manager
{
    public class CI_Controler_Generator : ICodeGenerator
    {
        private StringReplacer replacer;
        public override void GenerateCode()
        {
            string file_text = File.ReadAllText(@"Code Generator\Templates\CI_Controller.txt");
            replacer = new StringReplacer(file_text);

            string elementlow = setting.TableName.Replace("tbl_", "");
            string element = elementlow[0].ToString().ToUpper() + elementlow.Substring(1);
            string model_name = setting.TableName.Replace("tbl", "mdl");

            string single = elementlow;

            if (single.EndsWith("s"))
                single = single.Substring(0, single.Length - 1);
            string plural = elementlow;
            if (!plural.EndsWith("s"))
                plural = plural + 's';

            string Plural = plural[0].ToString().ToUpper() + plural.Substring(1);
            string Single = single[0].ToString().ToUpper() + single.Substring(1);


            replacer.AddField("%ELEMENT_NAME%", element);
            replacer.AddField("%ELEMENT_NAME_low%", elementlow);
            replacer.AddField("%MODEL_NAME%", model_name);
            replacer.AddField("%single%", single);
            replacer.AddField("%Single%", Single);
            replacer.AddField("%plural%", plural);
            replacer.AddField("%Plural%", Plural);

            _genetaredCode = replacer.Process();
        }
    }
}
