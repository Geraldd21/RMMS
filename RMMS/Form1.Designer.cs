namespace RMMS
{
    partial class RMMS_Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RMMS_Login));
            login_panel = new Panel();
            PassIcon = new PictureBox();
            UserIcon = new PictureBox();
            linkLabel1 = new LinkLabel();
            label1 = new Label();
            signupbutton = new Button();
            loginbutt = new Button();
            ShowPass = new CheckBox();
            PassTB = new TextBox();
            UserTB = new TextBox();
            pictureBox1 = new PictureBox();
            Exit = new Button();
            title = new Label();
            panel1 = new Panel();
            label2 = new Label();
            login_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PassIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UserIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // login_panel
            // 
            login_panel.BackColor = Color.MintCream;
            login_panel.BackgroundImageLayout = ImageLayout.None;
            login_panel.Controls.Add(PassIcon);
            login_panel.Controls.Add(UserIcon);
            login_panel.Controls.Add(linkLabel1);
            login_panel.Controls.Add(label1);
            login_panel.Controls.Add(signupbutton);
            login_panel.Controls.Add(loginbutt);
            login_panel.Controls.Add(ShowPass);
            login_panel.Controls.Add(PassTB);
            login_panel.Controls.Add(UserTB);
            login_panel.Location = new Point(329, 26);
            login_panel.Name = "login_panel";
            login_panel.Size = new Size(270, 388);
            login_panel.TabIndex = 0;
            login_panel.Paint += panel1_Paint;
            // 
            // PassIcon
            // 
            PassIcon.BackColor = Color.Transparent;
            PassIcon.BackgroundImage = (Image)resources.GetObject("PassIcon.BackgroundImage");
            PassIcon.BackgroundImageLayout = ImageLayout.Zoom;
            PassIcon.Image = (Image)resources.GetObject("PassIcon.Image");
            PassIcon.Location = new Point(12, 127);
            PassIcon.Name = "PassIcon";
            PassIcon.Size = new Size(25, 25);
            PassIcon.TabIndex = 1;
            PassIcon.TabStop = false;
            // 
            // UserIcon
            // 
            UserIcon.BackColor = Color.Transparent;
            UserIcon.BackgroundImage = (Image)resources.GetObject("UserIcon.BackgroundImage");
            UserIcon.BackgroundImageLayout = ImageLayout.Zoom;
            UserIcon.Image = (Image)resources.GetObject("UserIcon.Image");
            UserIcon.Location = new Point(12, 75);
            UserIcon.Name = "UserIcon";
            UserIcon.Size = new Size(25, 25);
            UserIcon.TabIndex = 1;
            UserIcon.TabStop = false;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.RoyalBlue;
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.Cursor = Cursors.Hand;
            linkLabel1.ForeColor = Color.Transparent;
            linkLabel1.LinkColor = Color.DarkGray;
            linkLabel1.Location = new Point(72, 350);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(124, 20);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Forget Password?";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(4, 11);
            label1.Name = "label1";
            label1.Size = new Size(110, 46);
            label1.TabIndex = 5;
            label1.Text = "Login";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // signupbutton
            // 
            signupbutton.BackColor = Color.Transparent;
            signupbutton.FlatAppearance.BorderColor = Color.RoyalBlue;
            signupbutton.FlatAppearance.BorderSize = 2;
            signupbutton.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
            signupbutton.FlatStyle = FlatStyle.Flat;
            signupbutton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            signupbutton.ForeColor = Color.RoyalBlue;
            signupbutton.Location = new Point(19, 295);
            signupbutton.Name = "signupbutton";
            signupbutton.Size = new Size(89, 34);
            signupbutton.TabIndex = 4;
            signupbutton.Text = "Sign Up";
            signupbutton.UseVisualStyleBackColor = false;
            signupbutton.Click += signupbutton_Click;
            // 
            // loginbutt
            // 
            loginbutt.BackColor = Color.RoyalBlue;
            loginbutt.FlatAppearance.BorderSize = 0;
            loginbutt.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
            loginbutt.FlatStyle = FlatStyle.Flat;
            loginbutt.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            loginbutt.ForeColor = Color.WhiteSmoke;
            loginbutt.Location = new Point(136, 295);
            loginbutt.Name = "loginbutt";
            loginbutt.Size = new Size(118, 34);
            loginbutt.TabIndex = 3;
            loginbutt.Text = "Log in";
            loginbutt.UseVisualStyleBackColor = false;
            loginbutt.Click += button1_Click;
            // 
            // ShowPass
            // 
            ShowPass.AutoSize = true;
            ShowPass.Cursor = Cursors.Hand;
            ShowPass.ForeColor = Color.DarkGray;
            ShowPass.Location = new Point(122, 163);
            ShowPass.Name = "ShowPass";
            ShowPass.Size = new Size(132, 24);
            ShowPass.TabIndex = 2;
            ShowPass.Text = "Show Password";
            ShowPass.UseVisualStyleBackColor = true;
            ShowPass.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // PassTB
            // 
            PassTB.BackColor = SystemColors.Window;
            PassTB.Cursor = Cursors.IBeam;
            PassTB.Location = new Point(43, 127);
            PassTB.Multiline = true;
            PassTB.Name = "PassTB";
            PassTB.PlaceholderText = "Password";
            PassTB.Size = new Size(211, 30);
            PassTB.TabIndex = 1;
            // 
            // UserTB
            // 
            UserTB.Cursor = Cursors.IBeam;
            UserTB.Location = new Point(43, 71);
            UserTB.Multiline = true;
            UserTB.Name = "UserTB";
            UserTB.PlaceholderText = "Username";
            UserTB.Size = new Size(211, 31);
            UserTB.TabIndex = 0;
            UserTB.TextChanged += textBox1_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(73, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(118, 103);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Exit
            // 
            Exit.BackColor = Color.Transparent;
            Exit.BackgroundImage = (Image)resources.GetObject("Exit.BackgroundImage");
            Exit.BackgroundImageLayout = ImageLayout.Zoom;
            Exit.FlatAppearance.BorderSize = 0;
            Exit.FlatAppearance.MouseOverBackColor = Color.Red;
            Exit.FlatStyle = FlatStyle.Flat;
            Exit.Location = new Point(619, 14);
            Exit.Name = "Exit";
            Exit.Size = new Size(25, 25);
            Exit.TabIndex = 2;
            Exit.UseVisualStyleBackColor = false;
            Exit.Click += Exit_Click;
            // 
            // title
            // 
            title.AutoSize = true;
            title.BackColor = Color.Transparent;
            title.FlatStyle = FlatStyle.Flat;
            title.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            title.ForeColor = Color.RoyalBlue;
            title.Location = new Point(70, 98);
            title.Name = "title";
            title.Size = new Size(127, 46);
            title.TabIndex = 3;
            title.Text = "RMMS";
            title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(title);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(38, 21);
            panel1.Name = "panel1";
            panel1.Size = new Size(260, 199);
            panel1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(36, 141);
            label2.Name = "label2";
            label2.Size = new Size(197, 40);
            label2.TabIndex = 3;
            label2.Text = "Repair and Maintenance \r\nManagement System";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // RMMS_Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Magenta;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(663, 433);
            Controls.Add(panel1);
            Controls.Add(Exit);
            Controls.Add(login_panel);
            DoubleBuffered = true;
            ForeColor = Color.Transparent;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "RMMS_Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RMMS_Login";
            Load += Form1_Load;
            login_panel.ResumeLayout(false);
            login_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PassIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)UserIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel login_panel;
        private TextBox UserTB;
        private TextBox PassTB;
        private CheckBox ShowPass;
        private Button loginbutt;
        private Button signupbutton;
        private LinkLabel linkLabel1;
        private Label label1;
        private PictureBox UserIcon;
        private PictureBox PassIcon;
        private PictureBox pictureBox1;
        private Button Exit;
        private Label title;
        private Panel panel1;
        private Label label2;
    }
}
