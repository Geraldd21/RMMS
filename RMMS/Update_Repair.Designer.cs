namespace RMMS
{
    partial class Update_Repair
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Update_Repair));
            NavPanel = new Panel();
            Logout_Butt = new Button();
            Order_Butt = new Button();
            Serv_Butt = new Button();
            Dash_Butt = new Button();
            panel1 = new Panel();
            title = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            NavPanel.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // NavPanel
            // 
            NavPanel.BackColor = Color.MidnightBlue;
            NavPanel.Controls.Add(Logout_Butt);
            NavPanel.Controls.Add(Order_Butt);
            NavPanel.Controls.Add(Serv_Butt);
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
            // 
            // panel1
            // 
            panel1.BackColor = Color.MintCream;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(title);
            panel1.Location = new Point(344, 40);
            panel1.Name = "panel1";
            panel1.Size = new Size(870, 423);
            panel1.TabIndex = 6;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            title.Location = new Point(22, 24);
            title.Name = "title";
            title.Size = new Size(156, 30);
            title.TabIndex = 0;
            title.Text = "Repair Details";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlDark;
            label2.Location = new Point(22, 83);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 0;
            label2.Text = "Job Order ID:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(22, 116);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 0;
            label1.Text = "Diagnosis:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(321, 76);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(348, 27);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(321, 109);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(348, 27);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(321, 142);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(348, 27);
            textBox3.TabIndex = 1;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(321, 175);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(348, 27);
            textBox4.TabIndex = 1;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(321, 208);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(348, 27);
            textBox5.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(22, 149);
            label3.Name = "label3";
            label3.Size = new Size(101, 20);
            label3.TabIndex = 0;
            label3.Text = "Action Taken:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(22, 182);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 0;
            label4.Text = "Part Used:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(22, 215);
            label5.Name = "label5";
            label5.Size = new Size(136, 20);
            label5.TabIndex = 0;
            label5.Text = "Completion Notes:";
            // 
            // button1
            // 
            button1.BackColor = Color.RoyalBlue;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(292, 363);
            button1.Name = "button1";
            button1.Size = new Size(279, 41);
            button1.TabIndex = 2;
            button1.Text = "Submit for Verification";
            button1.UseVisualStyleBackColor = false;
            // 
            // Update_Repair
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.SubmitFrm;
            ClientSize = new Size(1232, 701);
            Controls.Add(panel1);
            Controls.Add(NavPanel);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Update_Repair";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Update_Repair";
            NavPanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel NavPanel;
        private Button Logout_Butt;
        private Button Order_Butt;
        private Button Serv_Butt;
        private Button Dash_Butt;
        private Panel panel1;
        private Label label2;
        private Label title;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private Button button1;
    }
}