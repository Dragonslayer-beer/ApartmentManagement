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
    public partial class Fm_showAlluser : Form
    {
        MySqlConnection conn = new MySqlConnection("server=localhost;user=root;password=;database=apartmentsystem");
        MySqlDataAdapter adt = new MySqlDataAdapter();
        MySqlCommand cmd = new MySqlCommand();
        public Fm_showAlluser()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            F_Add_manageUser add = new F_Add_manageUser();
            add.ShowDialog();
        }

        private void Fm_showAlluser_Load(object sender, EventArgs e)
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
                //adt = new MySqlDataAdapter("SELECT * FROM user ", conn);
                adt = new MySqlDataAdapter("SELECT uid, user, lname, fname, gender, password, Status, picpath FROM user ", conn);
                adt.Fill(tb);
                tb_showdata.DataSource = tb;
                tb_showdata.Columns[0].HeaderText = "ລະຫັດ";
                tb_showdata.Columns[1].HeaderText = "User";
                tb_showdata.Columns[2].HeaderText = "ຊື່";
                tb_showdata.Columns[3].HeaderText = "ນາມສະກຸນ";
                tb_showdata.Columns[4].HeaderText = "ເພດ";
                tb_showdata.Columns[5].HeaderText = "ລະຫັດຜ່ານ";
                tb_showdata.Columns[6].HeaderText = "ສະຖານະ";
                tb_showdata.Columns[7].HeaderText = "Path";
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
    }
}
