using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace RMMS
{
    public partial class My_Job : Form
    {
        public My_Job()
        {
            InitializeComponent();
            SetRoundedCorners(20);
            RoundPanel(NavPanel, 15);
            RoundPanel(NamePanel, 15);
            RoundButton(Start_Butt, 15);
        }

        private void SetRoundedCorners(int radius)
        {
            GraphicsPath path = new GraphicsPath();

            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(Width - radius, Height - radius, radius, radius, 0, 90);
            path.AddArc(0, Height - radius, radius, radius, 90, 90);

            path.CloseFigure();
            Region = new Region(path);
        }

        private void RoundPanel(Panel panel, int radius)
        {
            GraphicsPath path = new GraphicsPath();

            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(panel.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(panel.Width - radius, panel.Height - radius,
                        radius, radius, 0, 90);
            path.AddArc(0, panel.Height - radius,
                        radius, radius, 90, 90);

            path.CloseFigure();
            panel.Region = new Region(path);
        }

        private void RoundButton(Button button, int radius)
        {
            GraphicsPath path = new GraphicsPath();

            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(button.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(button.Width - radius, button.Height - radius,
                        radius, radius, 0, 90);
            path.AddArc(0, button.Height - radius,
                        radius, radius, 90, 90);

            path.CloseFigure();
            button.Region = new Region(path);
        }

        private void Dash_Butt_Click(object sender, EventArgs e)
        {
            Technician_Dashboard tech_dash = new Technician_Dashboard();
            tech_dash.Show();
            this.Hide();
        }

        private void Update_Butt_Click(object sender, EventArgs e)
        {
            Update_Repair Update = new Update_Repair();
            Update.Show();
            this.Hide();
        }

        private void Logout_Butt_Click(object sender, EventArgs e)
        {
            RMMS_Login login = new RMMS_Login();
            login.Show();
            this.Close();
        }

        private void My_Job_Load(object sender, EventArgs e)
        {

        }
    }
}
