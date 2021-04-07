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
    public partial class Frm_manage_AllRoom : Form
    {
        MySqlConnection conn = new MySqlConnection("server=localhost;user=root;password=;database=apartmentsystem");
        MySqlDataAdapter adt = new MySqlDataAdapter();
        MySqlCommand cmd = new MySqlCommand();

        public Frm_manage_AllRoom()
        {
            InitializeComponent();
        }

        private void Frm_manage_AllRoom_Load(object sender, EventArgs e)
        {
            showdata();
        }
        DataSet ds = new DataSet();
        public void showdata()
        {
            try
            {
                conn.Open();
                adt=new MySqlDataAdapter("SELECT `idroom`, `rname`, `residents`, `idroomtype`, `price`, `Status`, `waterBill`, `elecBill` FROM `rooms`", conn);
                adt.Fill(ds, "rooms");
                tb_showAllRoom.DataSource = ds.Tables["rooms"];

                tb_showAllRoom.Columns[0].HeaderText = "ລະຫັດ";
                tb_showAllRoom.Columns[1].HeaderText = "ຊື່ຫ້ອງ";
                tb_showAllRoom.Columns[2].HeaderText = "ຈຳນວນຜູ້ອາໄສ";
                tb_showAllRoom.Columns[3].HeaderText = "ປະເພດຫ້ອງ";
                tb_showAllRoom.Columns[4].HeaderText = "ລາຄາ";
                tb_showAllRoom.Columns[5].HeaderText = "ສະຖານະ";
                tb_showAllRoom.Columns[6].HeaderText = "ເລກໜໍ້ນັບນ້ຳ";
                tb_showAllRoom.Columns[7].HeaderText = "ເລກໜໍ້ນັບໄຟຟ້າ";
                conn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
