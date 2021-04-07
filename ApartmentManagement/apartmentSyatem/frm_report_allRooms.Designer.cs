namespace apartmentSyatem
{
    partial class frm_report_allRooms
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
            this.view_allroom = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // view_allroom
            // 
            this.view_allroom.ActiveViewIndex = -1;
            this.view_allroom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.view_allroom.Cursor = System.Windows.Forms.Cursors.Default;
            this.view_allroom.DisplayStatusBar = false;
            this.view_allroom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.view_allroom.Location = new System.Drawing.Point(0, 0);
            this.view_allroom.Name = "view_allroom";
            this.view_allroom.Size = new System.Drawing.Size(994, 615);
            this.view_allroom.TabIndex = 0;
            this.view_allroom.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frm_report_allRooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 615);
            this.Controls.Add(this.view_allroom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_report_allRooms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_report_allRooms";
            this.Load += new System.EventHandler(this.frm_report_allRooms_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer view_allroom;
    }
}