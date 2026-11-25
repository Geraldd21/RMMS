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
    public partial class Sub_Req : Form
    {
        public Sub_Req()
        {
            InitializeComponent();
            SetRoundedCorners(20);
            RoundPanel(FormPanel, 15);
            RoundButton(submitbutt, 30);
            RoundButton(clearbutt, 30);
            RoundPanel(NavPanel, 15);
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
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Back_But_Click(object sender, EventArgs e)
        {
            ReqDash RDash = new ReqDash();

            RDash.Show();
            this.Hide();
        }

        private void submitbutt_Click(object sender, EventArgs e)
        {
            ReqDash RDash = new ReqDash();

            RDash.Show();
            this.Hide();

        }

        private void Dash_Butt_Click(object sender, EventArgs e)
        {
            ReqDash RDash = new ReqDash();

            RDash.Show();
            this.Hide();
        }

        private void Logout_Butt_Click(object sender, EventArgs e)
        {
            RMMS_Login login = new RMMS_Login();

            login.Show();
            this.Close();
        }

        private void NavPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Req_Butt_Click(object sender, EventArgs e)
        {
            MyreqFrm MyReqDash = new MyreqFrm();

            MyReqDash.Show();
            this.Hide();
        }
    }
}
