namespace RMMS
{
    partial class MyreqFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyreqFrm));
            NamePanel = new Panel();
            Userlbl = new Label();
            Greetlbl = new Label();
            Acc_Icon = new PictureBox();
            NavPanel = new Panel();
            Logout_Butt = new Button();
            Req_Butt = new Button();
            Sub_Butt = new Button();
            Dash_Butt = new Button();
            Viewbutton = new Button();
            label1 = new Label();
            DGV_request = new DataGridView();
            NamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Acc_Icon).BeginInit();
            NavPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_request).BeginInit();
            SuspendLayout();
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
            NamePanel.TabIndex = 1;
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
            Userlbl.Size = new Size(77, 31);
            Userlbl.TabIndex = 1;
            Userlbl.Text = "(User)";
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
            // NavPanel
            // 
            NavPanel.BackColor = Color.MidnightBlue;
            NavPanel.Controls.Add(Logout_Butt);
            NavPanel.Controls.Add(Req_Butt);
            NavPanel.Controls.Add(Sub_Butt);
            NavPanel.Controls.Add(Dash_Butt);
            NavPanel.Location = new Point(-21, 40);
            NavPanel.Name = "NavPanel";
            NavPanel.Size = new Size(346, 667);
            NavPanel.TabIndex = 2;
            // 
            // Logout_Butt
            // 
            Logout_Butt.Cursor = Cursors.Hand;
            Logout_Butt.FlatAppearance.BorderSize = 0;
            Logout_Butt.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            Logout_Butt.FlatStyle = FlatStyle.Flat;
            Logout_Butt.ForeColor = Color.SkyBlue;
            Logout_Butt.Image = Properties.Resources.log_out1;
            Logout_Butt.Location = new Point(45, 265);
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
            Req_Butt.Image = Properties.Resources.Req;
            Req_Butt.Location = new Point(45, 186);
            Req_Butt.Name = "Req_Butt";
            Req_Butt.Size = new Size(277, 59);
            Req_Butt.TabIndex = 3;
            Req_Butt.UseVisualStyleBackColor = false;
            // 
            // Sub_Butt
            // 
            Sub_Butt.BackColor = Color.Transparent;
            Sub_Butt.Cursor = Cursors.Hand;
            Sub_Butt.FlatAppearance.BorderSize = 0;
            Sub_Butt.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            Sub_Butt.FlatStyle = FlatStyle.Flat;
            Sub_Butt.ForeColor = Color.SkyBlue;
            Sub_Butt.Image = Properties.Resources.Submit;
            Sub_Butt.Location = new Point(45, 102);
            Sub_Butt.Name = "Sub_Butt";
            Sub_Butt.Size = new Size(277, 59);
            Sub_Butt.TabIndex = 2;
            Sub_Butt.UseVisualStyleBackColor = false;
            Sub_Butt.Click += Sub_Butt_Click;
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
            // Viewbutton
            // 
            Viewbutton.BackColor = Color.RoyalBlue;
            Viewbutton.Cursor = Cursors.Hand;
            Viewbutton.FlatAppearance.BorderSize = 0;
            Viewbutton.FlatStyle = FlatStyle.Flat;
            Viewbutton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Viewbutton.ForeColor = Color.White;
            Viewbutton.Location = new Point(1076, 176);
            Viewbutton.Name = "Viewbutton";
            Viewbutton.Size = new Size(106, 29);
            Viewbutton.TabIndex = 5;
            Viewbutton.Text = "View all";
            Viewbutton.UseVisualStyleBackColor = false;
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
            label1.Size = new Size(207, 30);
            label1.TabIndex = 4;
            label1.Text = "My Repair Request";
            // 
            // DGV_request
            // 
            DGV_request.BackgroundColor = Color.MintCream;
            DGV_request.BorderStyle = BorderStyle.Fixed3D;
            DGV_request.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_request.Location = new Point(360, 226);
            DGV_request.Name = "DGV_request";
            DGV_request.RowHeadersWidth = 51;
            DGV_request.Size = new Size(831, 436);
            DGV_request.TabIndex = 6;
            // 
            // MyreqFrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.dashboard_bg;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1232, 701);
            Controls.Add(DGV_request);
            Controls.Add(Viewbutton);
            Controls.Add(label1);
            Controls.Add(NavPanel);
            Controls.Add(NamePanel);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MyreqFrm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "My Request";
            NamePanel.ResumeLayout(false);
            NamePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Acc_Icon).EndInit();
            NavPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGV_request).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel NamePanel;
        private Label Userlbl;
        private Label Greetlbl;
        private PictureBox Acc_Icon;
        private Panel NavPanel;
        private Button Logout_Butt;
        private Button Req_Butt;
        private Button Sub_Butt;
        private Button Dash_Butt;
        private Button Viewbutton;
        private Label label1;
        private DataGridView DGV_request;
    }
}