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
    public partial class ChangePasswordAdmin : Form
    {
        BusTicketDb db = new BusTicketDb();

        int mov;
        int movX;
        int movY;

        public ChangePasswordAdmin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                var user = db.Admin.FirstOrDefault(x => x.username == ForgotAdmin.uuserName);

                if (!textBox_pas.Text.Equals(""))
                {
                    if (textBox_pas.Text == textBox_cfrm_pas.Text)
                    {

                        user.password = textBox_pas.Text;
                        db.SaveChanges();
                        MessageBox.Show("Password Updated.");

                        AdminLogin j = new AdminLogin();
                        j.Show();
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

        private void button1_Click(object sender, EventArgs e)
        {
            AdminLogin j = new AdminLogin();
            j.Show();
            this.Hide();
        }
    }
}
