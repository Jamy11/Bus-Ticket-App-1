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
    public partial class ForgotAdmin : Form
    {
        BusTicketDb db = new BusTicketDb();
        public static string uuserName;

        int mov;
        int movX;
        int movY;
        public ForgotAdmin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminLogin j = new AdminLogin();
            j.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                var user = db.Admin.SingleOrDefault(x => x.username.Equals(textBox_aname.Text)
                & x.adress.Equals(textBox_adress.Text));
                if (user != null)
                {

                    uuserName = user.username;
                    MessageBox.Show("Id Found");
                    new ChangePasswordAdmin().Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("User name or phn no not valid");

                }
            }
            catch (Exception exc)
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

        private void textBox_aname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
