using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace apartmentSyatem
{
    public partial class Frm_main_addNewRoom : Form
    {
        MySqlConnection conn = new MySqlConnection("server=localhost;user=root;password=;database=apartmentsystem");
        MySqlDataAdapter adt = new MySqlDataAdapter();
        MySqlCommand cmd = new MySqlCommand();
       
        private string X;
        public Frm_main_addNewRoom()
        {
            InitializeComponent();
        }

        private void Frm_main_addNewRoom_Load(object sender, EventArgs e)
        {
            txt_id.Enabled = false;
            fillbox();
            showdata();


        }
        DataSet ds = new DataSet();
        DataTable tb = new DataTable();
        public void showdata()
        {
            try
            {
                conn.Open();
              
                adt = new MySqlDataAdapter("SELECT `idroom`, `rname`, `residents`, `idroomtype`, `price` FROM `rooms`", conn);
                adt.Fill(tb);
                tb_showdata.DataSource =tb;

                tb_showdata.Columns[0].HeaderText = "ລະຫັດ";
                tb_showdata.Columns[1].HeaderText = "ຊື່ຫ້ອງ";
                tb_showdata.Columns[2].HeaderText = "ຈຳນວນຜູ້ອາໄສ";
                tb_showdata.Columns[3].HeaderText = "ປະເພດຫ້ອງ";
                tb_showdata.Columns[4].HeaderText = "ລາຄາ";

                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        public void fillbox()
        {
            try
            {
                conn.Open();
                string sql = "select * from roomcatalog";
                cmd = new MySqlCommand(sql, conn);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cobobox_catalog.Items.Add(dr.GetString("roomtype"));
                }

                if (cobobox_catalog.Text == dr.GetString("roomtype"))
                {
                    X = dr.GetString("idroomtype");
                }

                //DataTable tb = new DataTable();
                //MySqlDataAdapter adt = new MySqlDataAdapter("select * from roomcatalog", conn);
                //adt.Fill(tb);

                //cobobox_catalog.DataSource = tb;
                //cobobox_catalog.DisplayMember = "roomtype";
                //cobobox_catalog.ValueMember = "idroomtype";
                //a = new Label();
                //cobobox_catalog.Text = a.Text;
                conn.Close();
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
                    if (cobobox_catalog.Text == dr.GetString("roomtype"))
                    {
                        X = dr.GetString("idroomtype");
                    }
                }

               

                //DataTable tb = new DataTable();
                //MySqlDataAdapter adt = new MySqlDataAdapter("select * from roomcatalog", conn);
                //adt.Fill(tb);

                //cobobox_catalog.DataSource = tb;
                //cobobox_catalog.DisplayMember = "roomtype";
                //cobobox_catalog.ValueMember = "idroomtype";
                //a = new Label();
                //cobobox_catalog.Text = a.Text;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void insert()
        {
            fillbox1();
        
            try
            {
         
                MemoryStream ms = new MemoryStream();
                pic_room.Image.Save(ms, ImageFormat.Jpeg);
                byte[] arrImage = ms.GetBuffer();
                conn.Open();
                cmd = new MySqlCommand("insert into rooms values ( @idroom,@rname,@residents,@idroomtype,@price,@Status,@waterBill,@elecBill,@pic,@lname,@fname, @phone,@family_pic, @birthday,@gencyphone, @datestart, @dateend, @total, @money_water, @money_lece) ", conn);
              // new room
                cmd.Parameters.AddWithValue("@idroom", "");
                cmd.Parameters.AddWithValue("@residents", txt_resident.Text);
                cmd.Parameters.AddWithValue("@rname", txt_name.Text);
                cmd.Parameters.AddWithValue("@idroomtype", X); 
                cmd.Parameters.AddWithValue("@price", txt_price.Text);
                cmd.Parameters.AddWithValue("@Status", "ວ່າງ");
                cmd.Parameters.AddWithValue("@waterBill", "0");
                cmd.Parameters.AddWithValue("@elecBill", "0");
                cmd.Parameters.AddWithValue("@pic",arrImage);
                //renting in fo *fix
                cmd.Parameters.AddWithValue("@lname", "ກ" );
                cmd.Parameters.AddWithValue("@fname", "ກ");
                cmd.Parameters.AddWithValue("@phone", "0");
                cmd.Parameters.AddWithValue("@family_pic", arrImage);
                cmd.Parameters.AddWithValue("@birthday", DateTime.Now);
                cmd.Parameters.AddWithValue("@gencyphone", "0");
                cmd.Parameters.AddWithValue("@datestart", DateTime.Now);
                cmd.Parameters.AddWithValue("@dateend", DateTime.Now);
                cmd.Parameters.AddWithValue("@total", "0");
                cmd.Parameters.AddWithValue("@money_water", "0");
                cmd.Parameters.AddWithValue("@money_lece", "0");
              
                cmd.ExecuteNonQuery();

                conn.Close();

                Remove();
                MessageBox.Show("SAVE LEO2");
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
                pic_room.Image = Image.FromFile(open.FileName);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
           

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            insert();
            showdata();
            KUBKHUEKAO();
        }
        public void Delete()
        {
            try
            {
                conn.Open();
                cmd = new MySqlCommand("delete from rooms where idroom like '" + txt_id.Text + "'", conn);
                cmd.ExecuteNonQuery();
                Remove();
                MessageBox.Show("Lob2 LEO2");
                conn.Close();
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
        
        }

        private void cobobox_catalog_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Delete();
            showdata();
            KUBKHUEKAO();


        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Remove();
            showdata();
            KUBKHUEKAO();
        }

        public void Remove()
        {

            while (tb_showdata.Rows.Count > 0)
            {
                tb_showdata.Rows.Remove(tb_showdata.Rows[0]);
            }
        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_showdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

         
            int id = Convert.ToInt32(tb_showdata.Rows[e.RowIndex].Cells["idroom"].FormattedValue);
            tb_showdata.CurrentRow.Selected = true;
            txt_id.Text = tb_showdata.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_name.Text = tb_showdata.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_resident.Text = tb_showdata.Rows[e.RowIndex].Cells[2].Value.ToString();
            /////////////////////////////////////////////////////////
            conn.Open();
            string sql = "select * from roomcatalog";
            cmd = new MySqlCommand(sql, conn);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (tb_showdata.Rows[e.RowIndex].Cells[3].Value.ToString() == dr.GetString("idroomtype"))
                {
                    cobobox_catalog.Text = dr.GetString("roomtype");
                }
            }

            conn.Close();
            /////////////////////////////////////////////////////////////////////
            txt_price.Text = tb_showdata.Rows[e.RowIndex].Cells[4].Value.ToString();

            //////////////////////////////////.
            ///
            conn.Open();
      
            cmd = new MySqlCommand("Select pic from rooms where idroom ='" + id + "'", conn);
            MySqlDataReader dr1 = cmd.ExecuteReader();
            while (dr1.Read())
            {
                byte[] Img = (byte[])(dr1["pic"]);
                MemoryStream mstream = new MemoryStream(Img);
                pic_room.Image = System.Drawing.Image.FromStream(mstream);
            }
            conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }


        }
        public void KUBKHUEKAO()
        {

            txt_id.Text = null;
            txt_name.Text = null;
            txt_resident.Text = null;
            cobobox_catalog.Text = null;
            txt_price.Text = null;
            pic_room.Text = null;
            pic_room.Image = null;
        }
    

    }
}
