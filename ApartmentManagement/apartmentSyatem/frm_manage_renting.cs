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
    public partial class frm_manage_renting : Form
      {
        MySqlConnection conn = new MySqlConnection("server=localhost;user=root;password=;database=apartmentsystem");
        MySqlDataAdapter adt = new MySqlDataAdapter();
        MySqlCommand cmd = new MySqlCommand();
        string tag;
        private string X;

        public frm_manage_renting(string a)
        {
            InitializeComponent();
            this.tag = a;
        }
      
        private void guna2GroupBox3_Click(object sender, EventArgs e)
        {

        }

        private void frm_manage_renting_Load(object sender, EventArgs e)
        {
            frm_manage_rent fm = new frm_manage_rent();
            txt_id.Text = tag;
            guna2PictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            LoadData();
            fillbox1();
        }





        private void LoadData()
        {
            try
            {
                conn.Open();

                cmd = new MySqlCommand("Select rname, idroomtype ,price, waterBill, elecBill, lname, fname, phone, gencyphone from rooms where idroom ='" + txt_id.Text + "'", conn);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    txtroom.Text = dr.GetString("rname");
                    catalog.Text = dr.GetString("idroomtype");
                    pice.Text = dr.GetString("price");
                    pumnum.Text = dr.GetString("waterBill");
                    Faifar.Text = dr.GetString("elecBill");
                    names.Text = dr.GetString("lname");
                    surnames.Text = dr.GetString("fname");
                    txt_phone.Text = dr.GetString("phone");
                    txt_phone_2.Text = dr.GetString("gencyphone");

                }
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Image files (*.png | *.png|(*.jpg)|*.jpg|(*.gif)|*.gif";
                open.ShowDialog();
                guna2PictureBox1.Image = Image.FromFile(open.FileName);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public void fillbox1()
        {
            try
            {
                conn.Open();
                string sql = "select * from roomcatalog";
                cmd = new MySqlCommand(sql, conn);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (catalog.Text == dr.GetString("idroomtype"))
                    {
                        catalog.Text = dr.GetString("roomtype");
                    }
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
