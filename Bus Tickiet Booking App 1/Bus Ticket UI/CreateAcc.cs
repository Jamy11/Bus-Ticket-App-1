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
    public partial class CreateAcc : Form
    {
        BusTicketDb db = new BusTicketDb();
        int mov;
        int movX;
        int movY;
        public CreateAcc()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UserLogin j = new UserLogin();
            j.Show();
            this.Hide();
        }

        private void textBox_ucun_clk(object sender, EventArgs e)
        {
            textBox_ucun.Clear();
        }

        private void textBox_ucname_clk(object sender, EventArgs e)
        {
            textBox_ucname.Clear();
        }

        private void textBox_ucpas_clk(object sender, EventArgs e)
        {
            textBox_ucpas.Clear();
        }

        private void textBox_uccp_clk(object sender, EventArgs e)
        {
            textBox_uccp.Clear();
        }

        private void textBox_ucemail_clk(object sender, EventArgs e)
        {
            textBox_ucemail.Clear();
        }

        private void textBox_ucadress_clk(object sender, EventArgs e)
        {
            textBox_ucadress.Clear();
        }

        private void textBox_ucphn_clk(object sender, EventArgs e)
        {
            textBox_ucphn.Clear();
        }


        private void btn_crt_acc_us_Click(object sender, EventArgs e)
        {
            try
            {
                User u = new User();


                if (!textBox_ucun.Text.Equals("") & !textBox_ucname.Text.Equals("") 
                    & !textBox_ucemail.Text.Equals("")
                    & !textBox_ucadress.Text.Equals("") & !textBox_ucphn.Text.Equals("") 
                    & !textBox_ucpas.Text.Equals(""))
                {
                    u.uusername = textBox_ucun.Text;

                    u.name = textBox_ucname.Text;

                    u.email = textBox_ucemail.Text;

                    u.adress = textBox_ucadress.Text;

                    u.phnno = Convert.ToInt32(textBox_ucphn.Text);

                    if (textBox_ucpas.Text == textBox_uccp.Text)
                    {

                        u.password = textBox_ucpas.Text;
                        db.User.Add(u);
                        db.SaveChanges();
                        MessageBox.Show("User added");

                        UserLogin j = new UserLogin();
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
                    MessageBox.Show("Please fill up all the details");
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
    }
}
