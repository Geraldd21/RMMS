namespace RMMS
{
    partial class ServReq_Frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServReq_Frm));
            NavPanel = new Panel();
            Tech_Butt = new Button();
            Logout_Butt = new Button();
            Req_Butt = new Button();
            Serv_Butt = new Button();
            Dash_Butt = new Button();
            Maint_Butt = new Button();
            DGVpanel = new Panel();
            label1 = new Label();
            DGV_Repairlist = new DataGridView();
            VerfNote_Panel = new Panel();
            Rewrk_butt = new Button();
            Verify_Butt = new Button();
            label2 = new Label();
            textBox1 = new TextBox();
            NavPanel.SuspendLayout();
            DGVpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_Repairlist).BeginInit();
            VerfNote_Panel.SuspendLayout();
            SuspendLayout();
            // 
            // NavPanel
            // 
            NavPanel.BackColor = Color.MidnightBlue;
            NavPanel.Controls.Add(Tech_Butt);
            NavPanel.Controls.Add(Logout_Butt);
            NavPanel.Controls.Add(Req_Butt);
            NavPanel.Controls.Add(Serv_Butt);
            NavPanel.Controls.Add(Dash_Butt);
            NavPanel.Controls.Add(Maint_Butt);
            NavPanel.Location = new Point(-21, 40);
            NavPanel.Name = "NavPanel";
            NavPanel.Size = new Size(346, 667);
            NavPanel.TabIndex = 4;
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
            // Req_Butt
            // 
            Req_Butt.BackColor = Color.Transparent;
            Req_Butt.Cursor = Cursors.Hand;
            Req_Butt.FlatAppearance.BorderSize = 0;
            Req_Butt.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            Req_Butt.FlatStyle = FlatStyle.Flat;
            Req_Butt.ForeColor = Color.SkyBlue;
            Req_Butt.Image = Properties.Resources.Job_order;
            Req_Butt.Location = new Point(45, 186);
            Req_Butt.Name = "Req_Butt";
            Req_Butt.Size = new Size(277, 59);
            Req_Butt.TabIndex = 3;
            Req_Butt.UseVisualStyleBackColor = false;
            Req_Butt.Click += Req_Butt_Click;
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
            // DGVpanel
            // 
            DGVpanel.BackColor = Color.MintCream;
            DGVpanel.Controls.Add(label1);
            DGVpanel.Controls.Add(DGV_Repairlist);
            DGVpanel.Location = new Point(351, 40);
            DGVpanel.Name = "DGVpanel";
            DGVpanel.Size = new Size(854, 445);
            DGVpanel.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(17, 8);
            label1.Name = "label1";
            label1.Size = new Size(455, 30);
            label1.TabIndex = 1;
            label1.Text = "Completed Repairs ( Awaiting Verification)";
            // 
            // DGV_Repairlist
            // 
            DGV_Repairlist.BackgroundColor = Color.LightBlue;
            DGV_Repairlist.BorderStyle = BorderStyle.None;
            DGV_Repairlist.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_Repairlist.Location = new Point(17, 41);
            DGV_Repairlist.Name = "DGV_Repairlist";
            DGV_Repairlist.RowHeadersWidth = 51;
            DGV_Repairlist.Size = new Size(819, 385);
            DGV_Repairlist.TabIndex = 0;
            // 
            // VerfNote_Panel
            // 
            VerfNote_Panel.BackColor = Color.MintCream;
            VerfNote_Panel.Controls.Add(Rewrk_butt);
            VerfNote_Panel.Controls.Add(Verify_Butt);
            VerfNote_Panel.Controls.Add(label2);
            VerfNote_Panel.Controls.Add(textBox1);
            VerfNote_Panel.Location = new Point(351, 491);
            VerfNote_Panel.Name = "VerfNote_Panel";
            VerfNote_Panel.Size = new Size(854, 227);
            VerfNote_Panel.TabIndex = 17;
            // 
            // Rewrk_butt
            // 
            Rewrk_butt.BackColor = Color.Tomato;
            Rewrk_butt.Cursor = Cursors.Hand;
            Rewrk_butt.FlatAppearance.BorderSize = 0;
            Rewrk_butt.FlatStyle = FlatStyle.Flat;
            Rewrk_butt.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            Rewrk_butt.ForeColor = Color.White;
            Rewrk_butt.Location = new Point(495, 131);
            Rewrk_butt.Name = "Rewrk_butt";
            Rewrk_butt.Size = new Size(220, 43);
            Rewrk_butt.TabIndex = 4;
            Rewrk_butt.Text = "↻ Return for Rework";
            Rewrk_butt.UseVisualStyleBackColor = false;
            // 
            // Verify_Butt
            // 
            Verify_Butt.BackColor = Color.MediumSeaGreen;
            Verify_Butt.Cursor = Cursors.Hand;
            Verify_Butt.FlatAppearance.BorderSize = 0;
            Verify_Butt.FlatStyle = FlatStyle.Flat;
            Verify_Butt.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            Verify_Butt.ForeColor = Color.White;
            Verify_Butt.Location = new Point(495, 56);
            Verify_Butt.Name = "Verify_Butt";
            Verify_Butt.Size = new Size(220, 43);
            Verify_Butt.TabIndex = 3;
            Verify_Butt.Text = "☑ Verify Repair";
            Verify_Butt.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(17, 12);
            label2.Name = "label2";
            label2.Size = new Size(176, 25);
            label2.TabIndex = 2;
            label2.Text = "Verification Notes:";
            // 
            // textBox1
            // 
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Location = new Point(17, 40);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(342, 158);
            textBox1.TabIndex = 0;
            // 
            // ServReq_Frm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.SubmitFrm;
            ClientSize = new Size(1232, 701);
            Controls.Add(VerfNote_Panel);
            Controls.Add(DGVpanel);
            Controls.Add(NavPanel);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ServReq_Frm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Service Request";
            Load += ServReq_Frm_Load;
            NavPanel.ResumeLayout(false);
            DGVpanel.ResumeLayout(false);
            DGVpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_Repairlist).EndInit();
            VerfNote_Panel.ResumeLayout(false);
            VerfNote_Panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel NavPanel;
        private Button Maint_Butt;
        private Button Tech_Butt;
        private Button Logout_Butt;
        private Button Req_Butt;
        private Button Serv_Butt;
        private Button Dash_Butt;
        private Panel DGVpanel;
        private Label label1;
        private DataGridView DGV_Repairlist;
        private Panel VerfNote_Panel;
        private Label label2;
        private TextBox textBox1;
        private Button Rewrk_butt;
        private Button Verify_Butt;
    }
}