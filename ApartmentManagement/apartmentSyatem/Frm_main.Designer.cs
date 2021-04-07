namespace apartmentSyatem
{
    partial class Frm_main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_mitter = new Guna.UI2.WinForms.Guna2Button();
            this.btn_catalog = new Guna.UI2.WinForms.Guna2Button();
            this.btn_addroom = new Guna.UI2.WinForms.Guna2Button();
            this.panel_mainAdd = new System.Windows.Forms.Panel();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.btn_mitter);
            this.guna2Panel1.Controls.Add(this.btn_catalog);
            this.guna2Panel1.Controls.Add(this.btn_addroom);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(1061, 54);
            this.guna2Panel1.TabIndex = 1;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // btn_mitter
            // 
            this.btn_mitter.Animated = true;
            this.btn_mitter.BorderRadius = 3;
            this.btn_mitter.CheckedState.Parent = this.btn_mitter;
            this.btn_mitter.CustomImages.Parent = this.btn_mitter;
            this.btn_mitter.FillColor = System.Drawing.SystemColors.Control;
            this.btn_mitter.Font = new System.Drawing.Font("Noto Sans Lao UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_mitter.ForeColor = System.Drawing.Color.Black;
            this.btn_mitter.HoverState.Parent = this.btn_mitter;
            this.btn_mitter.Location = new System.Drawing.Point(615, 3);
            this.btn_mitter.Name = "btn_mitter";
            this.btn_mitter.ShadowDecoration.Parent = this.btn_mitter;
            this.btn_mitter.Size = new System.Drawing.Size(180, 45);
            this.btn_mitter.TabIndex = 2;
            this.btn_mitter.Text = "ເພີ່ມເລກກົງເຕີຫ້ອງໃຫມ່";
            this.btn_mitter.Click += new System.EventHandler(this.btn_mitter_Click);
            // 
            // btn_catalog
            // 
            this.btn_catalog.Animated = true;
            this.btn_catalog.BorderRadius = 3;
            this.btn_catalog.CheckedState.Parent = this.btn_catalog;
            this.btn_catalog.CustomImages.Parent = this.btn_catalog;
            this.btn_catalog.FillColor = System.Drawing.SystemColors.Control;
            this.btn_catalog.Font = new System.Drawing.Font("Noto Sans Lao UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_catalog.ForeColor = System.Drawing.Color.Black;
            this.btn_catalog.HoverState.Parent = this.btn_catalog;
            this.btn_catalog.Location = new System.Drawing.Point(416, 5);
            this.btn_catalog.Name = "btn_catalog";
            this.btn_catalog.ShadowDecoration.Parent = this.btn_catalog;
            this.btn_catalog.Size = new System.Drawing.Size(180, 45);
            this.btn_catalog.TabIndex = 1;
            this.btn_catalog.Text = "ເພີ່ມປະເພດຫ້ອງໃຫມ່";
            this.btn_catalog.Click += new System.EventHandler(this.btn_catalog_Click);
            // 
            // btn_addroom
            // 
            this.btn_addroom.Animated = true;
            this.btn_addroom.BorderRadius = 3;
            this.btn_addroom.CheckedState.Parent = this.btn_addroom;
            this.btn_addroom.CustomImages.Parent = this.btn_addroom;
            this.btn_addroom.FillColor = System.Drawing.SystemColors.Control;
            this.btn_addroom.Font = new System.Drawing.Font("Noto Sans Lao UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_addroom.ForeColor = System.Drawing.Color.Black;
            this.btn_addroom.HoverState.Parent = this.btn_addroom;
            this.btn_addroom.Location = new System.Drawing.Point(229, 5);
            this.btn_addroom.Name = "btn_addroom";
            this.btn_addroom.ShadowDecoration.Parent = this.btn_addroom;
            this.btn_addroom.Size = new System.Drawing.Size(180, 45);
            this.btn_addroom.TabIndex = 0;
            this.btn_addroom.Text = "ເພີ່ມຫ້ອງໃຫມ່";
            this.btn_addroom.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // panel_mainAdd
            // 
            this.panel_mainAdd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_mainAdd.Location = new System.Drawing.Point(0, 60);
            this.panel_mainAdd.Name = "panel_mainAdd";
            this.panel_mainAdd.Size = new System.Drawing.Size(1061, 586);
            this.panel_mainAdd.TabIndex = 2;
            this.panel_mainAdd.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_mainAdd_Paint);
            // 
            // Frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 646);
            this.Controls.Add(this.panel_mainAdd);
            this.Controls.Add(this.guna2Panel1);
            this.Font = new System.Drawing.Font("Noto Sans Lao UI SemCond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_info_general";
            this.Load += new System.EventHandler(this.Frm_main_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btn_addroom;
        private Guna.UI2.WinForms.Guna2Button btn_mitter;
        private Guna.UI2.WinForms.Guna2Button btn_catalog;
        private System.Windows.Forms.Panel panel_mainAdd;
    }
}