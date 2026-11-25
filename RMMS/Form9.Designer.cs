namespace RMMS
{
    partial class Tech_Frm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tech_Frm));
            NavPanel = new Panel();
            Tech_Butt = new Button();
            Logout_Butt = new Button();
            Req_Butt = new Button();
            Serv_Butt = new Button();
            Dash_Butt = new Button();
            Maint_Butt = new Button();
            Tech_Panel = new Panel();
            AddTech_Panel = new Panel();
            Update_butt = new Button();
            pictureBox1 = new PictureBox();
            Save_Butt = new Button();
            Cancel_Butt = new Button();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            Inact_RB = new RadioButton();
            Active_RB = new RadioButton();
            Email_Txb = new TextBox();
            Id_txb = new TextBox();
            Special_Cb = new ComboBox();
            Cont_txb = new TextBox();
            Name_txb = new TextBox();
            label3 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            Add_Butt = new Button();
            label1 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            NavPanel.SuspendLayout();
            Tech_Panel.SuspendLayout();
            AddTech_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            NavPanel.TabIndex = 6;
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
            // Tech_Panel
            // 
            Tech_Panel.Controls.Add(AddTech_Panel);
            Tech_Panel.Controls.Add(dataGridView1);
            Tech_Panel.Controls.Add(Add_Butt);
            Tech_Panel.Controls.Add(label1);
            Tech_Panel.Location = new Point(347, 40);
            Tech_Panel.Name = "Tech_Panel";
            Tech_Panel.Size = new Size(873, 633);
            Tech_Panel.TabIndex = 7;
            // 
            // AddTech_Panel
            // 
            AddTech_Panel.Controls.Add(Update_butt);
            AddTech_Panel.Controls.Add(pictureBox1);
            AddTech_Panel.Controls.Add(Save_Butt);
            AddTech_Panel.Controls.Add(Cancel_Butt);
            AddTech_Panel.Controls.Add(label8);
            AddTech_Panel.Controls.Add(label7);
            AddTech_Panel.Controls.Add(label6);
            AddTech_Panel.Controls.Add(label5);
            AddTech_Panel.Controls.Add(label4);
            AddTech_Panel.Controls.Add(Inact_RB);
            AddTech_Panel.Controls.Add(Active_RB);
            AddTech_Panel.Controls.Add(Email_Txb);
            AddTech_Panel.Controls.Add(Id_txb);
            AddTech_Panel.Controls.Add(Special_Cb);
            AddTech_Panel.Controls.Add(Cont_txb);
            AddTech_Panel.Controls.Add(Name_txb);
            AddTech_Panel.Controls.Add(label3);
            AddTech_Panel.Controls.Add(label2);
            AddTech_Panel.Location = new Point(105, 46);
            AddTech_Panel.Name = "AddTech_Panel";
            AddTech_Panel.Size = new Size(624, 521);
            AddTech_Panel.TabIndex = 3;
            AddTech_Panel.Visible = false;
            // 
            // Update_butt
            // 
            Update_butt.BackColor = Color.SeaGreen;
            Update_butt.Cursor = Cursors.Hand;
            Update_butt.FlatAppearance.BorderSize = 0;
            Update_butt.FlatStyle = FlatStyle.Flat;
            Update_butt.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Update_butt.ForeColor = Color.White;
            Update_butt.Location = new Point(24, 467);
            Update_butt.Name = "Update_butt";
            Update_butt.Size = new Size(171, 33);
            Update_butt.TabIndex = 13;
            Update_butt.Text = "🔁 Update Technician";
            Update_butt.UseVisualStyleBackColor = false;
            Update_butt.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.audience;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(24, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 60);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // Save_Butt
            // 
            Save_Butt.BackColor = Color.RoyalBlue;
            Save_Butt.Cursor = Cursors.Hand;
            Save_Butt.FlatAppearance.BorderSize = 0;
            Save_Butt.FlatStyle = FlatStyle.Flat;
            Save_Butt.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Save_Butt.ForeColor = Color.White;
            Save_Butt.Location = new Point(441, 467);
            Save_Butt.Name = "Save_Butt";
            Save_Butt.Size = new Size(160, 33);
            Save_Butt.TabIndex = 11;
            Save_Butt.Text = "💾 Save Technician";
            Save_Butt.UseVisualStyleBackColor = false;
            Save_Butt.Click += Save_Butt_Click;
            // 
            // Cancel_Butt
            // 
            Cancel_Butt.BackColor = Color.Transparent;
            Cancel_Butt.Cursor = Cursors.Hand;
            Cancel_Butt.FlatAppearance.BorderColor = Color.DarkGray;
            Cancel_Butt.FlatAppearance.BorderSize = 2;
            Cancel_Butt.FlatStyle = FlatStyle.Flat;
            Cancel_Butt.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Cancel_Butt.Location = new Point(327, 467);
            Cancel_Butt.Name = "Cancel_Butt";
            Cancel_Butt.Size = new Size(93, 33);
            Cancel_Butt.TabIndex = 10;
            Cancel_Butt.Text = "Cancel";
            Cancel_Butt.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(24, 240);
            label8.Name = "label8";
            label8.Size = new Size(103, 20);
            label8.TabIndex = 9;
            label8.Text = "Specialization";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(316, 166);
            label7.Name = "label7";
            label7.Size = new Size(104, 20);
            label7.TabIndex = 9;
            label7.Text = "Email Address";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(24, 166);
            label6.Name = "label6";
            label6.Size = new Size(122, 20);
            label6.TabIndex = 9;
            label6.Text = "Contact Number";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(316, 93);
            label5.Name = "label5";
            label5.Size = new Size(95, 20);
            label5.TabIndex = 9;
            label5.Text = "Employee ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(24, 93);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 9;
            label4.Text = "Full Name";
            // 
            // Inact_RB
            // 
            Inact_RB.AutoSize = true;
            Inact_RB.Location = new Point(407, 265);
            Inact_RB.Name = "Inact_RB";
            Inact_RB.Size = new Size(81, 24);
            Inact_RB.TabIndex = 8;
            Inact_RB.TabStop = true;
            Inact_RB.Text = "Inactive";
            Inact_RB.UseVisualStyleBackColor = true;
            Inact_RB.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // Active_RB
            // 
            Active_RB.AutoSize = true;
            Active_RB.Location = new Point(316, 265);
            Active_RB.Name = "Active_RB";
            Active_RB.Size = new Size(71, 24);
            Active_RB.TabIndex = 7;
            Active_RB.TabStop = true;
            Active_RB.Text = "Active";
            Active_RB.UseVisualStyleBackColor = true;
            // 
            // Email_Txb
            // 
            Email_Txb.Location = new Point(316, 189);
            Email_Txb.Multiline = true;
            Email_Txb.Name = "Email_Txb";
            Email_Txb.PlaceholderText = "✉ Enter email address";
            Email_Txb.Size = new Size(256, 34);
            Email_Txb.TabIndex = 6;
            // 
            // Id_txb
            // 
            Id_txb.Location = new Point(316, 116);
            Id_txb.Multiline = true;
            Id_txb.Name = "Id_txb";
            Id_txb.PlaceholderText = "\U0001faaa Enter employee ID";
            Id_txb.Size = new Size(256, 34);
            Id_txb.TabIndex = 5;
            // 
            // Special_Cb
            // 
            Special_Cb.FormattingEnabled = true;
            Special_Cb.Location = new Point(24, 261);
            Special_Cb.Name = "Special_Cb";
            Special_Cb.Size = new Size(256, 28);
            Special_Cb.TabIndex = 4;
            // 
            // Cont_txb
            // 
            Cont_txb.Location = new Point(24, 189);
            Cont_txb.Multiline = true;
            Cont_txb.Name = "Cont_txb";
            Cont_txb.PlaceholderText = "📞 Enter contact number";
            Cont_txb.Size = new Size(256, 34);
            Cont_txb.TabIndex = 3;
            // 
            // Name_txb
            // 
            Name_txb.Location = new Point(24, 116);
            Name_txb.Multiline = true;
            Name_txb.Name = "Name_txb";
            Name_txb.PlaceholderText = "👤 Enter technician full name";
            Name_txb.Size = new Size(256, 34);
            Name_txb.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(96, 45);
            label3.Name = "label3";
            label3.Size = new Size(357, 20);
            label3.TabIndex = 1;
            label3.Text = "Fill in the details belows to register a new technician.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.Location = new Point(96, 22);
            label2.Name = "label2";
            label2.Size = new Size(131, 23);
            label2.TabIndex = 0;
            label2.Text = "Add Technician";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.InactiveCaption;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(13, 86);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(845, 410);
            dataGridView1.TabIndex = 2;
            // 
            // Add_Butt
            // 
            Add_Butt.BackColor = Color.RoyalBlue;
            Add_Butt.Cursor = Cursors.Hand;
            Add_Butt.FlatAppearance.BorderSize = 0;
            Add_Butt.FlatStyle = FlatStyle.Flat;
            Add_Butt.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            Add_Butt.ForeColor = Color.White;
            Add_Butt.Location = new Point(688, 24);
            Add_Butt.Name = "Add_Butt";
            Add_Butt.Size = new Size(152, 41);
            Add_Butt.TabIndex = 1;
            Add_Butt.Text = "➕ Add Technician";
            Add_Butt.UseVisualStyleBackColor = false;
            Add_Butt.Click += Add_Butt_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label1.Location = new Point(13, 13);
            label1.Name = "label1";
            label1.Size = new Size(253, 30);
            label1.TabIndex = 0;
            label1.Text = "Technician Registration";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // Tech_Frm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.SubmitFrm;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1232, 701);
            Controls.Add(Tech_Panel);
            Controls.Add(NavPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Tech_Frm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Technician";
            Load += Tech_Frm_Load;
            NavPanel.ResumeLayout(false);
            Tech_Panel.ResumeLayout(false);
            Tech_Panel.PerformLayout();
            AddTech_Panel.ResumeLayout(false);
            AddTech_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel NavPanel;
        private Button Tech_Butt;
        private Button Logout_Butt;
        private Button Req_Butt;
        private Button Serv_Butt;
        private Button Dash_Butt;
        private Button Maint_Butt;
        private Panel Tech_Panel;
        private Button Add_Butt;
        private Label label1;
        private DataGridView dataGridView1;
        private Panel AddTech_Panel;
        private Label label2;
        private Label label3;
        private TextBox Email_Txb;
        private TextBox Id_txb;
        private ComboBox Special_Cb;
        private TextBox Cont_txb;
        private TextBox Name_txb;
        private ContextMenuStrip contextMenuStrip1;
        private RadioButton Inact_RB;
        private RadioButton Active_RB;
        private Label label4;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label8;
        private Button Save_Butt;
        private Button Cancel_Butt;
        private PictureBox pictureBox1;
        private Button Update_butt;
    }
}