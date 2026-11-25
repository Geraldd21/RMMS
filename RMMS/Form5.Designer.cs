namespace RMMS
{
    partial class AdminDashFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashFrm));
            NavPanel = new Panel();
            Tech_Butt = new Button();
            Logout_Butt = new Button();
            Order_Butt = new Button();
            Serv_Butt = new Button();
            Dash_Butt = new Button();
            Maint_Butt = new Button();
            Verf_Pnl = new Panel();
            pictureBox5 = new PictureBox();
            No_Verf = new Label();
            label4 = new Label();
            InProg_Pnl = new Panel();
            pictureBox4 = new PictureBox();
            No_InProg = new Label();
            progg_lbl = new Label();
            Pend_Pnl = new Panel();
            pictureBox3 = new PictureBox();
            No_Pend = new Label();
            pending_lbl = new Label();
            Tot_Pnl = new Panel();
            pictureBox2 = new PictureBox();
            No_Total = new Label();
            total_lbl = new Label();
            NamePanel = new Panel();
            Userlbl = new Label();
            Greetlbl = new Label();
            Acc_Icon = new PictureBox();
            DGVpanel = new Panel();
            label1 = new Label();
            DGV_Req = new DataGridView();
            NavPanel.SuspendLayout();
            Verf_Pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            InProg_Pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            Pend_Pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            Tot_Pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            NamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Acc_Icon).BeginInit();
            DGVpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_Req).BeginInit();
            SuspendLayout();
            // 
            // NavPanel
            // 
            NavPanel.BackColor = Color.MidnightBlue;
            NavPanel.Controls.Add(Tech_Butt);
            NavPanel.Controls.Add(Logout_Butt);
            NavPanel.Controls.Add(Order_Butt);
            NavPanel.Controls.Add(Serv_Butt);
            NavPanel.Controls.Add(Dash_Butt);
            NavPanel.Controls.Add(Maint_Butt);
            NavPanel.Location = new Point(-21, 40);
            NavPanel.Name = "NavPanel";
            NavPanel.Size = new Size(346, 667);
            NavPanel.TabIndex = 3;
            // 
            // Tech_Butt
            // 
            Tech_Butt.BackgroundImage = Properties.Resources.Technician;
            Tech_Butt.BackgroundImageLayout = ImageLayout.Zoom;
            Tech_Butt.Cursor = Cursors.Hand;
            Tech_Butt.FlatAppearance.BorderSize = 0;
            Tech_Butt.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            Tech_Butt.FlatStyle = FlatStyle.Flat;
            Tech_Butt.ForeColor = Color.Coral;
            Tech_Butt.Location = new Point(45, 344);
            Tech_Butt.Name = "Tech_Butt";
            Tech_Butt.Size = new Size(277, 59);
            Tech_Butt.TabIndex = 5;
            Tech_Butt.UseVisualStyleBackColor = true;
            Tech_Butt.Click += Tech_Butt_Click;
            // 
            // Logout_Butt
            // 
            Logout_Butt.Cursor = Cursors.Hand;
            Logout_Butt.FlatAppearance.BorderSize = 0;
            Logout_Butt.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            Logout_Butt.FlatStyle = FlatStyle.Flat;
            Logout_Butt.ForeColor = Color.SkyBlue;
            Logout_Butt.Image = Properties.Resources.log_out1;
            Logout_Butt.Location = new Point(45, 419);
            Logout_Butt.Name = "Logout_Butt";
            Logout_Butt.Size = new Size(277, 59);
            Logout_Butt.TabIndex = 4;
            Logout_Butt.UseVisualStyleBackColor = true;
            Logout_Butt.Click += Logout_Butt_Click;
            // 
            // Order_Butt
            // 
            Order_Butt.BackColor = Color.Transparent;
            Order_Butt.Cursor = Cursors.Hand;
            Order_Butt.FlatAppearance.BorderSize = 0;
            Order_Butt.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            Order_Butt.FlatStyle = FlatStyle.Flat;
            Order_Butt.ForeColor = Color.SkyBlue;
            Order_Butt.Image = Properties.Resources.Job_order;
            Order_Butt.Location = new Point(45, 186);
            Order_Butt.Name = "Order_Butt";
            Order_Butt.Size = new Size(277, 59);
            Order_Butt.TabIndex = 3;
            Order_Butt.UseVisualStyleBackColor = false;
            Order_Butt.Click += Req_Butt_Click;
            // 
            // Serv_Butt
            // 
            Serv_Butt.BackColor = Color.Transparent;
            Serv_Butt.Cursor = Cursors.Hand;
            Serv_Butt.FlatAppearance.BorderSize = 0;
            Serv_Butt.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            Serv_Butt.FlatStyle = FlatStyle.Flat;
            Serv_Butt.ForeColor = Color.SkyBlue;
            Serv_Butt.Image = Properties.Resources.Service_Req;
            Serv_Butt.Location = new Point(45, 102);
            Serv_Butt.Name = "Serv_Butt";
            Serv_Butt.Size = new Size(277, 59);
            Serv_Butt.TabIndex = 2;
            Serv_Butt.UseVisualStyleBackColor = false;
            Serv_Butt.Click += Serv_Butt_Click;
            // 
            // Dash_Butt
            // 
            Dash_Butt.BackColor = Color.Transparent;
            Dash_Butt.BackgroundImageLayout = ImageLayout.Zoom;
            Dash_Butt.Cursor = Cursors.Hand;
            Dash_Butt.FlatAppearance.BorderSize = 0;
            Dash_Butt.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            Dash_Butt.FlatStyle = FlatStyle.Flat;
            Dash_Butt.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Dash_Butt.ForeColor = Color.SkyBlue;
            Dash_Butt.Image = (Image)resources.GetObject("Dash_Butt.Image");
            Dash_Butt.Location = new Point(45, 24);
            Dash_Butt.Name = "Dash_Butt";
            Dash_Butt.Size = new Size(277, 59);
            Dash_Butt.TabIndex = 1;
            Dash_Butt.UseVisualStyleBackColor = false;
            Dash_Butt.Click += Dash_Butt_Click;
            // 
            // Maint_Butt
            // 
            Maint_Butt.BackgroundImage = Properties.Resources.Mainten_Cost;
            Maint_Butt.BackgroundImageLayout = ImageLayout.Zoom;
            Maint_Butt.Cursor = Cursors.Hand;
            Maint_Butt.FlatAppearance.BorderSize = 0;
            Maint_Butt.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            Maint_Butt.FlatStyle = FlatStyle.Flat;
            Maint_Butt.Location = new Point(45, 267);
            Maint_Butt.Name = "Maint_Butt";
            Maint_Butt.Size = new Size(277, 59);
            Maint_Butt.TabIndex = 6;
            Maint_Butt.UseVisualStyleBackColor = true;
            Maint_Butt.Click += Maint_Butt_Click;
            // 
            // Verf_Pnl
            // 
            Verf_Pnl.BackColor = Color.Honeydew;
            Verf_Pnl.Controls.Add(pictureBox5);
            Verf_Pnl.Controls.Add(No_Verf);
            Verf_Pnl.Controls.Add(label4);
            Verf_Pnl.Location = new Point(1003, 176);
            Verf_Pnl.Name = "Verf_Pnl";
            Verf_Pnl.Size = new Size(155, 203);
            Verf_Pnl.TabIndex = 13;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.BackgroundImage = Properties.Resources.check;
            pictureBox5.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox5.Location = new Point(26, 30);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(50, 50);
            pictureBox5.TabIndex = 2;
            pictureBox5.TabStop = false;
            // 
            // No_Verf
            // 
            No_Verf.AutoSize = true;
            No_Verf.BackColor = Color.Transparent;
            No_Verf.FlatStyle = FlatStyle.Flat;
            No_Verf.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            No_Verf.ForeColor = Color.Black;
            No_Verf.Location = new Point(26, 118);
            No_Verf.Name = "No_Verf";
            No_Verf.Size = new Size(49, 57);
            No_Verf.TabIndex = 1;
            No_Verf.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(26, 98);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 0;
            label4.Text = "Verified ";
            // 
            // InProg_Pnl
            // 
            InProg_Pnl.BackColor = Color.Lavender;
            InProg_Pnl.Controls.Add(pictureBox4);
            InProg_Pnl.Controls.Add(No_InProg);
            InProg_Pnl.Controls.Add(progg_lbl);
            InProg_Pnl.Location = new Point(801, 176);
            InProg_Pnl.Name = "InProg_Pnl";
            InProg_Pnl.Size = new Size(155, 203);
            InProg_Pnl.TabIndex = 12;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.BackgroundImage = Properties.Resources.arrows;
            pictureBox4.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox4.Location = new Point(25, 30);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(50, 50);
            pictureBox4.TabIndex = 2;
            pictureBox4.TabStop = false;
            // 
            // No_InProg
            // 
            No_InProg.AutoSize = true;
            No_InProg.BackColor = Color.Transparent;
            No_InProg.FlatStyle = FlatStyle.Flat;
            No_InProg.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            No_InProg.ForeColor = Color.Black;
            No_InProg.Location = new Point(25, 120);
            No_InProg.Name = "No_InProg";
            No_InProg.Size = new Size(49, 57);
            No_InProg.TabIndex = 1;
            No_InProg.Text = "0";
            // 
            // progg_lbl
            // 
            progg_lbl.AutoSize = true;
            progg_lbl.BackColor = Color.Transparent;
            progg_lbl.FlatStyle = FlatStyle.Flat;
            progg_lbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            progg_lbl.ForeColor = Color.Black;
            progg_lbl.Location = new Point(25, 98);
            progg_lbl.Name = "progg_lbl";
            progg_lbl.Size = new Size(88, 20);
            progg_lbl.TabIndex = 0;
            progg_lbl.Text = "In Progress";
            // 
            // Pend_Pnl
            // 
            Pend_Pnl.BackColor = Color.Linen;
            Pend_Pnl.Controls.Add(pictureBox3);
            Pend_Pnl.Controls.Add(No_Pend);
            Pend_Pnl.Controls.Add(pending_lbl);
            Pend_Pnl.Location = new Point(596, 176);
            Pend_Pnl.Name = "Pend_Pnl";
            Pend_Pnl.Size = new Size(155, 203);
            Pend_Pnl.TabIndex = 11;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BackgroundImage = Properties.Resources.tools;
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Location = new Point(23, 30);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(50, 50);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // No_Pend
            // 
            No_Pend.AutoSize = true;
            No_Pend.BackColor = Color.Transparent;
            No_Pend.FlatStyle = FlatStyle.Flat;
            No_Pend.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            No_Pend.ForeColor = Color.Black;
            No_Pend.Location = new Point(23, 118);
            No_Pend.Name = "No_Pend";
            No_Pend.Size = new Size(49, 57);
            No_Pend.TabIndex = 1;
            No_Pend.Text = "0";
            // 
            // pending_lbl
            // 
            pending_lbl.AutoSize = true;
            pending_lbl.BackColor = Color.Transparent;
            pending_lbl.FlatStyle = FlatStyle.Flat;
            pending_lbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            pending_lbl.ForeColor = Color.Black;
            pending_lbl.Location = new Point(23, 98);
            pending_lbl.Name = "pending_lbl";
            pending_lbl.Size = new Size(127, 20);
            pending_lbl.TabIndex = 0;
            pending_lbl.Text = "Pending Request";
            // 
            // Tot_Pnl
            // 
            Tot_Pnl.BackColor = Color.MintCream;
            Tot_Pnl.Controls.Add(pictureBox2);
            Tot_Pnl.Controls.Add(No_Total);
            Tot_Pnl.Controls.Add(total_lbl);
            Tot_Pnl.Location = new Point(396, 176);
            Tot_Pnl.Name = "Tot_Pnl";
            Tot_Pnl.Size = new Size(155, 203);
            Tot_Pnl.TabIndex = 10;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = Properties.Resources.requirement;
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(23, 30);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(50, 50);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // No_Total
            // 
            No_Total.AutoSize = true;
            No_Total.BackColor = Color.Transparent;
            No_Total.FlatStyle = FlatStyle.Flat;
            No_Total.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            No_Total.ForeColor = Color.CornflowerBlue;
            No_Total.Location = new Point(23, 118);
            No_Total.Name = "No_Total";
            No_Total.Size = new Size(49, 57);
            No_Total.TabIndex = 1;
            No_Total.Text = "0";
            No_Total.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // total_lbl
            // 
            total_lbl.AutoSize = true;
            total_lbl.BackColor = Color.Transparent;
            total_lbl.FlatStyle = FlatStyle.Flat;
            total_lbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            total_lbl.ForeColor = Color.CornflowerBlue;
            total_lbl.Location = new Point(23, 98);
            total_lbl.Name = "total_lbl";
            total_lbl.Size = new Size(105, 20);
            total_lbl.TabIndex = 0;
            total_lbl.Text = "Total Request";
            // 
            // NamePanel
            // 
            NamePanel.BackColor = Color.SkyBlue;
            NamePanel.BackgroundImageLayout = ImageLayout.None;
            NamePanel.Controls.Add(Userlbl);
            NamePanel.Controls.Add(Greetlbl);
            NamePanel.Controls.Add(Acc_Icon);
            NamePanel.Location = new Point(349, 40);
            NamePanel.Name = "NamePanel";
            NamePanel.Size = new Size(854, 118);
            NamePanel.TabIndex = 14;
            // 
            // Userlbl
            // 
            Userlbl.AutoSize = true;
            Userlbl.BackColor = Color.Transparent;
            Userlbl.FlatStyle = FlatStyle.Flat;
            Userlbl.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Userlbl.ForeColor = Color.DarkBlue;
            Userlbl.Location = new Point(125, 62);
            Userlbl.Name = "Userlbl";
            Userlbl.Size = new Size(98, 31);
            Userlbl.TabIndex = 1;
            Userlbl.Text = "(Admin)";
            // 
            // Greetlbl
            // 
            Greetlbl.AutoSize = true;
            Greetlbl.BackColor = Color.Transparent;
            Greetlbl.FlatStyle = FlatStyle.Flat;
            Greetlbl.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            Greetlbl.ForeColor = Color.DarkBlue;
            Greetlbl.Location = new Point(125, 30);
            Greetlbl.Name = "Greetlbl";
            Greetlbl.Size = new Size(327, 32);
            Greetlbl.TabIndex = 1;
            Greetlbl.Text = "Welcome, Gerald Patalagan";
            // 
            // Acc_Icon
            // 
            Acc_Icon.BackColor = Color.Transparent;
            Acc_Icon.BackgroundImage = (Image)resources.GetObject("Acc_Icon.BackgroundImage");
            Acc_Icon.BackgroundImageLayout = ImageLayout.Zoom;
            Acc_Icon.Location = new Point(17, 19);
            Acc_Icon.Name = "Acc_Icon";
            Acc_Icon.Size = new Size(72, 85);
            Acc_Icon.TabIndex = 0;
            Acc_Icon.TabStop = false;
            // 
            // DGVpanel
            // 
            DGVpanel.BackColor = Color.MintCream;
            DGVpanel.Controls.Add(label1);
            DGVpanel.Controls.Add(DGV_Req);
            DGVpanel.Location = new Point(349, 403);
            DGVpanel.Name = "DGVpanel";
            DGVpanel.Size = new Size(854, 320);
            DGVpanel.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(17, 8);
            label1.Name = "label1";
            label1.Size = new Size(172, 30);
            label1.TabIndex = 1;
            label1.Text = "Recent Request";
            label1.Click += label1_Click;
            // 
            // DGV_Req
            // 
            DGV_Req.BackgroundColor = Color.LightBlue;
            DGV_Req.BorderStyle = BorderStyle.None;
            DGV_Req.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_Req.Location = new Point(17, 41);
            DGV_Req.Name = "DGV_Req";
            DGV_Req.RowHeadersWidth = 51;
            DGV_Req.Size = new Size(819, 246);
            DGV_Req.TabIndex = 0;
            // 
            // AdminDashFrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.dashboard_bg;
            ClientSize = new Size(1232, 701);
            Controls.Add(DGVpanel);
            Controls.Add(NamePanel);
            Controls.Add(Verf_Pnl);
            Controls.Add(InProg_Pnl);
            Controls.Add(Pend_Pnl);
            Controls.Add(Tot_Pnl);
            Controls.Add(NavPanel);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AdminDashFrm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Dashboard";
            Load += AdminDashFrm_Load;
            NavPanel.ResumeLayout(false);
            Verf_Pnl.ResumeLayout(false);
            Verf_Pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            InProg_Pnl.ResumeLayout(false);
            InProg_Pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            Pend_Pnl.ResumeLayout(false);
            Pend_Pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            Tot_Pnl.ResumeLayout(false);
            Tot_Pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            NamePanel.ResumeLayout(false);
            NamePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Acc_Icon).EndInit();
            DGVpanel.ResumeLayout(false);
            DGVpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_Req).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel NavPanel;
        private Button Logout_Butt;
        private Button Order_Butt;
        private Button Serv_Butt;
        private Button Dash_Butt;
        private Button Tech_Butt;
        private Button Maint_Butt;
        private Panel Verf_Pnl;
        private PictureBox pictureBox5;
        private Label No_Verf;
        private Label label4;
        private Panel InProg_Pnl;
        private PictureBox pictureBox4;
        private Label No_InProg;
        private Label progg_lbl;
        private Panel Pend_Pnl;
        private PictureBox pictureBox3;
        private Label No_Pend;
        private Label pending_lbl;
        private Panel Tot_Pnl;
        private PictureBox pictureBox2;
        private Label No_Total;
        private Label total_lbl;
        private Panel NamePanel;
        private Label Userlbl;
        private Label Greetlbl;
        private PictureBox Acc_Icon;
        private Panel DGVpanel;
        private DataGridView DGV_Req;
        private Label label1;
    }
}