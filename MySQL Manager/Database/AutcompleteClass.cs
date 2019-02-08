using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MySQL_Manager.Database
{
    public class AutcompleteClass
    {
        private string file;
        public List<string> Data;

        public AutcompleteClass(string f)
        {
            file = f;
        }

        public void Load()
        {
            if (File.Exists(file))
            {
                Data = File.ReadAllLines(file).ToList();
            }
            else Data = new List<string>();
        }

        public void Save()
        {
            if (Data != null)
                File.WriteAllLines(file, Data);
        }

        public bool HasData
        {
            get
            {
                return (Data != null && Data.Count > 0);
            }
        }

        public void AddIfNotExist(string da)
        {
            if (Data != null && !Data.Contains(da))
            {
                Data.Add(da);
                Save();
            }
        }
    }
}
