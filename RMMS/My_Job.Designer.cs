namespace RMMS
{
    partial class My_Job
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(My_Job));
            NavPanel = new Panel();
            Logout_Butt = new Button();
            Update_Butt = new Button();
            Job_Butt = new Button();
            Dash_Butt = new Button();
            NamePanel = new Panel();
            Userlbl = new Label();
            Greetlbl = new Label();
            Acc_Icon = new PictureBox();
            DGV_request = new DataGridView();
            label1 = new Label();
            Start_Butt = new Button();
            NavPanel.SuspendLayout();
            NamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Acc_Icon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGV_request).BeginInit();
            SuspendLayout();
            // 
            // NavPanel
            // 
            NavPanel.BackColor = Color.MidnightBlue;
            NavPanel.Controls.Add(Logout_Butt);
            NavPanel.Controls.Add(Update_Butt);
            NavPanel.Controls.Add(Job_Butt);
            NavPanel.Controls.Add(Dash_Butt);
            NavPanel.Location = new Point(-21, 40);
            NavPanel.Name = "NavPanel";
            NavPanel.Size = new Size(346, 667);
            NavPanel.TabIndex = 5;
            // 
            // Logout_Butt
            // 
            Logout_Butt.Cursor = Cursors.Hand;
            Logout_Butt.FlatAppearance.BorderSize = 0;
            Logout_Butt.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            Logout_Butt.FlatStyle = FlatStyle.Flat;
            Logout_Butt.ForeColor = Color.SkyBlue;
            Logout_Butt.Image = Properties.Resources.log_out1;
            Logout_Butt.Location = new Point(45, 269);
            Logout_Butt.Name = "Logout_Butt";
            Logout_Butt.Size = new Size(277, 59);
            Logout_Butt.TabIndex = 4;
            Logout_Butt.UseVisualStyleBackColor = true;
            Logout_Butt.Click += Logout_Butt_Click;
            // 
            // Update_Butt
            // 
            Update_Butt.BackColor = Color.Transparent;
            Update_Butt.Cursor = Cursors.Hand;
            Update_Butt.FlatAppearance.BorderSize = 0;
            Update_Butt.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            Update_Butt.FlatStyle = FlatStyle.Flat;
            Update_Butt.ForeColor = Color.SkyBlue;
            Update_Butt.Image = Properties.Resources.Update_Repair;
            Update_Butt.Location = new Point(45, 186);
            Update_Butt.Name = "Update_Butt";
            Update_Butt.Size = new Size(277, 59);
            Update_Butt.TabIndex = 3;
            Update_Butt.UseVisualStyleBackColor = false;
            Update_Butt.Click += Update_Butt_Click;
            // 
            // Job_Butt
            // 
            Job_Butt.BackColor = Color.Transparent;
            Job_Butt.Cursor = Cursors.Hand;
            Job_Butt.FlatAppearance.BorderSize = 0;
            Job_Butt.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            Job_Butt.FlatStyle = FlatStyle.Flat;
            Job_Butt.ForeColor = Color.SkyBlue;
            Job_Butt.Image = Properties.Resources.My_Job;
            Job_Butt.Location = new Point(45, 102);
            Job_Butt.Name = "Job_Butt";
            Job_Butt.Size = new Size(277, 59);
            Job_Butt.TabIndex = 2;
            Job_Butt.UseVisualStyleBackColor = false;
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
            NamePanel.TabIndex = 20;
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
            Userlbl.Size = new Size(141, 31);
            Userlbl.TabIndex = 1;
            Userlbl.Text = "(Technician)";
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
            // DGV_request
            // 
            DGV_request.BackgroundColor = Color.MintCream;
            DGV_request.BorderStyle = BorderStyle.Fixed3D;
            DGV_request.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_request.Location = new Point(360, 226);
            DGV_request.Name = "DGV_request";
            DGV_request.RowHeadersWidth = 51;
            DGV_request.Size = new Size(831, 376);
            DGV_request.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(360, 175);
            label1.Name = "label1";
            label1.Size = new Size(173, 30);
            label1.TabIndex = 22;
            label1.Text = "My Assign Jobs";
            // 
            // Start_Butt
            // 
            Start_Butt.BackColor = Color.RoyalBlue;
            Start_Butt.Cursor = Cursors.Hand;
            Start_Butt.FlatAppearance.BorderSize = 0;
            Start_Butt.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            Start_Butt.FlatStyle = FlatStyle.Flat;
            Start_Butt.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            Start_Butt.ForeColor = Color.White;
            Start_Butt.Location = new Point(447, 628);
            Start_Butt.Name = "Start_Butt";
            Start_Butt.Size = new Size(649, 56);
            Start_Butt.TabIndex = 23;
            Start_Butt.Text = "Start Repair";
            Start_Butt.UseVisualStyleBackColor = false;
            // 
            // My_Job
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.dashboard_bg;
            ClientSize = new Size(1232, 701);
            Controls.Add(Start_Butt);
            Controls.Add(label1);
            Controls.Add(DGV_request);
            Controls.Add(NamePanel);
            Controls.Add(NavPanel);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "My_Job";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "My_Job";
            Load += My_Job_Load;
            NavPanel.ResumeLayout(false);
            NamePanel.ResumeLayout(false);
            NamePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Acc_Icon).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGV_request).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel NavPanel;
        private Button Logout_Butt;
        private Button Update_Butt;
        private Button Job_Butt;
        private Button Dash_Butt;
        private Panel NamePanel;
        private Label Userlbl;
        private Label Greetlbl;
        private PictureBox Acc_Icon;
        private DataGridView DGV_request;
        private Label label1;
        private Button Start_Butt;
    }
}