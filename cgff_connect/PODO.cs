using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace cgff_connect
{

    public class checkinCleaner
    {
        public Int64 id { get; set; }
        public UInt32 user_id { get; set; }

        public DateTime check_in { get; set; }

        public checkinCleaner(Int64 val_id, UInt32 val_user_id, DateTime val_check_in)
        {
            id = val_id;
            user_id = val_user_id;
            check_in = val_check_in;
        }

    }

    public class id_modified
    {
        public string id { get; set; }
        public string modified_date { get; set; }   

        public id_modified(string val_id, string val_modified_date)
        {
            id = val_id;
            modified_date = val_modified_date;
        }
    }

    public class configTable
    {
        public int id {get;set;} 
        public string table_name {get;set;}	
        public string update_frequency_minutes {get;set;}	
        public string update_column_name {get;set;}

        public string id_column_name { get; set; }

        public string log_id_field
        {
            get
            {
                if (is_logged == 1)
                    return table_name + "_id";
                else
                    return "";
            }
            
        }
        public int is_logged { get; set; }

        public configTable() { }

    }

    public class transactionlog
    {
        public int id { get; set; }
        public string action { get; set; }
        public string status { get; set; }  

        public string comment { get; set; }
        public string table_name { get; set; }

        public DateTime effective_date { get; }

        public int rows_affected { get; set; }

        public string source_of_sync { get; set; }

        public transactionlog() { }

        public transactionlog(string action, string status, string comment, string table_name, int rows_affected, string source_of_sync)
        {
            this.id = id;
            this.action = action;
            this.status = status;
            this.comment = comment;
            this.table_name = table_name;
            this.effective_date = effective_date;
            this.rows_affected = rows_affected;
            this.source_of_sync = source_of_sync;
        }   

        public void InsertLog()
        {
            string sql = "insert into transactionlog (comment, table_name, `action`, `status`, rows_affected, source_of_sync) values (@comment, @table_name, @action, @status, @rows_affected, @source_of_sync)";
            using (MySqlConnection conn = new MySqlConnection(Connect.ConnectToLocal()))
            {
                conn.Open();
                conn.Execute(sql, this);
                conn.Close();
            }

        }
    }


    public class errorlog
    {
        public string description { get; set; }
        public string comment { get; set; }

        public string table_name { get; set; }

        public string sql_statement { get; set; }

        public errorlog(string description, string comment, string table_name, string sql_statement)
        {
            this.description = description;
            this.comment = comment;
            this.table_name = table_name;
            this.sql_statement = sql_statement;
        }   

        public errorlog() { }

        public void InsertErrorLog()
        {
            string sql = "insert into errorlog (description, comment, table_name, sql_statement) values (@description, @comment, @table_name, @sql_statement) ";
            using (MySqlConnection conn = new MySqlConnection(Connect.ConnectToLocal()))
            {
                conn.Open();
                conn.Execute(sql, this);
                conn.Close();
            }

        }


    }


}
