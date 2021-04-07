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
    public partial class Frm_manage_Roombooking : Form
    {
        MySqlConnection cn;
        MySqlCommand cm;
        MySqlDataReader dr;
        private PictureBox pic;
        private Label names;
        private Label resident;
        private Label trype;
        private Label price;
        private Label stastus;
        private Panel pl;
        public Frm_manage_Roombooking()
        {
            InitializeComponent();
            cn = new MySqlConnection();
            cn.ConnectionString = "Server=localhost;user id=root;password=;database=apartmentsystem";
        }

        private void Frm_manage_Roombooking_Load(object sender, EventArgs e)
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
                cm = new MySqlCommand("select pic,rname ,residents,idroomtype,price,Status from rooms where Status='ຈອງ'", cn);
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

                    names = new Label();
                    names.Text = "ຫ້ອງ: " + dr["rname"].ToString();
                    names.Width = 100;
                    names.TextAlign = ContentAlignment.MiddleCenter;
                    names.Dock = DockStyle.Bottom;

                    names.ForeColor = Color.Black;
                    names.Font = new Font("Noto Serif Lao SemCond", 14, FontStyle.Bold);
                    names.Cursor = Cursors.Hand;
                    //resident
                    resident = new Label();
                    resident.Text = "ຈຳນວນຜູ້ອາໄສ: " + dr["residents"].ToString();
                    resident.Width = 100;
                    resident.TextAlign = ContentAlignment.MiddleCenter;
                    resident.Dock = DockStyle.Bottom;

                    resident.ForeColor = Color.Black;
                    resident.Font = new Font("Noto Serif Lao SemCond", 10, FontStyle.Regular);
                    resident.Cursor = Cursors.Hand;
                    //trype room
                    trype = new Label();
                    trype.Text = "ປະເພດຫ້ອງ: " + dr["idroomtype"].ToString();
                    trype.Width = 100;
                    trype.TextAlign = ContentAlignment.MiddleCenter;
                    trype.Dock = DockStyle.Bottom;

                    trype.ForeColor = Color.Black;
                    trype.Font = new Font("Noto Serif Lao SemCond", 10, FontStyle.Regular);
                    trype.Cursor = Cursors.Hand;
                    //price
                    price = new Label();
                    price.Text = "ລາຄາ: " + dr["price"].ToString();
                    price.Width = 100;
                    price.TextAlign = ContentAlignment.MiddleCenter;
                    price.Dock = DockStyle.Bottom;

                    price.ForeColor = Color.Black;
                    price.Font = new Font("Noto Serif Lao SemCond", 10, FontStyle.Regular);
                    price.Cursor = Cursors.Hand;
                    //status
                    stastus = new Label();
                    stastus.Text = "ສະຖານະ: " + dr["Status"].ToString();
                    stastus.Width = 100;
                    stastus.Height = 30;
                    stastus.TextAlign = ContentAlignment.MiddleCenter;
                    stastus.Dock = DockStyle.Bottom;

                    stastus.ForeColor = Color.Red;
                    stastus.Font = new Font("Noto Serif Lao SemCond", 10, FontStyle.Regular);
                    stastus.Cursor = Cursors.Hand;
                    //

                    pl.Controls.Add(names);
                    pl.Controls.Add(resident);
                    pl.Controls.Add(trype);
                    pl.Controls.Add(price);
                    pl.Controls.Add(stastus);
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
