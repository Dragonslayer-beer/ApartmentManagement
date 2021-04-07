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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            Frm_main info = new Frm_main();
            info.TopLevel = false;
            panel2.Controls.Add(info);
            info.Show();

            button1.BackColor = Color.LightGray;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            button6.BackColor = Color.White;
            button7.BackColor = Color.White;
          
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
            flogin flogin = new flogin();
            flogin.Show();
        }

        private void ບນຊToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ຈດການຜໃຊລະບບToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            Fm_showAlluser fuser = new Fm_showAlluser();
            fuser.TopLevel = false;
            panel2.Controls.Add(fuser);
            fuser.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            Fm_manageRoom room = new Fm_manageRoom();
            room.TopLevel = false;
            panel2.Controls.Add(room);
            room.Show();

            button1.BackColor = Color.White;
            button2.BackColor = Color.LightGray;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            button6.BackColor = Color.White;
            button7.BackColor = Color.White;
        }

        private void ເພມຜໃຊລະບບໃໝToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            F_Add_manageUser room = new F_Add_manageUser();
            room.TopLevel = false;
            panel2.Controls.Add(room);
            room.Show();
        }

        private void ສະແດງທງໝດToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            Fm_showAlluser fuser = new Fm_showAlluser();
            fuser.TopLevel = false;
            panel2.Controls.Add(fuser);
            fuser.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            button3.BackColor = Color.LightGray;
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            button6.BackColor = Color.White;
            button7.BackColor = Color.White;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            Frm_AddBills rent = new Frm_AddBills();
            rent.TopLevel = false;
            panel2.Controls.Add(rent);
            rent.Show();
            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.LightGray;
            button5.BackColor = Color.White;
            button6.BackColor = Color.White;
            button7.BackColor = Color.White;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            frm_pay_water_elec pay = new frm_pay_water_elec();
            pay.TopLevel = false;
            panel2.Controls.Add(pay);
            pay.Show();

            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            button5.BackColor = Color.LightGray;
            button6.BackColor = Color.White;
            button7.BackColor = Color.White;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            button6.BackColor = Color.LightGray;
            button7.BackColor = Color.White;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            Frm_report report = new Frm_report();
            report.TopLevel = false;
            panel2.Controls.Add(report);
            report.Show();
            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            button6.BackColor = Color.White;
            button7.BackColor = Color.LightGray;
        }
    }
}
