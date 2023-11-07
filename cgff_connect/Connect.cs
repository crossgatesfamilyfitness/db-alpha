using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cgff_connect
{
    public static class Connect
    {
        public static string ConnectToLocal()
        {
            string returnVal = "server=10.1.0.155;Port=55000;user=root;password=cgFF3122;database=ca_cgfflive_local;ConvertZeroDateTime=True;";
            return returnVal;   
        }

        public static string ConnectToRemote()
        {
            string returnVal = "server=18.221.206.179;Port=6033;user=ca_cgff_read;password=VmjT3ZknA&rHmwKx3X8^;database=ca_cgfflive;ConvertZeroDateTime=True;";
            return returnVal;
        }

        public static string ConnectToRemoteLog()
        {
            string returnVal = "server=18.221.206.179;Port=6033;user=ca_cgff_read;password=VmjT3ZknA&rHmwKx3X8^;database=ca_cgfflive_log;ConvertZeroDateTime=True;";
            return returnVal;
        }

    }
}
