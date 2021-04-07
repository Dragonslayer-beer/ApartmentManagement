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
    public partial class Frm_main : Form
    {
        public Frm_main()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            panel_mainAdd.Controls.Clear();
            Frm_main_addNewRoom room = new Frm_main_addNewRoom();
          room.TopLevel = false;
            panel_mainAdd.Controls.Add(room);
            room.Show();

            btn_addroom.FillColor = Color.RoyalBlue;
            btn_addroom.BorderColor = Color.White;
            btn_catalog.FillColor = Color.Transparent;
            btn_mitter.FillColor = Color.Transparent;
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_catalog_Click(object sender, EventArgs e)
        {
            panel_mainAdd.Controls.Clear();
            Frm_main_addCatalog cat = new Frm_main_addCatalog();
            cat.TopLevel = false;
            panel_mainAdd.Controls.Add(cat);
            cat.Show();

            btn_addroom.FillColor = Color.Transparent;
            btn_catalog.FillColor = Color.RoyalBlue;
            btn_mitter.FillColor = Color.Transparent;
        }

        private void btn_mitter_Click(object sender, EventArgs e)
        {
            panel_mainAdd.Controls.Clear();
            Frm_main_addMitter mitter = new Frm_main_addMitter();
            mitter.TopLevel = false;
            panel_mainAdd.Controls.Add(mitter);
            mitter.Show();

            btn_addroom.FillColor = Color.Transparent;
            btn_catalog.FillColor = Color.Transparent;
            btn_mitter.FillColor = Color.RoyalBlue;
        }

        private void Frm_main_Load(object sender, EventArgs e)
        {
          
        }

        private void panel_mainAdd_Paint(object sender, PaintEventArgs e)
        {
          
        }
    }
}
