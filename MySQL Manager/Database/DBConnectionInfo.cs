using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySQL_Manager.Database
{
    public class DBConnectionInfo
    {
        public string Server;
        public string Database;
        public string User;
        public string Password;
        public string ConnectionName;
        public string DatabaseType;
        public int ConnectionTimeout = 10;
    }
}
