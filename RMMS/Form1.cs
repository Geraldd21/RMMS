using System.Drawing.Drawing2D;

namespace RMMS
{
    public partial class RMMS_Login : Form
    {
        public RMMS_Login()
        {
            InitializeComponent();
            SetRoundedCorners(35);
            RoundPanel(login_panel, 15);
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


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Technician_Dashboard TDash = new Technician_Dashboard();

            TDash.Show();
            this.Hide();
        }

        private void signupbutton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
