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
    public partial class Frm_main_addCatalog : Form
    {
        MySqlConnection conn = new MySqlConnection("server=localhost;user=root;password=;database=apartmentsystem");
        MySqlDataAdapter adt = new MySqlDataAdapter();
        MySqlCommand cmd = new MySqlCommand();
        public Frm_main_addCatalog()
        {
            InitializeComponent();
        }

        private void Frm_main_addCatalog_Load(object sender, EventArgs e)
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
               
                adt = new MySqlDataAdapter("SELECT *from roomcatalog", conn);
                adt.Fill(tb);
                tb_show_catalog.DataSource = tb;

                tb_show_catalog.Columns[0].HeaderText = "ລະຫັດ";
                tb_show_catalog.Columns[1].HeaderText = "ປະເພດ";
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        public void insert()
        {
            try
            {
                conn.Open();
                //string sql = "insert into roomcatalog values(idroomtype=@id,roomtype=@name)";
                cmd = new MySqlCommand("insert into roomcatalog values (@idroomtype,@roomtype)",conn);
                cmd.Parameters.AddWithValue("@roomtype", txt_name.Text);
                cmd.Parameters.AddWithValue("@idroomtype", "");
                cmd.ExecuteNonQuery();

                conn.Close();
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
                conn.Open();
                cmd = new MySqlCommand("update roomcatalog set roomtype = @name where idroomtype =@id ",conn);
                cmd.Parameters.AddWithValue("@id", txt_id.Text);
                cmd.Parameters.AddWithValue("@name", txt_name.Text);
                if (cmd.ExecuteNonQuery()==1)
                {
                    MessageBox.Show("updated");
                }
                conn.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void delete()
        {
            conn.Open();
            cmd = new MySqlCommand("delete from roomcatalog where idroomtype = @id",conn);
            cmd.Parameters.AddWithValue("@id",txt_id.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            insert();
           
            showdata();
        }

        private void tb_show_catalog_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow selectRow = tb_show_catalog.Rows[index];
                txt_id.Text = selectRow.Cells[0].Value.ToString();
                txt_name.Text = selectRow.Cells[1].Value.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public void clear()
        {
            try
            {
                txt_id.Text = "";
                txt_name.Text = "";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            update();
            showdata();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            delete();
            showdata();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            clear();

            showdata();
        }
    }
}
