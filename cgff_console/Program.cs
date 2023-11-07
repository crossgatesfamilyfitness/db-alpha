// See https://aka.ms/new-console-template for more information


using cgff_connect;
using Google.Protobuf.WellKnownTypes;

List<configTable> configTable = cgff_connect.workhorse.GetConfiguration();
Guid _idValue = Guid.NewGuid();
cgff_connect.transactionlog tl2 = new cgff_connect.transactionlog("Kick Off", "Start RUN", _idValue.ToString(), "BATCH RUN BEGIN", 0, "sql");
tl2.InsertLog();


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

    if (cf.is_logged == 1)
    {
        cgff_connect.workhorse.RemoveRow(_idValue, cf.table_name, cf.log_id_field);
    }
}

cgff_connect.transactionlog tl = new cgff_connect.transactionlog("Complete", "After RUN", _idValue.ToString(), "BATCH RUN COMPLETE", 0, "sql");
tl.InsertLog();


