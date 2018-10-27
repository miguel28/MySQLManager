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
            replacer.AddField("%ELEMENT_NAME%", element);
            replacer.AddField("%ELEMENT_NAME_low%", elementlow);
            replacer.AddField("%MODEL_NAME%", model_name);

            _genetaredCode = replacer.Process();
        }
    }
}
