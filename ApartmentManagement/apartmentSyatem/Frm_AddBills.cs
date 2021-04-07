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
    public partial class Frm_AddBills : Form
    {
        public Frm_AddBills()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Panel2.Controls.Clear();
            frm_bill_water_elec wal = new frm_bill_water_elec();
            wal.TopLevel = false;
            Panel2.Controls.Add(wal);
            wal.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Panel2.Controls.Clear();
            frm_bill_maintain wal = new frm_bill_maintain();
            wal.TopLevel = false;
            Panel2.Controls.Add(wal);
            wal.Show();
        }
    }
}
