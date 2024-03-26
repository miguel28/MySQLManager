using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySQL_Manager
{
    public class JSONEmptyGen : ICodeGenerator
    {
        private List<string> default_values = null;
        private List<string> types = null;
        public override void GenerateCode()
        {
            cols = dbCon.GetAllColumns(setting.TableName);
            default_values = dbCon.GetDefaultValue(setting.TableName);
            types = dbCon.GetColsType(setting.TableName);

            for (int i = 0; i < cols.Count - 1; i++)
            {
                string type = base.ConvertType(dbCon, types[i]);
                if (IsTypeNumber(type))
                    default_values[i] = "0";
                if (string.IsNullOrEmpty(default_values[i]))
                    default_values[i] = "";
            }
            GenerateBasicFunctions();
        }
        
        private void GenerateBasicFunctions()
        {
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
                string type = base.ConvertType(dbCon, types[i]);
                if (IsTypeNumber(type))
                {
                    if (string.IsNullOrEmpty(default_values[i]))
						s.AppendLine("\t" + cols[i] + " : 0,");
                    else
					    s.AppendLine("\t" + cols[i] + " : " + default_values[i] + ",");
				}
                else
                    s.AppendLine("\t" + cols[i] + " : '" + default_values[i] + "',");
            }
            string type1 = types.Last().ToLower();
            if (IsTypeNumber(type1))
                s.AppendLine("\t" + cols.Last() + " : " + default_values.Last() + "");
            else
                s.AppendLine("\t" + cols.Last() + " : '" + default_values.Last() + "'");


            s.AppendLine("};");

            _genetaredCode = s.ToString();
        }
    }
}
