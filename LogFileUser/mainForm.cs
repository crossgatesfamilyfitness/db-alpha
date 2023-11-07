using cgff_connect;
using cgff_connect.localModels;
using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Pkcs;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata;

namespace LogFileUser
{
    public partial class mainForm : Form
    {

        public List<configTable> configTables;
        public mainForm()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Guid guid = Guid.NewGuid();
            var c = from con in configTables where con.table_name == cmbTables.Text select con;

            foreach (configTable cc in configTables)
            {
                if (c != null)
                {
                    if (rbModify.Checked)
                    {
                        cgff_connect.workhorse.UpdateExisting(guid, cc.table_name, cc.update_column_name, cc.id_column_name, dateTimePicker1.Text.ToString());
                    }
                    if (rbInsert.Checked)
                    {
                        if (cc.update_column_name != "*")
                            cgff_connect.workhorse.InsertNew(guid, cc.table_name, cc.id_column_name, dateTimePicker1.Text.ToString(), cc.update_column_name);
                    }
                }
            }

        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            cmbTables.Items.Clear();
            configTables = cgff_connect.workhorse.GetConfiguration();

            foreach (configTable c in configTables)
            {
                cmbTables.Items.Add(c.table_name);
            }

            cmbTables.SelectedIndex = 0;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string local = cgff_connect.Connect.ConnectToLocal();
            string select = "select id, user_id, `in` from checkin";
            List<checkinCleaner> _toInspect = new List<checkinCleaner>();
            List<checkinCleaner> _toRemove = new List<checkinCleaner>();
            using (MySqlConnection conn = new MySqlConnection(local))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(select, conn);
                MySqlDataReader _reader = cmd.ExecuteReader();

                while (_reader.Read())
                {
                    _toInspect.Add(new checkinCleaner(Convert.ToInt64(_reader["id"]), Convert.ToUInt32(_reader["user_id"]), (DateTime)_reader["in"]));
                }

                conn.Close();
            }

            foreach (checkinCleaner cl in _toInspect)
            {
                var rp = from c in _toInspect
                         where c.id != cl.id && c.user_id == cl.user_id
                         && c.check_in < cl.check_in.AddMinutes(10)
                         && c.check_in > cl.check_in.AddMinutes(-10)
                         select c;

                foreach(checkinCleaner _remover in rp)
                {
                    _toRemove.Add(_remover);
                }
            }

            dgv_potential.DataSource = _toRemove;

        }
    }
}








