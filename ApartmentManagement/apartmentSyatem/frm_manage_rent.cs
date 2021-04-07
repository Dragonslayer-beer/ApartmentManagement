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
    public partial class frm_manage_rent : Form
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
        public frm_manage_rent()
        {
            InitializeComponent();
            cn = new MySqlConnection();
            cn.ConnectionString = "Server=localhost;user id=root;password=;database=apartmentsystem";
        }

        private void frm_rent_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void GetData()
        {
            try
            {
                flow_rooms.AutoScroll = true;
                flow_rooms.Controls.Clear();
                cn.Open();
                cm = new MySqlCommand("select pic,rname ,residents,idroomtype,price,Status,idroom from rooms where Status like 'ວ່າງ'", cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {

                    pl = new Panel();
                    pl.Width = 200;
                    pl.Height = 320;
                    pl.BackColor = Color.White;
                    pl.Cursor = Cursors.Hand;

                    long len = dr.GetBytes(0, 0, null, 0, 0);
                    byte[] array = new byte[System.Convert.ToInt32(len) + 1];
                    dr.GetBytes(0, 0, array, 0, System.Convert.ToInt32(len));
                    pic = new PictureBox();
                    pic.Width = 200;
                    pic.Height = 200;
                    pic.BackgroundImageLayout = ImageLayout.Stretch;
                   
                    pic.BorderStyle = BorderStyle.FixedSingle;
                    pic.Tag = dr["idroom"].ToString();

                    names = new Label();
                    names.Text = "ຫ້ອງ: " + dr["rname"].ToString();
                    names.Width = 100;
                    names.TextAlign = ContentAlignment.MiddleCenter;
                    names.Dock = DockStyle.Bottom;
                    names.ForeColor = Color.Black;
                    names.Font = new Font("Noto Serif Lao SemCond", 14, FontStyle.Bold);
                    names.Cursor = Cursors.Hand;
                    names.Tag = dr["idroom"].ToString();
                    //resident
                    resident = new Label();
                    resident.Text = "ຈຳນວນຜູ້ອາໄສ: " +dr["residents"].ToString();
                    resident.Width = 100;
                    resident.TextAlign = ContentAlignment.MiddleCenter;
                    resident.Dock = DockStyle.Bottom;
                    resident.ForeColor = Color.Black;
                    resident.Font = new Font("Noto Serif Lao SemCond", 10, FontStyle.Regular);
                    resident.Cursor = Cursors.Hand;
                    resident.Tag = dr["idroom"].ToString();
                    //trype room
                    trype = new Label();
                    trype.Text = "ປະເພດຫ້ອງ: " + dr["idroomtype"].ToString();
                    trype.Width = 100;
                    trype.TextAlign = ContentAlignment.MiddleCenter;
                    trype.Dock = DockStyle.Bottom;
                    trype.ForeColor = Color.Black;
                    trype.Font = new Font("Noto Serif Lao SemCond", 10, FontStyle.Regular);
                    trype.Cursor = Cursors.Hand;
                    trype.Tag = dr["idroom"].ToString();
                    //price
                    price = new Label();
                    price.Text = "ລາຄາ: " + dr["price"].ToString();
                    price.Width = 100;
                    price.TextAlign = ContentAlignment.MiddleCenter;
                    price.Dock = DockStyle.Bottom;
                    price.ForeColor = Color.Black;
                    price.Font = new Font("Noto Serif Lao SemCond", 10, FontStyle.Regular);
                    price.Cursor = Cursors.Hand;
                    price.Tag = dr["idroom"].ToString();
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
                    stastus.Tag = dr["idroom"].ToString();
                    //
     

                    MemoryStream ms = new MemoryStream(array);
                    Bitmap bitmap = new Bitmap(ms);
                    pic.BackgroundImage = bitmap;

                    pl.Controls.Add(names);
                    pl.Controls.Add(resident);
                    pl.Controls.Add(trype);
                    pl.Controls.Add(price);
                    pl.Controls.Add(stastus);
                    pl.Controls.Add(pic);
                    flow_rooms.Controls.Add(pl);    
                    pic.Cursor = Cursors.Hand;


                    pic.Click += (sender, e) => OnClick(this, e, pic.Tag.ToString());

             


                }
                dr.Close();
                cn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public void OnClick(object sender, EventArgs e ,String tag)
        {
    
            frm_manage_renting renting = new frm_manage_renting(tag.ToString());
            renting.ShowDialog();

            
        }

        private void flow_rooms_Paint(object sender, PaintEventArgs e)
        {
            

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {
            //this.Dispose();
            //frm_manage_renting renting = new frm_manage_renting();
            //renting.ShowDialog();
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
