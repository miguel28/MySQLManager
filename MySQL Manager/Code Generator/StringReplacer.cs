using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySQL_Manager
{
    public class StringReplacer
    {
        private string original = "";
        private Dictionary<string, string> Fields = new Dictionary<string, string>();

        public StringReplacer(string text = "")
        {
            original = text;
        }

        public void ClearFields()
        {
            Fields.Clear();
        }

        public void AddField(string field_name, string data)
        {
            if (Fields.ContainsKey(field_name))
            {
                Fields[field_name] = data;
            }
            else
            {
                Fields.Add(field_name, data);
            }
        }

        public string OriginalString
        {
            get { return original; }
        }

        public string Process()
        {
            string ret = original;
            foreach (string key in Fields.Keys)
                ret = ret.Replace(key, Fields[key]);

            return ret;
        }
    }
}
