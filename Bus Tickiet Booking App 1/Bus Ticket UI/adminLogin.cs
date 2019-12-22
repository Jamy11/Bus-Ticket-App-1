using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bus_Tickiet_Booking_App_1.Data_Access;
using Bus_Tickiet_Booking_App_1.Data_Controller;


namespace BusTicketUi
{
   
    public partial class AdminLogin : Form
    {
        public static string userName;
       BusTicketDb db = new BusTicketDb();
        AdminController a = new AdminController();


        int mov;
        int movX;
        int movY;

        public AdminLogin()
        {
            InitializeComponent();
        }

        private void ad_back_btn_click(object sender, EventArgs e)
        {
            MainLogin j = new MainLogin();
            j.Show();
            this.Hide();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotAdmin j = new ForgotAdmin();
            j.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAdminSignIn_Click(object sender, EventArgs e)
        {
            try
            {

                var user = db.Admin.SingleOrDefault(x => x.username.Equals(textBox1.Text) & x.password.Equals(textBox2.Text));
                if (user != null)
                {

                    userName = user.username;
                    new AdminAcc().Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("User name or password not valid");
                    
                }


            }
            catch (Exception)
            {
                MessageBox.Show("Login Feild!!!!");
               
            }


        }



        private void textbox1_click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void textbox2_click(object sender, EventArgs e)
        {
            textBox2.Clear();
        }

        private void panel_mv_up(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void panel_mv_down(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void panel_mv_mv(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }
    }
}
