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
using System.IO;


namespace BusTicketUi
{

    public partial class AdminAcc : Form
    {
        BusTicketDb db = new BusTicketDb();
        int mov;
        int movX;
        int movY;

        // public void InsertOnSubmit (TEntity entity);
        public static string SerielNumber { get; set; }
        public AdminAcc()
        {
            InitializeComponent();

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void AdminAcc_Load(object sender, EventArgs e)
        {
            try
            {
                var user = db.Admin.FirstOrDefault(x => x.username == AdminLogin.userName);
                lusername.Text = user.username;
                lan.Text = user.name;
                lemail.Text = user.email;
                ladress.Text = user.adress;
                lphn.Text = Convert.ToString(user.phnno);

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

        private void button4_Click(object sender, EventArgs e)
        {
            MainLogin j = new MainLogin();
            j.Show();
            this.Hide();
        }

        private void name_click(object sender, EventArgs e)
        {
            textname.Clear();
        }

        private void textemail_clk(object sender, EventArgs e)
        {
            textemail.Clear();
        }

        private void texxtadress_clk(object sender, EventArgs e)
        {
            textadress.Clear();
        }

        private void textpna_clk(object sender, EventArgs e)
        {
            textpna.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // string j;
            try
            {
                var user = db.Admin.FirstOrDefault(x => x.username == AdminLogin.userName);
                if (!textname.Text.Equals("") & !textemail.Text.Equals("") & !textadress.Text.Equals("") & !textpna.Text.Equals(""))
                {
                    user.name = Convert.ToString(textname.Text);
                    user.email = Convert.ToString(textemail.Text);
                    user.adress = Convert.ToString(textadress.Text);

                    user.phnno = Convert.ToInt32(textpna.Text);

                    // List<Admin> results = (from p in db.Admin.FirstOrDefault(x => x.username == AdminLogin.userName)
                    //              where
                    //             select p).ToList();



                    db.SaveChanges();
                    MessageBox.Show("Information Updated.\nPlease refresh the page.");
                }
                else
                {
                    MessageBox.Show("Please full up all the details");
                }

            }



            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }


        }

        private void refresh_Click(object sender, EventArgs e)
        {
            try
            {
                var user = db.Admin.FirstOrDefault(x => x.username == AdminLogin.userName);
                lusername.Text = user.username;
                lan.Text = user.name;
                lemail.Text = user.email;
                ladress.Text = user.adress;
                lphn.Text = Convert.ToString(user.phnno);

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }

        }



        private void textBox6_SN_clk(object sender, EventArgs e)
        {
            textBox6_SN.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            { 
                
                    AddBus a = new AddBus();
                    a.BusId = Convert.ToInt32(textBox6_SN.Text);
                    a.date = dateTimePicker1.Value;
                    a.time = Convert.ToString(comboBox_time.SelectedItem);
                    a.from = Convert.ToString(comboBox_from.SelectedItem);
                    a.to = Convert.ToString(comboBox_to.SelectedItem);


                    db.AddBus.Add(a);

                    seat s = new seat();
                    s.Id = s.serielnumber_fk = Convert.ToInt32(textBox6_SN.Text);
                    s.uusername_fk = AdminLogin.userName;
                    s.a1 = s.a2 = s.a3 = s.a4 = s.b1 = s.b2 = s.b3 = s.b4 = s.c1 = s.c2 = s.c3 = 0;
                    s.c4 = s.d1 = s.d2 = s.d3 = s.d4 = s.e1 = s.e2 = s.e3 = s.e4 = 0;
                    s.ConfirmStat = false;

                    db.seat.Add(s);

                    db.SaveChanges();

                    MessageBox.Show("Bus Added.\nSeat Added");
                

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }

        private void btn_chng_pas_clk(object sender, EventArgs e)
        {
            try
            {
                var user = db.Admin.FirstOrDefault(x => x.username == AdminLogin.userName);

                if (!textBox_pas.Text.Equals(""))
                {
                    if (textBox_pas.Text == textBox_cfrm_pas.Text)
                    {

                        user.password = textBox_pas.Text;
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

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                var admin_details = (from x in db.Admin select x).ToList();
                dataGridView_admin.DataSource = admin_details;
                //   dataGridView_admin.DataBindings();
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
                var user = db.Admin.FirstOrDefault(x => x.username == AdminLogin.userName);

                if (user.username == dataGridView_admin.SelectedColumns.ToString())
                {
                    MessageBox.Show("You can not delete your self");
                }
                else
                {
                    user = db.Admin.FirstOrDefault(x => x.username == dataGridView_admin.SelectedColumns.ToString());
                    db.Admin.Remove(user);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                var admin_details = (from x in db.Admin select x).ToList();
                dataGridView_admin.DataSource = admin_details;
                //   dataGridView_admin.DataBindings();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }

        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                Admin a = new Admin();
                if (!textBox_acun.Text.Equals("") & !textBox_acname.Text.Equals("")
                    & !textBox_acemail.Text.Equals("") & !textBox_acadress.Text.Equals("")
                    & !textBox_acphnno.Text.Equals("") & !textBox_acp.Text.Equals(""))
                {


                    a.username = Convert.ToString(textBox_acun.Text);
                    a.name = Convert.ToString(textBox_acname.Text);
                    a.email = Convert.ToString(textBox_acemail.Text);
                    a.adress = Convert.ToString(textBox_acadress.Text);
                    a.phnno = Convert.ToInt32(textBox_acphnno.Text);
                    
                    if (textBox_acp.Text == textBox_accp.Text)
                    {

                        a.password = textBox_acp.Text;
                        db.Admin.Add(a);
                        db.SaveChanges();
                        MessageBox.Show("Admin added");

                    }
                    else
                    {
                        MessageBox.Show("Password do not match");
                    }
                 }
                    
                
                else
                {
                    MessageBox.Show("Please fill up all the info");
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }


        }
    

            
        

        private void textBox_acun_clk(object sender, EventArgs e)
        {
            textBox_acun.Clear();
        }

        private void textBox_acname_clk(object sender, EventArgs e)
        {
            textBox_acname.Clear();
        }

        private void textBox_acp_clk(object sender, EventArgs e)
        {
            textBox_acp.Clear();
        }

        private void textBox_accp_clk(object sender, EventArgs e)
        {
            textBox_accp.Clear();
        }

        private void textBox_acemail_clk(object sender, EventArgs e)
        {
            textBox_acemail.Clear();
        }

        private void textBox_acadress_clk(object sender, EventArgs e)
        {
            textBox_acadress.Clear();
        }

        private void textBox_acphnno_clk(object sender, EventArgs e)
        {
            textBox_acphnno.Clear();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                var bus_details = (from x in db.AddBus select x).ToList();
                dataGridView_bus.DataSource = bus_details;
                //   dataGridView_admin.DataBindings();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                var bus_details = (from x in db.AddBus select x).ToList();
                dataGridView_bus.DataSource = bus_details;
                //   dataGridView_admin.DataBindings();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }

        private void textBox_cfrm_pas_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox_pas_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

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
            int i;
            i = Convert.ToInt32(txtBusSerialNo.Text);
            try
            {
                 var user = db.seat.SingleOrDefault(x => x.serielnumber_fk.Equals(i) );
                if (user != null)
                {
                    SerielNumber = txtBusSerialNo.Text;
                    var frmBusSeat = new aBusSeat(true);
                    frmBusSeat.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Please Input a valid Seriel number");
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
            // txtBusSerialNo
            //txtBusSerialNo.Text;
        }

        private void admin_row_removed(object sender, DataGridViewRowsRemovedEventArgs e)
        {

        }

        private void button_dlt_Click(object sender, EventArgs e)
        {
            try
            {
                string j = textBox_dltadmin.Text;

                var a = db.Admin.SingleOrDefault(x => x.username == j);
                if (a != null  )
                {
                    if (j != AdminLogin.userName)
                    {

                        db.Admin.Remove(a);
                        db.SaveChanges();
                        MessageBox.Show("Admin deleted.\nPlease refresh the page");
                    }
                    else
                    {
                        MessageBox.Show("You can not delete yourself");
                    }
                }
                else
                {
                    MessageBox.Show("Please give the correct username");
                }
                
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }
    }
}
