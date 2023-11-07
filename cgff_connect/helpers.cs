using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace cgff_connect
{
    public static class helpers
    {
        public static List<string> GetColumnNames(MySqlDataReader reader)
        {
            List<string> retval = new List<string>();
            for (int i = 0; i < reader.FieldCount; i++)
            {
                retval.Add("`" + reader.GetName(i) +"`");
            }
            return retval;
        }

        public static List<string> GetColumnTypes(MySqlDataReader reader)
        {
            List<string> retval = new List<string>();
            for (int i = 0; i<reader.FieldCount; i++)
            {
                retval.Add(reader.GetDataTypeName(i));
            }

            return retval;
        }

        public static List<string> GetRowValues(MySqlDataReader reader)
        {
            List<string> retval = new List<string>();
            for (int i = 0; i < reader.FieldCount; i++)
            {
                string ftype = reader.GetFieldType(i).Name;
                ftype = ftype.ToLower();

                string baseValue = ResolveValueByType(reader, i);
                retval.Add(baseValue);
            }
            return retval;
        }

        public static string ResolveValueByType(MySqlDataReader reader, int i)
        {
            string ftype = reader.GetFieldType(i).Name;
                ftype = ftype.ToLower();
            string retval = string.Empty;

                if (ftype == "datetime")
                {
                    try
                    {
                        DateTime dateVal = new DateTime();
                        DateTime.TryParse(reader.GetValue(i).ToString(), out dateVal);
                        if (dateVal != null)
                        {
                            string formatString = dateVal.ToString("yyyy-MM-dd HH:mm:ss");
                            retval = "'" + formatString + "',";
                        }
                    }
                    catch (Exception Ex)
                    {
                        retval = "'1970-01-01 00:00:00',";
                    }
                    finally
                    {
                        
                    }
                }

                if (ftype.Contains("timespan"))
                {
                    if (reader.GetValue(i).ToString() == "")
                        retval = "'00:00:00',";
                    else
                        retval = "'" + reader.GetValue(i).ToString() + "',";
                }


                if (ftype.Contains("int") || ftype.Contains("decimal") || ftype.Contains("single") || ftype.Contains("byte"))
                {
                    if (reader.GetValue(i).ToString() == "")
                        retval = "0,";
                    else
                        retval = "" + reader.GetValue(i).ToString() + ",";
                }
                if (ftype.Contains("string"))
                {
                    string stringval = reader.GetValue(i).ToString();

                    if (stringval.Length > 500)
                    {
                        retval = "'cron',";
                    }
                    else
                    {
                        retval = "'" + stringval.Replace("'", "") + "',";
                    }

                    if (reader.IsDBNull(i))
                        retval = "null,";
                
                }
                    
                if (ftype.Contains("boolean"))
                {
                    string val = reader.GetValue(i).ToString();
                    if (val == "True")
                        retval = "1,";
                    else
                        retval = "0,";
                }

                return retval;
        }


    }
}
