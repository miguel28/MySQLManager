using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace MySQL_Manager
{
    public class TableSetting
    {
        public static TableSetting LoadTableSetting(string table)
        {
            TableSetting setting = null;
            try
            {
                string text = File.ReadAllText(Configuration.GetSettingFile(table));
                setting = JsonConvert.DeserializeObject<TableSetting>(text);
            }
            catch (Exception ex)
            {
                /*MessageBox.Show("Error while reading the json configuration of the \n table. Error: " + ex.ToString(), 
                    "Importing configuration Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                */
                setting = new TableSetting(table);
            }
            return setting;
        }

        /** Non Static Methods **/

        public string ClassName = "";
        public string TableName = "";
        public List<SpecialFunction> SpecialFunctions = new List<SpecialFunction>();

        private TableSetting(string table)
        {
            TableName = table;
        }
        public void Save()
        {
            string text = this.ToString();
            File.WriteAllText(Configuration.GetSettingFile(TableName), TableName);
        }
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }

    public enum SpecialFuntionType
    {
        Update,
        Query
    }
    public class SpecialFunction
    {
        public string Name = "";
        public SpecialFuntionType Type = SpecialFuntionType.Query;
        public List<String> Parameters = new List<string>();
        public bool LastRow = false;
    }

}
