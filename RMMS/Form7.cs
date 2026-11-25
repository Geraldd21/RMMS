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
    public partial class Order_frm : Form
    {
        public Order_frm()
        {
            InitializeComponent();
            SetRoundedCorners(20);
            RoundPanel(NavPanel, 15);
            RoundPanel(Lbl_pnl, 15);
            RoundPanel(CreatJob_Panel, 15);
            RoundPanel(Order_Panel, 15);
            RoundButton(Assign_Butt, 15);
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


        private void Create_lbl_Click(object sender, EventArgs e)
        {

        }

        private void Logout_Butt_Click(object sender, EventArgs e)
        {
            RMMS_Login login = new RMMS_Login();

            login.Show();
            this.Close();
        }

        private void Maint_Butt_Click(object sender, EventArgs e)
        {
            Maint_Frm Maintenance = new Maint_Frm();

            Maintenance.Show();
            this.Hide();
        }

        private void Serv_Butt_Click(object sender, EventArgs e)
        {
            ServReq_Frm SReqt = new ServReq_Frm();

            SReqt.Show();
            this.Hide();
        }

        private void Dash_Butt_Click(object sender, EventArgs e)
        {
            AdminDashFrm A_dash = new AdminDashFrm();

            A_dash.Show();
            this.Hide();
        }

        private void Tech_Butt_Click(object sender, EventArgs e)
        {
            Tech_Frm Technician = new Tech_Frm();
            Technician.Show();
            this.Hide();
        }

        private void Order_frm_Load(object sender, EventArgs e)
        {

        }
    }
}
