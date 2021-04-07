using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace apartmentSyatem
{
    public partial class frm_report_allRooms : Form
    {
        MySqlConnection conn = new MySqlConnection("server=localhost;user=root;password=;database=apartmentsystem");
        MySqlDataAdapter adt = new MySqlDataAdapter();
        MySqlCommand cmd = new MySqlCommand();
        public frm_report_allRooms()
        {
            InitializeComponent();
        }

        private void frm_report_allRooms_Load(object sender, EventArgs e)
        {
            load();
        }
        public void load()
        {


            DataSet ds = new DataSet();

            MySqlDataAdapter da = new MySqlDataAdapter();
            da = new MySqlDataAdapter("SELECT * FROM rooms", conn);
            da.Fill(ds, "rooms");
            cry_reportAllroom report = new cry_reportAllroom();
            report.SetDataSource(ds);
            view_allroom.ReportSource = report;
            view_allroom.RefreshReport();

        }
    }
}
