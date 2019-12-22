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
    public partial class ForgotUser : Form
    {
        BusTicketDb db = new BusTicketDb();
        public static string uuserName;

        int mov;
        int movX;
        int movY;
        public ForgotUser()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserLogin j = new UserLogin();
            j.Show();
            this.Hide();
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            try
            {
                var user = db.User.SingleOrDefault(x => x.uusername.Equals(textBox_user_name.Text) 
                & x.adress.Equals(textBox_phnnum.Text));
                if (user != null)
                {

                    uuserName = user.uusername;
                    MessageBox.Show("Id Found");
                    new ChangePasswordUser().Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("User name or location no not valid");

                }
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
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
