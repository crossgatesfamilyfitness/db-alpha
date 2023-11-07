using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using cgff_connect;

namespace readtolocal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string mode = "-i";
            string action = "checkin";

            if(args.Length > 0)
            {
                mode = args[1]?.ToLower();
                action = args[2]?.ToLower();
            }

            Console.WriteLine("Press any key");
            Console.ReadLine();
            
            List<cgff_connect.configTable> configure = workhorse.GetConfiguration();
            //begin trans log
            //first, if the config has a modified_date not * then run update
            //end update translog
            //begin insert trans log
            //then run insertnew
            //end insert trans log
            transactionlog log = new transactionlog();

            if ((mode == "ALL") && (action == "ALL"))
            {
                foreach (configTable c in configure)
                {
                    if (c.update_column_name != "*")
                    {
                        log = new transactionlog("START UPDATE", "BEFORE", "UPDATE COLUMN USED: " + c.update_column_name, c.table_name, 0, "console");
                        log.InsertLog();
                        int totalRowsUpdate = workhorse.UpdateExisting(c.table_name, c.update_column_name, c.id_column_name);
                        log = new transactionlog("AFTER UPDATE", "AFTER", "UPDATE COLUMN USED: " + c.update_column_name, c.table_name, totalRowsUpdate, "console");
                        log.InsertLog();
                    }
                    log = new transactionlog("START INSERT", "BEFORE", "", c.table_name, 0, "console");
                    log.InsertLog();
                    int totalRowsInsert = workhorse.InsertNew("payment", c.id_column_name);
                    log = new transactionlog("AFTER INSERT", "AFTER", "", c.table_name, totalRowsInsert, "console");
                    log.InsertLog();
                }

            }

            if (mode == "-u")
            {
                Console.WriteLine(mode + " " + action);
                string mod_column = "";
                string id_column = "";
                foreach(configTable c in configure)
                {
                    if(c.table_name.ToLower() == action.ToLower())
                    {
                        mod_column = c.update_column_name;
                        id_column = c.id_column_name;
                    }
                }
                if (mod_column != "*")
                {
                    log = new transactionlog("START UPDATE", "BEFORE", "UPDATE COLUMN USED: " + mod_column, action, 0, "console");
                    log.InsertLog();
                    int totalRowsUpdate = workhorse.UpdateExisting(action, mod_column, id_column);
                    log = new transactionlog("AFTER UPDATE", "AFTER", "UPDATE COLUMN USED: " + mod_column, action, totalRowsUpdate, "console");
                    log.InsertLog();
                }
            }
            if (mode == "-i")
            {
                Console.WriteLine(mode + " " + action);
                string id_column = string.Empty;
                foreach (configTable c in configure)
                {
                    if (c.table_name.ToLower() == action.ToLower())
                    {
                        id_column = c.id_column_name;
                    }
                }
                log = new transactionlog("START INSERT", "BEFORE", "", action, 0, "console");
                log.InsertLog();
                int totalRowsInsert = workhorse.InsertNew(action, id_column);
                log = new transactionlog("AFTER INSERT", "AFTER", "", action, totalRowsInsert, "console");
                log.InsertLog();
            }

            if (mode == "-ui")
            {
                Console.WriteLine(mode + " " + action);
                string mod_column = "";
                string id_column = "";
                foreach (configTable c in configure)
                {
                    if (c.table_name.ToLower() == action.ToLower())
                    {
                        mod_column = c.update_column_name;
                        id_column = c.id_column_name;
                    }
                }
                log = new transactionlog("START UPDATE", "BEFORE", "UPDATE COLUMN USED: " + mod_column, action, 0, "console");
                log.InsertLog();
                if (mod_column != "*")
                {
                    int totalRowsUpdate = workhorse.UpdateExisting(action, mod_column, id_column);
                    log = new transactionlog("AFTER UPDATE", "AFTER", "UPDATE COLUMN USED: " + mod_column, action, totalRowsUpdate, "console");
                    log.InsertLog();
                    Console.WriteLine("Updated " + totalRowsUpdate.ToString());
                }
                Console.WriteLine(mode + " " + action);
                log = new transactionlog("START INSERT", "BEFORE", "", action, 0, "console");
                log.InsertLog();
                int totalRowsInsert = workhorse.InsertNew(action, id_column);
                Console.WriteLine("Inserted " + totalRowsInsert.ToString());
                log = new transactionlog("AFTER INSERT", "AFTER", "", action, totalRowsInsert, "console");
                log.InsertLog();
            }

            Console.WriteLine("Done");
            Console.ReadLine(); 

        }
    }
}
