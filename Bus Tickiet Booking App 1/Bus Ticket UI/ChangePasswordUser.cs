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
    public partial class ChangePasswordUser : Form
    {
        BusTicketDb db = new BusTicketDb();

        int mov;
        int movX;
        int movY;


        public ChangePasswordUser()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                var user = db.User.FirstOrDefault(x => x.uusername == ForgotUser.uuserName);

                if (!textBox_upas.Text.Equals(""))
                {
                    if (textBox_upas.Text == textBox_ucfrm_pas.Text)
                    {

                        user.password = textBox_upas.Text;
                        db.SaveChanges();
                        MessageBox.Show("Password Updated.");

                        UserLogin u = new UserLogin();
                        u.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Password do not match");
                    }
                }
                else
                {
                    MessageBox.Show("Password Or Confirm Password Cant Be Empty");
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
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
