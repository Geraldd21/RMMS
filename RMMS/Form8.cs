using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RMMS
{
    public partial class Maint_Frm : Form
    {
        public Maint_Frm()
        {
            InitializeComponent();
        }

        private void Logout_Butt_Click(object sender, EventArgs e)
        {
            RMMS_Login login = new RMMS_Login();

            login.Show();
            this.Close();
        }

        private void Req_Butt_Click(object sender, EventArgs e)
        {
            Order_frm Job = new Order_frm();

            Job.Show();
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
    }
}
