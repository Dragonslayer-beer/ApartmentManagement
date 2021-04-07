using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace apartmentSyatem
{
    public partial class flogin : Form
    {
        MySqlConnection conn = new MySqlConnection("server=localhost;user=root;password=;database=apartmentsystem");
        MySqlDataAdapter adt = new MySqlDataAdapter();
        MySqlCommand cmd = new MySqlCommand();
        public flogin()
        {
            //Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("LA",false);
            InitializeComponent();
        }

        private void flogin_Load(object sender, EventArgs e)
        {
            make.Visible = true;
            if (Properties.Settings.Default.UserNmae != string.Empty)
            {
                txt_user.Text = Properties.Settings.Default.UserNmae;
            }
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            make.Visible = false;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            txt_user.Text = "";
            txt_password.Text = "";
            make.Visible = true;
            if (conn.State == ConnectionState.Open)
            {
                try
                {
                    conn.Open();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            m.Show();
            this.Hide();
        }
        //private void ChangeLanguage(string locale)
        //{
        //    foreach (Control c in )
        //    {
        //        ComponentResourceManager resources = new ComponentResourceManager(typeof(flogin));
        //        resources.ApplyResources(c, c.Name, new CultureInfo(locale));
        //    }
        //}

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try {
                rember();
                if (txt_user.Text=="" )
                {
                    MessageBox.Show("No data at box password and user!","Error");
                    return;
                }
                else {
                    conn.Open();
                    String sql = "select *from user where user='" + txt_user.Text + "'and password='" + txt_password.Text + "'";
                    cmd = new MySqlCommand(sql, conn);
                    MySqlDataReader red = cmd.ExecuteReader();
                    if (red.Read())
                    {
                        Main m = new Main();
                        m.Show();
                        this.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("cann't coonect check your password or user");
                    }
                    conn.Close();
                } }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
        }

        private void txt_user_Enter(object sender, EventArgs e)
        {
            CultureInfo culture = new CultureInfo("en-US");
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(culture);
        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            rember();
        }
        public void rember()
        {
            if (chk_remeber.Checked == true)
            {
                Properties.Settings.Default.UserNmae = txt_user.Text;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.UserNmae = "";
                Properties.Settings.Default.Save();
            }
        }
    }
}

