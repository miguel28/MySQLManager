using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySQL_Manager
{
    public class JSONEmptyGen : ICodeGenerator
    {
        public override void GenerateCode()
        {
            cols = dbCon.GetAllColumns(setting.TableName);
            GenerateBasicFunctions();
        }
        
        private void GenerateBasicFunctions()
        {
            // Begin the Code Igniter class
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

            s.AppendLine("$scope._" + single + "_empty ={" );
		    for(int i = 0; i< cols.Count -1; i++)
            {
                s.AppendLine("\t" + cols[i] + " : '',");
            }
            s.AppendLine("\t" + cols.Last() + " : ''");
            s.AppendLine("};");

            _genetaredCode = s.ToString();
        }
    }
}
