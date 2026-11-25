using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RMMS
{
    public partial class MyreqFrm : Form
    {
        public MyreqFrm()
        {
            InitializeComponent();
        }

        private void Dash_Butt_Click(object sender, EventArgs e)
        {
            ReqDash RDash = new ReqDash();

            RDash.Show();
            this.Hide();
        }

        private void Sub_Butt_Click(object sender, EventArgs e)
        {
            Sub_Req Reqt = new Sub_Req();

            Reqt.Show();
            this.Hide();
        }

        private void Logout_Butt_Click(object sender, EventArgs e)
        {
            RMMS_Login login = new RMMS_Login();

            login.Show();
            this.Close();
        }
    }
}
