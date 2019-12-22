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
    public partial class UserAcc : Form
    {
        public static int i;
        public static string SerielNumber { get; set; }
        int mov;
        int movX;
        int movY;
        BusTicketDb db = new BusTicketDb();
        public UserAcc()
        {
            InitializeComponent();
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MainLogin J = new MainLogin();
            J.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UserAcc_Load(object sender, EventArgs e)
        {
            try
            {
                var user = db.User.FirstOrDefault(x => x.uusername == UserLogin.uuserName);
                label_sun.Text = user.uusername;
                label_sname.Text = user.name;
                label_smail.Text = user.email;
                label_adress.Text = user.adress;
                label_spn.Text = Convert.ToString(user.phnno);

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }

            try
            {
                var bus_details = (from x in db.AddBus select x).ToList();
                dataGridView_ubusinfo.DataSource = bus_details;
                //   dataGridView_admin.DataBindings();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }


        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            try
            {
                var user = db.User.FirstOrDefault(x => x.uusername == UserLogin.uuserName);
                label_sun.Text = user.uusername;
                label_sname.Text = user.name;
                label_smail.Text = user.email;
                label_adress.Text = user.adress;
                label_spn.Text = Convert.ToString(user.phnno);

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (!textBox_uun.Text.Equals("") & !textBox_uuemail.Text.Equals("") & !textBox_uuadress.Text.Equals("") & !textBox_uupn.Text.Equals(""))
                {

                    var user = db.User.FirstOrDefault(x => x.uusername == UserLogin.uuserName);
                    user.name = Convert.ToString(textBox_uun.Text);
                    user.email = Convert.ToString(textBox_uuemail.Text);
                    user.adress = Convert.ToString(textBox_uuadress.Text);
                    //  j = Convert.ToString(textpna);
                    user.phnno = Convert.ToInt32(textBox_uupn.Text);

                    // List<Admin> results = (from p in db.Admin.FirstOrDefault(x => x.username == AdminLogin.userName)
                    //              where
                    //             select p).ToList();



                    db.SaveChanges();
                    MessageBox.Show("Information Updated.\nPlease refresh the page.");
                }
                else
                {
                    MessageBox.Show("Please Fill Up all the details");
                }
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }

        private void btn_u_chng_pas_Click(object sender, EventArgs e)
        {
            try
            {
                var user = db.User.FirstOrDefault(x => x.uusername == UserLogin.uuserName);

                if (!textBox_upas.Text.Equals(""))
                {
                    if (textBox_upas.Text == textBox_ucfrm_pas.Text)
                    {

                        user.password = textBox_upas.Text;
                        db.SaveChanges();
                        MessageBox.Show("Password Updated.");
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

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                //  TableName.where(x => x.Id == findId).FirstOrDefult();
                var bus_detais_show = db.AddBus.Where(x => x.time == comboBox_time.Text).ToList(); 
                dataGridView_ubusinfo.DataSource = bus_detais_show;

            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            try
            {
                var bus_details = (from x in db.AddBus select x).ToList();
                dataGridView_ubusinfo.DataSource = bus_details;
                //   dataGridView_admin.DataBindings();
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

        private void btnGoToBus_Click(object sender, EventArgs e)
        {
            //var seat_id = (from x in db.seat select x.serielnumber_fk).SingleOrDefault();
            try
            {
                int i;
                i = Convert.ToInt32(txtBusSerialNo.Text);

                var user = db.seat.SingleOrDefault(x => x.serielnumber_fk.Equals(i));
                if (user != null)
                {

                    SerielNumber = txtBusSerialNo.Text;
                    var frmBusSeat = new aBusSeat(false);
                    frmBusSeat.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Please Input a valid Seriel number");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
               

        }
            

    }
}

