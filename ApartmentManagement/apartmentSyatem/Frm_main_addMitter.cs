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
    public partial class Frm_main_addMitter : Form
    {
        MySqlConnection conn = new MySqlConnection("server=localhost;user=root;password=;database=apartmentsystem");
        MySqlDataAdapter adt = new MySqlDataAdapter();
        MySqlCommand cmd = new MySqlCommand();
        public Frm_main_addMitter()
        {
            InitializeComponent();
        }

        private void Frm_main_addMitter_Load(object sender, EventArgs e)
        {
            showdata();
        }
        DataSet ds = new DataSet();
        DataTable tb = new DataTable();
        public void showdata()
        {
            try
            {
                conn.Open();
               adt = new MySqlDataAdapter("SELECT  idroom, rname, waterBill, elecBill FROM  rooms", conn);
                adt.Fill(tb);
                tb_show_room.DataSource = tb;
                //header text
                tb_show_room.Columns[0].HeaderText = "ລະຫັດ";
                tb_show_room.Columns[1].HeaderText = "ຊື່ຫ້ອງ";
                tb_show_room.Columns[2].HeaderText = "ເລກໝໍ້ນັບນ້ຳ";
                tb_show_room.Columns[3].HeaderText = "ເລກໝໍ້ນັບໄຟຟ້າ";

                conn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void tb_show_room_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow selectRow = tb_show_room.Rows[index];
                txt_id.Text = selectRow.Cells[0].Value.ToString();
                txt_name.Text = selectRow.Cells[1].Value.ToString();
                txt_elec.Text = selectRow.Cells[2].Value.ToString();
                txt_water.Text = selectRow.Cells[3].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
           
            }
            

        }
        public void update()
        {
            try
            {
                cmd = new MySqlCommand("update ");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
