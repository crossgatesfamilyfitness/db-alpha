using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Dapper;
using Google.Protobuf.WellKnownTypes;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace cgff_connect
{
    public static class workhorse
    {
        public static int InsertNew(Guid idvalue, string tableName, string id_column, string alternateDate = "", string modifyColumn = "")
        {

            cgff_connect.transactionlog tl = new cgff_connect.transactionlog("start with sql", "Before Insert New", idvalue.ToString(), tableName, 0, "sql");
            tl.InsertLog();

            string remote = Connect.ConnectToRemote();
            string local = Connect.ConnectToLocal();

            MySqlConnection localConnection = new MySqlConnection(local);
            MySqlConnection remoteConnection = new MySqlConnection(remote);

            string selectMaxString = string.Empty;
            string selectRemoteString = string.Empty;

            if (alternateDate == "")
            {
                selectMaxString = @"SELECT max(`" + id_column + "`) FROM `" + tableName + "`";
                
            }
            else
            {
                DateTime dateVal = new DateTime();
                DateTime.TryParse(alternateDate, out dateVal);

                selectMaxString = @"SELECT min(`" + id_column + "`) FROM `" + tableName + "` where `" + modifyColumn + "` > '" + dateVal.ToString("yyyy-MM-dd HH:mm:ss") + "'"; 
            }
            localConnection.Open();

            var cmd = new MySqlCommand(selectMaxString, localConnection);
            object maxValue = cmd.ExecuteScalar();

            if (alternateDate == "")
            {
                selectRemoteString = @"SELECT * FROM `" + tableName + "` where `" + id_column + "` > " + maxValue.ToString();
            }else
            {
                DateTime dateVal = new DateTime();
                DateTime.TryParse(alternateDate, out dateVal);
                selectRemoteString = @"SELECT * FROM `" + tableName + "` where `" + id_column + "` > " + maxValue.ToString() + " and `" + modifyColumn + "` > '" + dateVal.ToString("yyyy-MM-dd HH:mm:ss") + "'";
            }


            int i = 0;
            if (maxValue.ToString() != "")
            { 
                remoteConnection.Open();
                cmd = new MySqlCommand(selectRemoteString, remoteConnection);
                MySqlDataReader reader = cmd.ExecuteReader();

                List<string> columnNames = helpers.GetColumnNames(reader);
                List<string> columnTypes = helpers.GetColumnTypes(reader);

                string columns = string.Empty;
                foreach (string s in columnNames)
                {
                    columns = columns + s + ",";
                }

                columns = columns.Substring(0, columns.Length - 1);
                List<MySqlCommand> commands = new List<MySqlCommand>();
                MySqlConnection insertConnection = new MySqlConnection(Connect.ConnectToLocal());
                insertConnection.Open();
                while (reader.Read())
                {
                    string cellValues = string.Empty;
                    string sqlString = "insert into `" + tableName + "` (" + columns + ") values (";

                    List<string> rowValues = helpers.GetRowValues(reader);
                    foreach (string s in rowValues)
                        cellValues += s;

                    cellValues = cellValues.Substring(0, cellValues.Length - 1);
                    var insert = new MySqlCommand(sqlString + cellValues + ")", insertConnection);
                    commands.Add(insert);
                }

                remoteConnection.Close();
                remoteConnection.Dispose();
                localConnection.Close();
                localConnection.Dispose();
            
            
            
                foreach (var insert in commands)
                {
                    var transaction = insertConnection.BeginTransaction();
                    MySqlCommand _foreignkey = new MySqlCommand("SET foreign_key_checks = 0;", insertConnection);
                    _foreignkey.ExecuteNonQuery();
                    try
                    {
                        int rows = insert.ExecuteNonQuery();
                        transaction.Commit();
                        i += rows;
                    }
                    catch (Exception ex)
                    {
                        new errorlog("error in insert", "", tableName, insert.CommandText).InsertErrorLog();
                        transaction.Rollback();
                    }

                }
                insertConnection.Close();
                insertConnection.Dispose();
            }

            cgff_connect.transactionlog tl2 = new cgff_connect.transactionlog("done with sql", "After Insert New", idvalue.ToString(), tableName, i, "sql");
            tl2.InsertLog();
            //Console.WriteLine(i.ToString() + " of " + commands.Count.ToString());
            
            return i;
        }


        public static int RemoveRow(Guid idValue, string tableName, string log_column_id)
        {
            int returnValue = 0;
            cgff_connect.transactionlog tl = new cgff_connect.transactionlog("done with sql", "Before Remove", idValue.ToString(), tableName, 0, "sql");
            tl.InsertLog();
            
            DateTime dateVal = DateTime.Now;
            
            // Kevin added this at 3:19pm on 10/31/23.  I think this is how we decide how far back to adjust the modified_date
            dateVal = dateVal.AddHours(-18);

            string maxDateString = string.Empty;
            maxDateString = dateVal.ToString("yyyy-MM-dd HH:mm:ss");

            string local = Connect.ConnectToLocal();
            
            string log = Connect.ConnectToRemoteLog();
            MySqlConnection logConnection = new MySqlConnection(log);
            logConnection.Open();


            MySqlCommand cmdlog = new MySqlCommand("SELECT `" + log_column_id + "` FROM `" + tableName + "` where `type`='remove' and modified_date > '" + maxDateString + "'", logConnection);

            try
            {
                MySqlDataReader _reader = cmdlog.ExecuteReader();

                while (_reader.Read())
                {
                    int idToRemove = Convert.ToInt32(_reader[log_column_id].ToString());


                    using (MySqlConnection localConnection = new MySqlConnection(local))
                    {
                        localConnection.Open();
                        var transaction = localConnection.BeginTransaction();

                        try
                        {
                            MySqlCommand _remove = new MySqlCommand("delete from `" + tableName + "` where id=" + idToRemove.ToString(), localConnection);
                            returnValue += _remove.ExecuteNonQuery();
                            transaction.Commit();
                        }
                        catch (Exception ex)
                        {
                            new errorlog("error in remove", "", tableName, "delete from `" + tableName + "` where id=" + idToRemove.ToString()).InsertErrorLog();
                            transaction.Rollback();
                        }
                        localConnection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                new errorlog("error in remove", "", tableName, ex.Message).InsertErrorLog();
            }
            cgff_connect.transactionlog tl2 = new cgff_connect.transactionlog("done with sql", "After Remove", idValue.ToString(), tableName, returnValue, "sql");
            tl2.InsertLog();

            return returnValue;
        }

        public static int UpdateExisting(Guid idvalue, string tableName, string modify_column, string id_column = "id", string alternateDate = "")
        {

            cgff_connect.transactionlog tl = new cgff_connect.transactionlog("done with sql", "Before Update Existing", idvalue.ToString(), tableName, 0, "sql");
            tl.InsertLog();

            string remote = Connect.ConnectToRemote();
            string local = Connect.ConnectToLocal();

            MySqlConnection localMaxDateConnection = new MySqlConnection(local);
            localMaxDateConnection.Open();

            MySqlCommand _maxDateValue = new MySqlCommand("select max(`" + modify_column + "`) as maxivalue from `" + tableName + "`", localMaxDateConnection);
            object maxVal = _maxDateValue.ExecuteScalar();

            DateTime dateVal = new DateTime();

            if (alternateDate != "")
                DateTime.TryParse(alternateDate, out dateVal);
            else
                DateTime.TryParse(maxVal.ToString(), out dateVal);

            // Kevin added this at 3:19pm on 10/31/23.  I think this is how we decide how far back to adjust the modified_date
            dateVal = dateVal.AddHours(-18);

            string maxDateString = string.Empty;
            if (dateVal != null)
            {
                maxDateString = dateVal.ToString("yyyy-MM-dd HH:mm:ss");
            }

            localMaxDateConnection.Close();
            localMaxDateConnection.Dispose();

            //Console.WriteLine("Using remote connstring=" + remote);

            MySqlConnection remoteConnection = new MySqlConnection(remote);
            remoteConnection.Open();
            //Console.WriteLine("open");

            if (maxDateString == String.Empty)
                return 0;

            MySqlCommand cmdremote = new MySqlCommand("SELECT * FROM `" + tableName + "` where `" + modify_column + "` > '" + maxDateString + "'", remoteConnection);
            cmdremote.CommandTimeout = 10000;
            MySqlDataReader _reader = cmdremote.ExecuteReader();
            List<id_modified> remotemodified = new List<id_modified>();

            List<string> columnNames = new List<string>();
            Dictionary<string, List<string>> remoteValues = new Dictionary<string, List<string>>();
            List<string> valuesList = new List<string>();

            int n = 0;
            while (_reader.Read())
            {
                if (n == 0)
                { 
                    for (int i = 0; i < _reader.FieldCount;i++)
                        columnNames.Add(_reader.GetName(i));
                    n++;    
                }    

                valuesList = new List<string>();
                for (int i = 0; i < _reader.FieldCount;i++)
                {
                    valuesList.Add(helpers.ResolveValueByType(_reader, i));
                }

                if (!remoteValues.ContainsKey(_reader[id_column].ToString()))
                    remoteValues.Add(_reader[id_column].ToString(), valuesList);
            }

            remoteConnection.Close();
            remoteConnection.Dispose();
            
            List<string> updateList = new List<string>();

            foreach(string idof in remoteValues.Keys)
            {
                List<string> convertoUpdate = remoteValues[idof];

                int colCount = 0;
                string setstring = string.Empty;
                string updateStatement = "update `" + tableName + "` set ";

                foreach(string val in convertoUpdate)
                {
                    if (columnNames[colCount] != id_column)
                        setstring = setstring + "`" + columnNames[colCount].ToString() + "`=" + val + " ";
                    colCount +=1;
                }
                setstring = setstring.Substring(0, setstring.Length - 2);

                updateStatement = updateStatement + setstring + " where " + id_column + " =" + idof;
                updateList.Add(updateStatement);
            }

            //Console.WriteLine("Using Local ConnectString= " + local);
            MySqlConnection localConnection = new MySqlConnection(local);
            
            localConnection.Open();
            //Console.WriteLine("Conn open");

            int totalRows = 0;

            foreach(string update in updateList)
            {

                var transaction = localConnection.BeginTransaction();
                MySqlCommand _foreignkey = new MySqlCommand("SET foreign_key_checks = 0;", localConnection);
                _foreignkey.ExecuteNonQuery();
                try
                {
                    MySqlCommand cmdlocal = new MySqlCommand(update, localConnection);
                    int rows = cmdlocal.ExecuteNonQuery();
                    //Console.WriteLine(rows.ToString() + " updated");
                    totalRows += rows;
                    transaction.Commit();
                }
                catch(Exception ex)
                {
                    new errorlog("error in update", "", tableName, update).InsertErrorLog();
                    transaction.Rollback();
                }
            }

            cgff_connect.transactionlog tl2 = new cgff_connect.transactionlog("done with sql", "After Update Existing", idvalue.ToString(), tableName, totalRows, "sql");
            tl2.InsertLog();

            localConnection.Close();
            localConnection.Dispose();
            return totalRows;

        }


        public static List<configTable> GetConfiguration()
        {
            List<configTable> retVal = new List<configTable>();

            string connString = Connect.ConnectToLocal();
            MySqlConnection connConfig = new MySqlConnection(connString);
            connConfig.Open();

            retVal = connConfig.Query<configTable>("select * from batch_configure").ToList<configTable>();
            
            connConfig.Close();
            connConfig.Dispose();

            return retVal;
        }


    }
}
