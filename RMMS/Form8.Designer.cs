namespace RMMS
{
    partial class Maint_Frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Maint_Frm));
            NavPanel = new Panel();
            Tech_Butt = new Button();
            Logout_Butt = new Button();
            Req_Butt = new Button();
            Serv_Butt = new Button();
            Dash_Butt = new Button();
            Maint_Butt = new Button();
            DGVpanel = new Panel();
            Load_Butt = new Button();
            label2 = new Label();
            from_lbl = new Label();
            To_DTP = new DateTimePicker();
            From_DTP = new DateTimePicker();
            DGV_Repairlist = new DataGridView();
            Print_Btn = new Button();
            pictureBox1 = new PictureBox();
            Cost_pnl = new Panel();
            TotalCost_lbl = new Label();
            Total_lbl = new Label();
            NavPanel.SuspendLayout();
            DGVpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_Repairlist).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            Cost_pnl.SuspendLayout();
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
            NavPanel.TabIndex = 5;
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
            // 
            // DGVpanel
            // 
            DGVpanel.BackColor = Color.MintCream;
            DGVpanel.Controls.Add(Load_Butt);
            DGVpanel.Controls.Add(label2);
            DGVpanel.Controls.Add(from_lbl);
            DGVpanel.Controls.Add(To_DTP);
            DGVpanel.Controls.Add(From_DTP);
            DGVpanel.Controls.Add(DGV_Repairlist);
            DGVpanel.Location = new Point(342, 40);
            DGVpanel.Name = "DGVpanel";
            DGVpanel.Size = new Size(617, 445);
            DGVpanel.TabIndex = 17;
            // 
            // Load_Butt
            // 
            Load_Butt.BackColor = Color.RoyalBlue;
            Load_Butt.FlatAppearance.BorderSize = 0;
            Load_Butt.FlatStyle = FlatStyle.Flat;
            Load_Butt.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Load_Butt.ForeColor = Color.White;
            Load_Butt.Location = new Point(455, 17);
            Load_Butt.Name = "Load_Butt";
            Load_Butt.Size = new Size(143, 32);
            Load_Butt.TabIndex = 4;
            Load_Butt.Text = "Load Report";
            Load_Butt.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(240, 24);
            label2.Name = "label2";
            label2.Size = new Size(29, 20);
            label2.TabIndex = 3;
            label2.Text = "To:";
            // 
            // from_lbl
            // 
            from_lbl.AutoSize = true;
            from_lbl.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            from_lbl.Location = new Point(17, 24);
            from_lbl.Name = "from_lbl";
            from_lbl.Size = new Size(49, 20);
            from_lbl.TabIndex = 2;
            from_lbl.Text = "From:";
            // 
            // To_DTP
            // 
            To_DTP.Cursor = Cursors.Hand;
            To_DTP.Format = DateTimePickerFormat.Short;
            To_DTP.Location = new Point(293, 19);
            To_DTP.Name = "To_DTP";
            To_DTP.RightToLeft = RightToLeft.No;
            To_DTP.Size = new Size(119, 27);
            To_DTP.TabIndex = 1;
            // 
            // From_DTP
            // 
            From_DTP.Format = DateTimePickerFormat.Short;
            From_DTP.Location = new Point(94, 19);
            From_DTP.Name = "From_DTP";
            From_DTP.RightToLeft = RightToLeft.No;
            From_DTP.Size = new Size(119, 27);
            From_DTP.TabIndex = 1;
            // 
            // DGV_Repairlist
            // 
            DGV_Repairlist.BackgroundColor = Color.LightBlue;
            DGV_Repairlist.BorderStyle = BorderStyle.None;
            DGV_Repairlist.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_Repairlist.Location = new Point(17, 63);
            DGV_Repairlist.Name = "DGV_Repairlist";
            DGV_Repairlist.RowHeadersWidth = 51;
            DGV_Repairlist.Size = new Size(582, 363);
            DGV_Repairlist.TabIndex = 0;
            // 
            // Print_Btn
            // 
            Print_Btn.BackColor = Color.Azure;
            Print_Btn.FlatAppearance.BorderSize = 0;
            Print_Btn.FlatStyle = FlatStyle.Flat;
            Print_Btn.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            Print_Btn.ForeColor = Color.RoyalBlue;
            Print_Btn.Location = new Point(1011, 412);
            Print_Btn.Name = "Print_Btn";
            Print_Btn.Size = new Size(183, 73);
            Print_Btn.TabIndex = 18;
            Print_Btn.Text = "🖨️ Print";
            Print_Btn.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.salary;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(1033, 59);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(127, 118);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // Cost_pnl
            // 
            Cost_pnl.BackColor = Color.BlanchedAlmond;
            Cost_pnl.Controls.Add(TotalCost_lbl);
            Cost_pnl.Controls.Add(Total_lbl);
            Cost_pnl.Location = new Point(342, 491);
            Cost_pnl.Name = "Cost_pnl";
            Cost_pnl.Size = new Size(617, 92);
            Cost_pnl.TabIndex = 20;
            // 
            // TotalCost_lbl
            // 
            TotalCost_lbl.AutoSize = true;
            TotalCost_lbl.FlatStyle = FlatStyle.Flat;
            TotalCost_lbl.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TotalCost_lbl.Location = new Point(469, 35);
            TotalCost_lbl.Name = "TotalCost_lbl";
            TotalCost_lbl.Size = new Size(120, 31);
            TotalCost_lbl.TabIndex = 0;
            TotalCost_lbl.Text = "₱ 1,200.00";
            TotalCost_lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Total_lbl
            // 
            Total_lbl.AutoSize = true;
            Total_lbl.FlatStyle = FlatStyle.Flat;
            Total_lbl.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            Total_lbl.Location = new Point(240, 31);
            Total_lbl.Name = "Total_lbl";
            Total_lbl.Size = new Size(139, 35);
            Total_lbl.TabIndex = 21;
            Total_lbl.Text = "Total Cost:";
            // 
            // Maint_Frm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.SubmitFrm;
            ClientSize = new Size(1232, 701);
            Controls.Add(Cost_pnl);
            Controls.Add(pictureBox1);
            Controls.Add(Print_Btn);
            Controls.Add(DGVpanel);
            Controls.Add(NavPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Maint_Frm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form8";
            Load += Maint_Frm_Load;
            NavPanel.ResumeLayout(false);
            DGVpanel.ResumeLayout(false);
            DGVpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_Repairlist).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            Cost_pnl.ResumeLayout(false);
            Cost_pnl.PerformLayout();
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
        private DateTimePicker To_DTP;
        private DateTimePicker From_DTP;
        private DataGridView DGV_Repairlist;
        private Button Load_Butt;
        private Label label2;
        private Label from_lbl;
        private Button Print_Btn;
        private PictureBox pictureBox1;
        private Panel Cost_pnl;
        private Label TotalCost_lbl;
        private Label Total_lbl;
    }
}