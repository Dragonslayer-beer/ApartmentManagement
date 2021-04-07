using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace apartmentSyatem
{
    public partial class F_Add_manageUser : Form
    {
        MySqlConnection conn = new MySqlConnection("server=localhost;user=root;password=;database=apartmentsystem");
        MySqlDataAdapter adt = new MySqlDataAdapter();
        MySqlCommand cmd = new MySqlCommand();
        public F_Add_manageUser()
        {
            InitializeComponent();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.ShowDialog();
            String path = open.FileName;
            picturePro.Load(path);
            txt_path.Text = path;
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            insert();
        }
        public void insert()
        {
            try
            {
                string sex;
                if (radio_man.Checked == true)
                {
                    sex = "ຊາຍ";
                }
                else
                {
                    sex = "ຍິງ";
                }

                conn.Open();
               
                MemoryStream ms = new MemoryStream();
                picturePro.Image.Save(ms, picturePro.Image.RawFormat);
                byte[] img = ms.ToArray();

                cmd = new MySqlCommand("insert into user values( @uid,@user, @lname, @fname, @gender, @password, @profile, @Status, @picpath)", conn);
                cmd.Parameters.AddWithValue("@uid", "");
                cmd.Parameters.AddWithValue("@user", txt_user.Text);
                cmd.Parameters.AddWithValue("@lname", txt_name.Text);
                cmd.Parameters.AddWithValue("@fname", txt_surname.Text);
                cmd.Parameters.AddWithValue("@gender", sex);
                cmd.Parameters.AddWithValue("@password", txt_user.Text);
                cmd.Parameters.AddWithValue("@profile", img);
                cmd.Parameters.AddWithValue("@Status", combo_status.Text);
                cmd.Parameters.AddWithValue("@picpath", txt_path.Text);
                cmd.ExecuteScalar();
                conn.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
    }
}
