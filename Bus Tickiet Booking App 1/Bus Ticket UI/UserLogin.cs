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

namespace BusTicketUi
{
    public partial class UserLogin : Form
    {
        public static string uuserName;
        BusTicketDb db = new BusTicketDb();
        int mov;
        int movX;
        int movY;
        public UserLogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MainLogin j = new MainLogin();
            j.Show();
            this.Hide();
        }

        private void frgt_pas_clk(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotUser j = new ForgotUser();
            j.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CreateAcc j = new CreateAcc();
            j.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                var user = db.User.SingleOrDefault(x => x.uusername.Equals(textBox_un.Text) & x.password.Equals(textBox_pas.Text));
                if (user != null)
                {

                    uuserName = user.uusername;
                    new UserAcc().Show();
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

        private void textBox_un_clk(object sender, EventArgs e)
        {
            textBox_un.Clear();
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

        private void pas_mouse_clk(object sender, MouseEventArgs e)
        {
            textBox_pas.Clear();
        }

        private void user_panel_load(object sender, EventArgs e)
        {
            
        }
    }
}
