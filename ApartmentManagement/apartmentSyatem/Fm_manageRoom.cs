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
    public partial class Fm_manageRoom : Form
    {
        MySqlConnection conn = new MySqlConnection("server=localhost;user=root;password=;database=apartmentsystem");
        MySqlDataAdapter adt = new MySqlDataAdapter();
        MySqlCommand cmd = new MySqlCommand();
        public Fm_manageRoom()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Frm_manage_AllRoom all = new Frm_manage_AllRoom();
            all.ShowDialog();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            frm_manage_rent rent = new frm_manage_rent();
            rent.ShowDialog();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            Fm_manageRoom room = new Fm_manageRoom();
            room.Refresh();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Frm_manage_Roombooking booking = new Frm_manage_Roombooking();
            booking.ShowDialog();
        }

        private void Fm_manageRoom_Load(object sender, EventArgs e)
        {
            count_Booking();
            count_All();
            count_free();
            count_nofree();
        }
        public void count_Booking()
        {
            try
            {
                conn.Open();
               
                cmd = new MySqlCommand("Select COUNT(*) FROM rooms WHERE Status Like  'ຈອງ'", conn);
                label_booking.Text = cmd.ExecuteScalar().ToString();
             
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void count_All()
        {
            try
            {
                conn.Open();

                cmd = new MySqlCommand("Select COUNT(*) FROM rooms ", conn);
                label_allRoom.Text = cmd.ExecuteScalar().ToString();

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void count_free()
        {
            try
            {
                conn.Open();

                cmd = new MySqlCommand("Select COUNT(*) FROM rooms where Status like 'ວ່າງ' ", conn);
                label_availability.Text = cmd.ExecuteScalar().ToString();

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void count_nofree()
        {
            try
            {
                conn.Open();

                cmd = new MySqlCommand("Select COUNT(*) FROM rooms where Status like 'ຖຶກເຊົ່າ' ", conn);
                label_NOavailability.Text = cmd.ExecuteScalar().ToString();

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void guna2Button3_Click(object sender, EventArgs e)
        {
            frm_manage_rent rent = new frm_manage_rent();
            rent.ShowDialog();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            frm_manage_rented rented = new frm_manage_rented();
            rented.ShowDialog();
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            frm_manage_build build = new frm_manage_build();
            build.ShowDialog();
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            Frm_manage_exit ex = new Frm_manage_exit();
            ex.ShowDialog();
        }
    }
}
