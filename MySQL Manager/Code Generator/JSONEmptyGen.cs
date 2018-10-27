using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySQL_Manager
{
    public class JSONEmptyGen : ICodeGenerator
    {
        public JSONEmptyGen()
        {
        }

        public override void GenerateCode()
        {
            s = new StringBuilder();
            cols = dbCon.GetAllColumns(setting.TableName);
            GenerateBasicFunctions();
        }
        
        private void GenerateBasicFunctions()
        {
            // Begin the Code Igniter class
            s.AppendLine("$scope._" + setting.TableName + "_empty ={" );
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
