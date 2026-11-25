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
    public partial class ReqDash : Form
    {
        public ReqDash()
        {
            InitializeComponent();
            RoundPanel(NamePanel, 30);
            RoundPanel(NavPanel, 15);
            SetRoundedCorners(20);
            RoundButton(Viewbutton, 15);
            RoundPanel(Tot_Pnl, 15);
            RoundPanel(Pend_Pnl, 15);
            RoundPanel(InProg_Pnl, 15);
            RoundPanel(Verf_Pnl, 15);
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

        private void ReqDash_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panelSuccs.Visible = false;
            tmrAlert.Stop();
        }
        private void ShowSuccess(string message)
        {
            lblSucces.Text = message;
            panelSuccs.Visible = true;
            tmrAlert.Start();
        }

        private void Viewbutton_Click(object sender, EventArgs e)
        {
            ShowSuccess("Your repair request has been successfully completed!");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Logout_Butt_Click(object sender, EventArgs e)
        {
            RMMS_Login login = new RMMS_Login();

            login.Show();
            this.Close();
        }

        private void Sub_Butt_Click(object sender, EventArgs e)
        {
            Sub_Req Reqt = new Sub_Req();

            Reqt.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

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

        private void panelSuccs_Paint(object sender, PaintEventArgs e)
        {

        }

        private void NamePanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
