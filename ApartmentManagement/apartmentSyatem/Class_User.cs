using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace apartmentSyatem
{
    class Class_User
    {
        public static MySqlConnection GetCon()
        {
            string sql = "server=localhost;user=root;password=;database=apartmentsystem";
            MySqlConnection con = new MySqlConnection(sql);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            return con;

        }
        public static void insert()
        {
            
        }
    }
}
