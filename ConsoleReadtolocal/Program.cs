using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cgff_connect;

namespace ConsoleReadtolocal
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<configTable> configTable = cgff_connect.workhorse.GetConfiguration();
            Guid _idValue = new Guid();

            foreach (configTable cf in configTable)
            {
                if (cf.update_column_name == "*")
                {
                    cgff_connect.workhorse.InsertNew(_idValue, cf.table_name, cf.id_column_name);
                }
                else
                {
                    cgff_connect.workhorse.UpdateExisting(_idValue, cf.table_name, cf.update_column_name, cf.id_column_name);
                    cgff_connect.workhorse.InsertNew(_idValue, cf.table_name, cf.id_column_name);
                }
            }

        }
    }
}
