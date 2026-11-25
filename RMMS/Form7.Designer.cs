namespace RMMS
{
    partial class Order_frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Order_frm));
            NavPanel = new Panel();
            Maint_Butt = new Button();
            Tech_Butt = new Button();
            Logout_Butt = new Button();
            Req_Butt = new Button();
            Serv_Butt = new Button();
            Dash_Butt = new Button();
            CreatJob_Panel = new Panel();
            button1 = new Button();
            dateTimePicker1 = new DateTimePicker();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            Create_lbl = new Label();
            Order_Panel = new Panel();
            Order_lbl = new Label();
            dataGridView1 = new DataGridView();
            Lbl_pnl = new Panel();
            NavPanel.SuspendLayout();
            CreatJob_Panel.SuspendLayout();
            Order_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            Lbl_pnl.SuspendLayout();
            SuspendLayout();
            // 
            // NavPanel
            // 
            NavPanel.BackColor = Color.MidnightBlue;
            NavPanel.Controls.Add(Maint_Butt);
            NavPanel.Controls.Add(Tech_Butt);
            NavPanel.Controls.Add(Logout_Butt);
            NavPanel.Controls.Add(Req_Butt);
            NavPanel.Controls.Add(Serv_Butt);
            NavPanel.Controls.Add(Dash_Butt);
            NavPanel.Location = new Point(-21, 40);
            NavPanel.Name = "NavPanel";
            NavPanel.Size = new Size(346, 667);
            NavPanel.TabIndex = 5;
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
            // CreatJob_Panel
            // 
            CreatJob_Panel.BackColor = Color.MintCream;
            CreatJob_Panel.Controls.Add(button1);
            CreatJob_Panel.Controls.Add(dateTimePicker1);
            CreatJob_Panel.Controls.Add(comboBox2);
            CreatJob_Panel.Controls.Add(comboBox1);
            CreatJob_Panel.Controls.Add(label3);
            CreatJob_Panel.Controls.Add(label2);
            CreatJob_Panel.Controls.Add(label1);
            CreatJob_Panel.Location = new Point(349, 40);
            CreatJob_Panel.Name = "CreatJob_Panel";
            CreatJob_Panel.Size = new Size(859, 366);
            CreatJob_Panel.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = Color.RoyalBlue;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(595, 280);
            button1.Name = "button1";
            button1.Size = new Size(205, 46);
            button1.TabIndex = 5;
            button1.Text = "Assign Job";
            button1.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(458, 161);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(204, 27);
            dateTimePicker1.TabIndex = 4;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(458, 118);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(342, 28);
            comboBox2.TabIndex = 3;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(458, 77);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(342, 28);
            comboBox1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(18, 165);
            label3.Name = "label3";
            label3.Size = new Size(104, 23);
            label3.TabIndex = 1;
            label3.Text = "Assign Date:";
            label3.Click += Create_lbl_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(18, 119);
            label2.Name = "label2";
            label2.Size = new Size(93, 23);
            label2.TabIndex = 1;
            label2.Text = "Technician:";
            label2.Click += Create_lbl_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(18, 82);
            label1.Name = "label1";
            label1.Size = new Size(136, 23);
            label1.TabIndex = 1;
            label1.Text = "Service Request:";
            label1.Click += Create_lbl_Click;
            // 
            // Create_lbl
            // 
            Create_lbl.AutoSize = true;
            Create_lbl.BackColor = Color.Transparent;
            Create_lbl.FlatStyle = FlatStyle.Flat;
            Create_lbl.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            Create_lbl.Location = new Point(18, 12);
            Create_lbl.Name = "Create_lbl";
            Create_lbl.Size = new Size(191, 30);
            Create_lbl.TabIndex = 1;
            Create_lbl.Text = "Create Job Order";
            Create_lbl.Click += Create_lbl_Click;
            // 
            // Order_Panel
            // 
            Order_Panel.BackColor = Color.MintCream;
            Order_Panel.Controls.Add(Order_lbl);
            Order_Panel.Controls.Add(dataGridView1);
            Order_Panel.Location = new Point(349, 412);
            Order_Panel.Name = "Order_Panel";
            Order_Panel.Size = new Size(859, 277);
            Order_Panel.TabIndex = 7;
            // 
            // Order_lbl
            // 
            Order_lbl.AutoSize = true;
            Order_lbl.BackColor = Color.Transparent;
            Order_lbl.FlatStyle = FlatStyle.Flat;
            Order_lbl.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            Order_lbl.Location = new Point(18, 6);
            Order_lbl.Name = "Order_lbl";
            Order_lbl.Size = new Size(127, 30);
            Order_lbl.TabIndex = 1;
            Order_lbl.Text = "Job Orders";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.LightBlue;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(18, 40);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(820, 229);
            dataGridView1.TabIndex = 0;
            // 
            // Lbl_pnl
            // 
            Lbl_pnl.BackColor = SystemColors.InactiveCaption;
            Lbl_pnl.Controls.Add(Create_lbl);
            Lbl_pnl.Location = new Point(349, 40);
            Lbl_pnl.Name = "Lbl_pnl";
            Lbl_pnl.Size = new Size(859, 53);
            Lbl_pnl.TabIndex = 6;
            // 
            // Order_frm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.dashboard_bg;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1232, 701);
            Controls.Add(Order_Panel);
            Controls.Add(NavPanel);
            Controls.Add(Lbl_pnl);
            Controls.Add(CreatJob_Panel);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Order_frm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Job Orders";
            NavPanel.ResumeLayout(false);
            CreatJob_Panel.ResumeLayout(false);
            CreatJob_Panel.PerformLayout();
            Order_Panel.ResumeLayout(false);
            Order_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            Lbl_pnl.ResumeLayout(false);
            Lbl_pnl.PerformLayout();
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
        private Panel CreatJob_Panel;
        private Panel Order_Panel;
        private Label Order_lbl;
        private DataGridView dataGridView1;
        private Label Create_lbl;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Button button1;
        private Panel Lbl_pnl;
    }
}