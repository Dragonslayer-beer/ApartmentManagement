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
    public partial class frm_pay_water_elec : Form
    {
        MySqlConnection cn;
        MySqlCommand cm;
        MySqlDataReader dr;
        private PictureBox pic;
        private Label names;
     
        private Label trype;
        private Label price;
      
        private Panel pl;
        public frm_pay_water_elec()
        {
            InitializeComponent();
            cn = new MySqlConnection();
            cn.ConnectionString = "Server=localhost;user id=root;password=;database=apartmentsystem";
        }

        private void frm_pay_water_elec_Load(object sender, EventArgs e)
        {
            GetData();
        }
        private void GetData()
        {
            try
            {
                flow_rooms.AutoScroll = true;
                flow_rooms.Controls.Clear();
                cn.Open();
                cm = new MySqlCommand("select pic,rname ,idroomtype,price,money_water from rooms ", cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {

                    pl = new Panel();
                    pl.Width = 200;
                    pl.Height = 320;
                    pl.BackColor = Color.White;

                    long len = dr.GetBytes(0, 0, null, 0, 0);
                    byte[] array = new byte[System.Convert.ToInt32(len) + 1];
                    dr.GetBytes(0, 0, array, 0, System.Convert.ToInt32(len));
                    pic = new PictureBox();
                    pic.Width = 200;
                    pic.Height = 200;
                    pic.BackgroundImageLayout = ImageLayout.Stretch;
                    MemoryStream ms = new MemoryStream(array);
                    Bitmap bitmap = new Bitmap(ms);
                    pic.BackgroundImage = bitmap;
                    //name
                    names = new Label();
                    names.Text = "ຫ້ອງ: " + dr["rname"].ToString();
                    names.Width = 100;
                    names.Height = 30;
                    names.TextAlign = ContentAlignment.MiddleCenter;
                    names.Dock = DockStyle.Bottom;

                    names.ForeColor = Color.Black;
                    names.Font = new Font("Noto Serif Lao SemCond", 14, FontStyle.Bold);
                    names.Cursor = Cursors.Hand;
                
                    //trype room
                    trype = new Label();
                    trype.Text = "ປະເພດຫ້ອງ: " + dr["idroomtype"].ToString();
                    trype.Width = 100;
                    trype.TextAlign = ContentAlignment.MiddleCenter;
                    trype.Dock = DockStyle.Bottom;

                    trype.ForeColor = Color.Black;
                    trype.Font = new Font("Noto Serif Lao SemCond", 10, FontStyle.Regular);
                    trype.Cursor = Cursors.Hand;
               
              
                    // water

                    price = new Label();
                    price.Text = "ລາຄານ້ຳ: " + dr["money_water"].ToString();
                    price.Width = 100;
                    price.TextAlign = ContentAlignment.MiddleCenter;
                    price.Dock = DockStyle.Bottom;

                    price.ForeColor = Color.Red;
                    price.Font = new Font("Noto Serif Lao SemCond", 10, FontStyle.Regular);
                    price.Cursor = Cursors.Hand;

                    pl.Controls.Add(names);
                    pl.Controls.Add(trype);
                    pl.Controls.Add(price);
                    pl.Controls.Add(pic);

                    flow_rooms.Controls.Add(pl);


                }
                dr.Close();
                cn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
