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
    public partial class aBusSeat : Form
    {
        BusTicketDb db = new BusTicketDb();
        int mov;
        int movX;
        int movY;
        public aBusSeat()
        {
            InitializeComponent();
        }
        public bool isAdmin { get; set; }
        public aBusSeat(bool isAdmin)
        {
            this.isAdmin = isAdmin;
            InitializeComponent();
        }
        public enum SeatBookingStatus
        {
            Unbooked=0,
            Pending=1,
            Confram=2
        }
        seat BusSeat { get; set; }
        

        private void aBusSeat_Load(object sender, EventArgs e)
        {
            if(isAdmin)
            {
                lbl_seriel_number.Text = AdminAcc.SerielNumber;
                btnBook.Hide();
            }
            else
            {
                lbl_seriel_number.Text = UserAcc.SerielNumber;
                btnConfirm.Hide();
            }
            
            UILoad();
        }

        void UILoad()
        {
            int serielnumber;
            try
            {

                if (isAdmin)
                {
                    int.TryParse(AdminAcc.SerielNumber, out serielnumber);
                }
                else
                {
                    int.TryParse(UserAcc.SerielNumber, out serielnumber);
                }



                BusSeat = db.seat.SingleOrDefault(x => x.serielnumber_fk == serielnumber);

                if (BusSeat == null)
                {
                    MessageBox.Show("Invalid Seriel Number!");
                    //this.Hide();
                }

                if (isAdmin)
                {
                    SeatColorChangeByStautsByAdmin(BusSeat);
                }
                else
                {
                    SeatColorChangeByStautsByUser(BusSeat);
                }
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
                
        }

        void SeatColorChangeByStautsByUser(seat busSeat)
        {
            try
            {
                //a1
                if (busSeat.a1 == (byte)SeatBookingStatus.Pending)
                {
                    btnA1.BackColor = Color.Yellow;
                    btnA1.Enabled = false;
                }
                else if (busSeat.a1 == (byte)SeatBookingStatus.Confram)
                {
                    btnA1.BackColor = Color.Green;
                    btnA1.Enabled = false;
                }

                //a2
                if (busSeat.a2 == (byte)SeatBookingStatus.Pending)
                {
                    btnA2.BackColor = Color.Yellow;
                    btnA2.Enabled = false;
                }
                else if (busSeat.a2 == (byte)SeatBookingStatus.Confram)
                {
                    btnA2.BackColor = Color.Green;
                    btnA2.Enabled = false;
                }

                //a3
                if (busSeat.a3 == (byte)SeatBookingStatus.Pending)
                {
                    btnA3.BackColor = Color.Yellow;
                    btnA3.Enabled = false;
                }
                else if (busSeat.a3 == (byte)SeatBookingStatus.Confram)
                {
                    btnA3.BackColor = Color.Green;
                    btnA3.Enabled = false;
                }

                //a4
                if (busSeat.a4 == (byte)SeatBookingStatus.Pending)
                {
                    btnA4.BackColor = Color.Yellow;
                    btnA4.Enabled = false;
                }
                else if (busSeat.a4 == (byte)SeatBookingStatus.Confram)
                {
                    btnA4.BackColor = Color.Green;
                    btnA4.Enabled = false;
                }

                //b1
                if (busSeat.b1 == (byte)SeatBookingStatus.Pending)
                {
                    btnB1.BackColor = Color.Yellow;
                    btnB1.Enabled = false;
                }
                else if (busSeat.b1 == (byte)SeatBookingStatus.Confram)
                {
                    btnB1.BackColor = Color.Green;
                    btnB1.Enabled = false;
                }

                //b2
                if (busSeat.b2 == (byte)SeatBookingStatus.Pending)
                {
                    btnB2.BackColor = Color.Yellow;
                    btnB2.Enabled = false;
                }
                else if (busSeat.b2 == (byte)SeatBookingStatus.Confram)
                {
                    btnB2.BackColor = Color.Green;
                    btnB2.Enabled = false;
                }

                //b3
                if (busSeat.b3 == (byte)SeatBookingStatus.Pending)
                {
                    btnB3.BackColor = Color.Yellow;
                    btnB3.Enabled = false;
                }
                else if (busSeat.b3 == (byte)SeatBookingStatus.Confram)
                {
                    btnB3.BackColor = Color.Green;
                    btnB3.Enabled = false;
                }

                //b4
                if (busSeat.b4 == (byte)SeatBookingStatus.Pending)
                {
                    btnB4.BackColor = Color.Yellow;
                    btnB4.Enabled = false;
                }
                else if (busSeat.b4 == (byte)SeatBookingStatus.Confram)
                {
                    btnB4.BackColor = Color.Green;
                    btnB4.Enabled = false;
                }

                //c1
                if (busSeat.c1 == (byte)SeatBookingStatus.Pending)
                {
                    btnC1.BackColor = Color.Yellow;
                    btnC1.Enabled = false;
                }
                else if (busSeat.c1 == (byte)SeatBookingStatus.Confram)
                {
                    btnC1.BackColor = Color.Green;
                    btnC1.Enabled = false;
                }

                //c2
                if (busSeat.c2 == (byte)SeatBookingStatus.Pending)
                {
                    btnC2.BackColor = Color.Yellow;
                    btnC2.Enabled = false;
                }
                else if (busSeat.c2 == (byte)SeatBookingStatus.Confram)
                {
                    btnC2.BackColor = Color.Green;
                    btnC2.Enabled = false;
                }

                //c3
                if (busSeat.c3 == (byte)SeatBookingStatus.Pending)
                {
                    btnC3.BackColor = Color.Yellow;
                    btnC3.Enabled = false;
                }
                else if (busSeat.c3 == (byte)SeatBookingStatus.Confram)
                {
                    btnC3.BackColor = Color.Green;
                    btnC3.Enabled = false;
                }

                //c4
                if (busSeat.c4 == (byte)SeatBookingStatus.Pending)
                {
                    btnC4.BackColor = Color.Yellow;
                    btnC4.Enabled = false;
                }
                else if (busSeat.c4 == (byte)SeatBookingStatus.Confram)
                {
                    btnC4.BackColor = Color.Green;
                    btnC4.Enabled = false;
                }

                //d1
                if (busSeat.d1 == (byte)SeatBookingStatus.Pending)
                {
                    btnD1.BackColor = Color.Yellow;
                    btnD1.Enabled = false;
                }
                else if (busSeat.d1 == (byte)SeatBookingStatus.Confram)
                {
                    btnD1.BackColor = Color.Green;
                    btnD1.Enabled = false;
                }

                //d2
                if (busSeat.d2 == (byte)SeatBookingStatus.Pending)
                {
                    btnD2.BackColor = Color.Yellow;
                    btnD2.Enabled = false;
                }
                else if (busSeat.d2 == (byte)SeatBookingStatus.Confram)
                {
                    btnD2.BackColor = Color.Green;
                    btnD2.Enabled = false;
                }

                //d3
                if (busSeat.d3 == (byte)SeatBookingStatus.Pending)
                {
                    btnD3.BackColor = Color.Yellow;
                    btnD3.Enabled = false;
                }
                else if (busSeat.d3 == (byte)SeatBookingStatus.Confram)
                {
                    btnD3.BackColor = Color.Green;
                    btnD3.Enabled = false;
                }

                //d4
                if (busSeat.d4 == (byte)SeatBookingStatus.Pending)
                {
                    btnD4.BackColor = Color.Yellow;
                    btnD4.Enabled = false;
                }
                else if (busSeat.d4 == (byte)SeatBookingStatus.Confram)
                {
                    btnD4.BackColor = Color.Green;
                    btnD4.Enabled = false;
                }

                //e1
                if (busSeat.e1 == (byte)SeatBookingStatus.Pending)
                {
                    btnE1.BackColor = Color.Yellow;
                    btnE1.Enabled = false;
                }
                else if (busSeat.e1 == (byte)SeatBookingStatus.Confram)
                {
                    btnE1.BackColor = Color.Green;
                    btnE1.Enabled = false;
                }

                //e2
                if (busSeat.e2 == (byte)SeatBookingStatus.Pending)
                {
                    btnE2.BackColor = Color.Yellow;
                    btnE2.Enabled = false;
                }
                else if (busSeat.e2 == (byte)SeatBookingStatus.Confram)
                {
                    btnE2.BackColor = Color.Green;
                    btnE2.Enabled = false;
                }

                //e3
                if (busSeat.e3 == (byte)SeatBookingStatus.Pending)
                {
                    btnE3.BackColor = Color.Yellow;
                    btnE3.Enabled = false;
                }
                else if (busSeat.e3 == (byte)SeatBookingStatus.Confram)
                {
                    btnE3.BackColor = Color.Green;
                    btnE3.Enabled = false;
                }

                //e4
                if (busSeat.e4 == (byte)SeatBookingStatus.Pending)
                {
                    btnE4.BackColor = Color.Yellow;
                    btnE4.Enabled = false;
                }
                else if (busSeat.e4 == (byte)SeatBookingStatus.Confram)
                {
                    btnE4.BackColor = Color.Green;
                    btnE4.Enabled = false;
                }
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }



        }

       void SeatColorChangeByStautsByAdmin(seat busSeat)
        {
            try
            {
                //a1
                if (busSeat.a1 == (byte)SeatBookingStatus.Pending)
                {
                    btnA1.BackColor = Color.Yellow;
                }
                else if (busSeat.a1 == (byte)SeatBookingStatus.Confram)
                {
                    btnA1.BackColor = Color.Green;
                }
                else
                {
                    btnA1.BackColor = Color.FromArgb(255, 255, 205);

                }

                //a2
                if (busSeat.a2 == (byte)SeatBookingStatus.Pending)
                {
                    btnA2.BackColor = Color.Yellow;
                }
                else if (busSeat.a2 == (byte)SeatBookingStatus.Confram)
                {
                    btnA2.BackColor = Color.Green;

                }
                else
                {
                    btnA2.BackColor = Color.FromArgb(255, 255, 205);

                }

                //a3
                if (busSeat.a3 == (byte)SeatBookingStatus.Pending)
                {
                    btnA3.BackColor = Color.Yellow;
                }
                else if (busSeat.a3 == (byte)SeatBookingStatus.Confram)
                {
                    btnA3.BackColor = Color.Green;

                }
                else
                {
                    btnA3.BackColor = Color.FromArgb(255, 255, 205);

                }

                //a4
                if (busSeat.a4 == (byte)SeatBookingStatus.Pending)
                {
                    btnA4.BackColor = Color.Yellow;
                }
                else if (busSeat.a4 == (byte)SeatBookingStatus.Confram)
                {
                    btnA4.BackColor = Color.Green;

                }
                else
                {
                    btnA4.BackColor = Color.FromArgb(255, 255, 205);

                }


                //b1
                if (busSeat.b1 == (byte)SeatBookingStatus.Pending)
                {
                    btnB1.BackColor = Color.Yellow;
                }
                else if (busSeat.b1 == (byte)SeatBookingStatus.Confram)
                {
                    btnB1.BackColor = Color.Green;

                }
                else
                {
                    btnB1.BackColor = Color.FromArgb(255, 255, 205);

                }

                //b2
                if (busSeat.b2 == (byte)SeatBookingStatus.Pending)
                {
                    btnB2.BackColor = Color.Yellow;
                }
                else if (busSeat.b2 == (byte)SeatBookingStatus.Confram)
                {
                    btnB2.BackColor = Color.Green;

                }
                else
                {
                    btnB2.BackColor = Color.FromArgb(255, 255, 205);

                }

                //b3
                if (busSeat.b3 == (byte)SeatBookingStatus.Pending)
                {
                    btnB3.BackColor = Color.Yellow;
                }
                else if (busSeat.b3 == (byte)SeatBookingStatus.Confram)
                {
                    btnB3.BackColor = Color.Green;

                }
                else
                {
                    btnB3.BackColor = Color.FromArgb(255, 255, 205);

                }

                //b4
                if (busSeat.b4 == (byte)SeatBookingStatus.Pending)
                {
                    btnB4.BackColor = Color.Yellow;
                }
                else if (busSeat.b4 == (byte)SeatBookingStatus.Confram)
                {
                    btnB4.BackColor = Color.Green;

                }
                else
                {
                    btnB4.BackColor = Color.FromArgb(255, 255, 205);

                }

                //c1
                if (busSeat.c1 == (byte)SeatBookingStatus.Pending)
                {
                    btnC1.BackColor = Color.Yellow;
                }
                else if (busSeat.c1 == (byte)SeatBookingStatus.Confram)
                {
                    btnC1.BackColor = Color.Green;

                }
                else
                {
                    btnC1.BackColor = Color.FromArgb(255, 255, 205);

                }

                //c2
                if (busSeat.c2 == (byte)SeatBookingStatus.Pending)
                {
                    btnC2.BackColor = Color.Yellow;
                }
                else if (busSeat.c2 == (byte)SeatBookingStatus.Confram)
                {
                    btnC2.BackColor = Color.Green;

                }
                else
                {
                    btnC2.BackColor = Color.FromArgb(255, 255, 205);

                }

                //c3
                if (busSeat.c3 == (byte)SeatBookingStatus.Pending)
                {
                    btnC3.BackColor = Color.Yellow;
                }
                else if (busSeat.c3 == (byte)SeatBookingStatus.Confram)
                {
                    btnC3.BackColor = Color.Green;

                }
                else
                {
                    btnC3.BackColor = Color.FromArgb(255, 255, 205);

                }

                //c4
                if (busSeat.c4 == (byte)SeatBookingStatus.Pending)
                {
                    btnC4.BackColor = Color.Yellow;
                }
                else if (busSeat.c4 == (byte)SeatBookingStatus.Confram)
                {
                    btnC4.BackColor = Color.Green;

                }
                else
                {
                    btnC4.BackColor = Color.FromArgb(255, 255, 205);

                }

                //d1
                if (busSeat.d1 == (byte)SeatBookingStatus.Pending)
                {
                    btnD1.BackColor = Color.Yellow;
                }
                else if (busSeat.d1 == (byte)SeatBookingStatus.Confram)
                {
                    btnD1.BackColor = Color.Green;

                }
                else
                {
                    btnD1.BackColor = Color.FromArgb(255, 255, 205);

                }

                //d2
                if (busSeat.d2 == (byte)SeatBookingStatus.Pending)
                {
                    btnD2.BackColor = Color.Yellow;
                }
                else if (busSeat.d2 == (byte)SeatBookingStatus.Confram)
                {
                    btnD2.BackColor = Color.Green;

                }
                else
                {
                    btnD2.BackColor = Color.FromArgb(255, 255, 205);

                }

                //d3
                if (busSeat.d3 == (byte)SeatBookingStatus.Pending)
                {
                    btnD3.BackColor = Color.Yellow;
                }
                else if (busSeat.d3 == (byte)SeatBookingStatus.Confram)
                {
                    btnD3.BackColor = Color.Green;

                }
                else
                {
                    btnD3.BackColor = Color.FromArgb(255, 255, 205);

                }

                //d4
                if (busSeat.d4 == (byte)SeatBookingStatus.Pending)
                {
                    btnD4.BackColor = Color.Yellow;
                }
                else if (busSeat.d4 == (byte)SeatBookingStatus.Confram)
                {
                    btnD4.BackColor = Color.Green;

                }
                else
                {
                    btnD4.BackColor = Color.FromArgb(255, 255, 205);

                }

                //e1
                if (busSeat.e1 == (byte)SeatBookingStatus.Pending)
                {
                    btnE1.BackColor = Color.Yellow;
                }
                else if (busSeat.e1 == (byte)SeatBookingStatus.Confram)
                {
                    btnE1.BackColor = Color.Green;

                }
                else
                {
                    btnE1.BackColor = Color.FromArgb(255, 255, 205);

                }

                //e2
                if (busSeat.e2 == (byte)SeatBookingStatus.Pending)
                {
                    btnE2.BackColor = Color.Yellow;
                }
                else if (busSeat.e2 == (byte)SeatBookingStatus.Confram)
                {
                    btnE2.BackColor = Color.Green;

                }
                else
                {
                    btnE2.BackColor = Color.FromArgb(255, 255, 205);

                }

                //e3
                if (busSeat.e3 == (byte)SeatBookingStatus.Pending)
                {
                    btnE3.BackColor = Color.Yellow;
                }
                else if (busSeat.e3 == (byte)SeatBookingStatus.Confram)
                {
                    btnE3.BackColor = Color.Green;

                }
                else
                {
                    btnE3.BackColor = Color.FromArgb(255, 255, 205);

                }

                //e4
                if (busSeat.e4 == (byte)SeatBookingStatus.Pending)
                {
                    btnE4.BackColor = Color.Yellow;
                }
                else if (busSeat.e4 == (byte)SeatBookingStatus.Confram)
                {
                    btnE4.BackColor = Color.Green;

                }
                else
                {
                    btnE4.BackColor = Color.FromArgb(255, 255, 205);

                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }

        }
        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
        private void btnA1_Click(object sender, EventArgs e)
        {
            seat busSeat = BusSeat;
            //a1
            try
            {
                if (this.isAdmin)
                {
                    //a1
                    if (busSeat.a1 == (byte)SeatBookingStatus.Confram)
                    {
                        btnA1.BackColor = Color.FromArgb(255, 255, 205);
                        busSeat.a1 = (byte)SeatBookingStatus.Unbooked;
                    }
                    else if (busSeat.a1 == (byte)SeatBookingStatus.Unbooked)
                    {
                        btnA1.BackColor = Color.Yellow;
                        busSeat.a1 = (byte)SeatBookingStatus.Pending;
                    }
                    else if (busSeat.a1 == (byte)SeatBookingStatus.Pending)
                    {
                        btnA1.BackColor = Color.Green;
                        busSeat.a1 = (byte)SeatBookingStatus.Confram;
                    }
                }
                else
                {
                    if (busSeat.a1 == (byte)SeatBookingStatus.Unbooked)
                    {
                        btnA1.BackColor = Color.Yellow;
                        busSeat.a1 = (byte)SeatBookingStatus.Pending;
                    }
                    else if (busSeat.a1 == (byte)SeatBookingStatus.Pending)
                    {
                        btnA1.BackColor = Color.FromArgb(255, 255, 205);
                        busSeat.a1 = (byte)SeatBookingStatus.Unbooked;
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }

            //MapSeatStatusByAdmin();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                db.SaveChanges();
                UILoad();
                MessageBox.Show("Confirmed Succesfully");
                var a = new AdminAcc();
                a.Show();
                this.Hide();
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }

        private void btnA2_Click(object sender, EventArgs e)
        {
            seat busSeat = BusSeat;
            //a2
            try
            {


                if (this.isAdmin)
                {
                    if (busSeat.a2 == (byte)SeatBookingStatus.Confram)
                    {
                        btnA2.BackColor = Color.FromArgb(255, 255, 205);
                        busSeat.a2 = (byte)SeatBookingStatus.Unbooked;
                    }
                    else if (busSeat.a2 == (byte)SeatBookingStatus.Unbooked)
                    {
                        btnA2.BackColor = Color.Yellow;
                        busSeat.a2 = (byte)SeatBookingStatus.Pending;
                    }
                    else if (busSeat.a2 == (byte)SeatBookingStatus.Pending)
                    {
                        btnA2.BackColor = Color.Green;
                        busSeat.a2 = (byte)SeatBookingStatus.Confram;
                    }
                }
                else
                {
                    if (busSeat.a2 == (byte)SeatBookingStatus.Unbooked)
                    {
                        btnA2.BackColor = Color.Yellow;
                        busSeat.a2 = (byte)SeatBookingStatus.Pending;
                    }
                    else if (busSeat.a2 == (byte)SeatBookingStatus.Pending)
                    {
                        btnA2.BackColor = Color.FromArgb(255, 255, 205);
                        busSeat.a2 = (byte)SeatBookingStatus.Unbooked;
                    }

                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }

        }

        private void btnA3_Click(object sender, EventArgs e)
        {
            seat busSeat = BusSeat;
            //a3
            try
            {
                if (this.isAdmin)
                {
                    if (busSeat.a3 == (byte)SeatBookingStatus.Confram)
                    {
                        btnA3.BackColor = Color.FromArgb(255, 255, 205);
                        busSeat.a3 = (byte)SeatBookingStatus.Unbooked;
                    }
                    else if (busSeat.a3 == (byte)SeatBookingStatus.Unbooked)
                    {
                        btnA3.BackColor = Color.Yellow;
                        busSeat.a3 = (byte)SeatBookingStatus.Pending;
                    }
                    else if (busSeat.a3 == (byte)SeatBookingStatus.Pending)
                    {
                        btnA3.BackColor = Color.Green;
                        busSeat.a3 = (byte)SeatBookingStatus.Confram;
                    }
                }
                else
                {
                    if (busSeat.a3 == (byte)SeatBookingStatus.Unbooked)
                    {
                        btnA3.BackColor = Color.Yellow;
                        busSeat.a3 = (byte)SeatBookingStatus.Pending;
                    }
                    else if (busSeat.a3 == (byte)SeatBookingStatus.Pending)
                    {
                        btnA3.BackColor = Color.FromArgb(255, 255, 205);
                        busSeat.a3 = (byte)SeatBookingStatus.Unbooked;
                    }

                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }

        private void btnA4_Click(object sender, EventArgs e)
        {
            seat busSeat = BusSeat;
            //a4
            try
            {
                if (this.isAdmin)
                {
                    if (busSeat.a4 == (byte)SeatBookingStatus.Confram)
                    {
                        btnA4.BackColor = Color.FromArgb(255, 255, 205);
                        busSeat.a4 = (byte)SeatBookingStatus.Unbooked;
                    }
                    else if (busSeat.a4 == (byte)SeatBookingStatus.Unbooked)
                    {
                        btnA4.BackColor = Color.Yellow;
                        busSeat.a4 = (byte)SeatBookingStatus.Pending;
                    }
                    else if (busSeat.a4 == (byte)SeatBookingStatus.Pending)
                    {
                        btnA4.BackColor = Color.Green;
                        busSeat.a4 = (byte)SeatBookingStatus.Confram;
                    }
                }
                else
                {
                    if (busSeat.a4 == (byte)SeatBookingStatus.Unbooked)
                    {
                        btnA4.BackColor = Color.Yellow;
                        busSeat.a4 = (byte)SeatBookingStatus.Pending;
                    }
                    else if (busSeat.a4 == (byte)SeatBookingStatus.Pending)
                    {
                        btnA4.BackColor = Color.FromArgb(255, 255, 205);
                        busSeat.a4 = (byte)SeatBookingStatus.Unbooked;
                    }

                }
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }

        private void btnB1_Click(object sender, EventArgs e)
        {
            seat busSeat = BusSeat;
            //b1
            try
            {
                if (this.isAdmin)
                {
                    if (busSeat.b1 == (byte)SeatBookingStatus.Confram)
                    {
                        btnB1.BackColor = Color.FromArgb(255, 255, 205);
                        busSeat.b1 = (byte)SeatBookingStatus.Unbooked;
                    }
                    else if (busSeat.b1 == (byte)SeatBookingStatus.Unbooked)
                    {
                        btnB1.BackColor = Color.Yellow;
                        busSeat.b1 = (byte)SeatBookingStatus.Pending;
                    }
                    else if (busSeat.b1 == (byte)SeatBookingStatus.Pending)
                    {
                        btnB1.BackColor = Color.Green;
                        busSeat.b1 = (byte)SeatBookingStatus.Confram;
                    }
                }
                else
                {
                    if (busSeat.b1 == (byte)SeatBookingStatus.Unbooked)
                    {
                        btnB1.BackColor = Color.Yellow;
                        busSeat.b1 = (byte)SeatBookingStatus.Pending;
                    }
                    else if (busSeat.b1 == (byte)SeatBookingStatus.Pending)
                    {
                        btnB1.BackColor = Color.FromArgb(255, 255, 205);
                        busSeat.b1 = (byte)SeatBookingStatus.Unbooked;
                    }

                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }

        private void btnB2_Click(object sender, EventArgs e)
        {
            seat busSeat = BusSeat;
            //b2
            try
            {
                if (this.isAdmin)
                {
                    if (busSeat.b2 == (byte)SeatBookingStatus.Confram)
                    {
                        btnB2.BackColor = Color.FromArgb(255, 255, 205);
                        busSeat.b2 = (byte)SeatBookingStatus.Unbooked;
                    }
                    else if (busSeat.b2 == (byte)SeatBookingStatus.Unbooked)
                    {
                        btnB2.BackColor = Color.Yellow;
                        busSeat.b2 = (byte)SeatBookingStatus.Pending;
                    }
                    else if (busSeat.b2 == (byte)SeatBookingStatus.Pending)
                    {
                        btnB2.BackColor = Color.Green;
                        busSeat.b2 = (byte)SeatBookingStatus.Confram;
                    }
                }
                else
                {
                    if (busSeat.b2 == (byte)SeatBookingStatus.Unbooked)
                    {
                        btnB2.BackColor = Color.Yellow;
                        busSeat.b2 = (byte)SeatBookingStatus.Pending;
                    }
                    else if (busSeat.b2 == (byte)SeatBookingStatus.Pending)
                    {
                        btnB2.BackColor = Color.FromArgb(255, 255, 205);
                        busSeat.b2 = (byte)SeatBookingStatus.Unbooked;
                    }

                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }

        private void btnB3_Click(object sender, EventArgs e)
        {
            seat busSeat = BusSeat;
            //b3
            try
            {
                if (this.isAdmin)
                {
                    if (busSeat.b3 == (byte)SeatBookingStatus.Confram)
                    {
                        btnB3.BackColor = Color.FromArgb(255, 255, 205);
                        busSeat.b3 = (byte)SeatBookingStatus.Unbooked;
                    }
                    else if (busSeat.b3 == (byte)SeatBookingStatus.Unbooked)
                    {
                        btnB3.BackColor = Color.Yellow;
                        busSeat.b3 = (byte)SeatBookingStatus.Pending;
                    }
                    else if (busSeat.b3 == (byte)SeatBookingStatus.Pending)
                    {
                        btnB3.BackColor = Color.Green;
                        busSeat.b3 = (byte)SeatBookingStatus.Confram;
                    }
                }
                else
                {
                    if (busSeat.b3 == (byte)SeatBookingStatus.Unbooked)
                    {
                        btnB3.BackColor = Color.Yellow;
                        busSeat.b3 = (byte)SeatBookingStatus.Pending;
                    }
                    else if (busSeat.b3 == (byte)SeatBookingStatus.Pending)
                    {
                        btnB3.BackColor = Color.FromArgb(255, 255, 205);
                        busSeat.b3 = (byte)SeatBookingStatus.Unbooked;
                    }

                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }

        private void btnB4_Click(object sender, EventArgs e)
        {
            seat busSeat = BusSeat;
            //b4
            try
            {
                if (this.isAdmin)
                {
                    if (busSeat.b4 == (byte)SeatBookingStatus.Confram)
                    {
                        btnB4.BackColor = Color.FromArgb(255, 255, 205);
                        busSeat.b4 = (byte)SeatBookingStatus.Unbooked;
                    }
                    else if (busSeat.b4 == (byte)SeatBookingStatus.Unbooked)
                    {
                        btnB4.BackColor = Color.Yellow;
                        busSeat.b4 = (byte)SeatBookingStatus.Pending;
                    }
                    else if (busSeat.b4 == (byte)SeatBookingStatus.Pending)
                    {
                        btnB4.BackColor = Color.Green;
                        busSeat.b4 = (byte)SeatBookingStatus.Confram;
                    }
                }
                else
                {
                    if (busSeat.b4 == (byte)SeatBookingStatus.Unbooked)
                    {
                        btnB4.BackColor = Color.Yellow;
                        busSeat.b4 = (byte)SeatBookingStatus.Pending;
                    }
                    else if (busSeat.b4 == (byte)SeatBookingStatus.Pending)
                    {
                        btnB4.BackColor = Color.FromArgb(255, 255, 205);
                        busSeat.b4 = (byte)SeatBookingStatus.Unbooked;
                    }

                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }

        private void btnC1_Click(object sender, EventArgs e)
        {
            seat busSeat = BusSeat;
            //C1
            try
            {
                if (this.isAdmin)
                {
                    if (busSeat.c1 == (byte)SeatBookingStatus.Confram)
                    {
                        btnC1.BackColor = Color.FromArgb(255, 255, 205);
                        busSeat.c1 = (byte)SeatBookingStatus.Unbooked;
                    }
                    else if (busSeat.c1 == (byte)SeatBookingStatus.Unbooked)
                    {
                        btnC1.BackColor = Color.Yellow;
                        busSeat.c1 = (byte)SeatBookingStatus.Pending;
                    }
                    else if (busSeat.c1 == (byte)SeatBookingStatus.Pending)
                    {
                        btnC1.BackColor = Color.Green;
                        busSeat.c1 = (byte)SeatBookingStatus.Confram;
                    }
                }
                else
                {
                    if (busSeat.c1 == (byte)SeatBookingStatus.Unbooked)
                    {
                        btnC1.BackColor = Color.Yellow;
                        busSeat.c1 = (byte)SeatBookingStatus.Pending;
                    }
                    else if (busSeat.c1 == (byte)SeatBookingStatus.Pending)
                    {
                        btnC1.BackColor = Color.FromArgb(255, 255, 205);
                        busSeat.c1 = (byte)SeatBookingStatus.Unbooked;
                    }

                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }

        private void btnC2_Click(object sender, EventArgs e)
        {
            seat busSeat = BusSeat;
            //C2
            try
            {
                if (this.isAdmin)
                {
                    if (busSeat.c2 == (byte)SeatBookingStatus.Confram)
                    {
                        btnC2.BackColor = Color.FromArgb(255, 255, 205);
                        busSeat.c2 = (byte)SeatBookingStatus.Unbooked;
                    }
                    else if (busSeat.c2 == (byte)SeatBookingStatus.Unbooked)
                    {
                        btnC2.BackColor = Color.Yellow;
                        busSeat.c2 = (byte)SeatBookingStatus.Pending;
                    }
                    else if (busSeat.c2 == (byte)SeatBookingStatus.Pending)
                    {
                        btnC2.BackColor = Color.Green;
                        busSeat.c2 = (byte)SeatBookingStatus.Confram;
                    }
                }
                else
                {
                    if (busSeat.c2 == (byte)SeatBookingStatus.Unbooked)
                    {
                        btnC2.BackColor = Color.Yellow;
                        busSeat.c2 = (byte)SeatBookingStatus.Pending;
                    }
                    else if (busSeat.c2 == (byte)SeatBookingStatus.Pending)
                    {
                        btnC2.BackColor = Color.FromArgb(255, 255, 205);
                        busSeat.c2 = (byte)SeatBookingStatus.Unbooked;
                    }

                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }

        private void btnC3_Click(object sender, EventArgs e)
        {
            seat busSeat = BusSeat;
            //C3
            try
            {
                if (this.isAdmin)
                {
                    if (busSeat.c3 == (byte)SeatBookingStatus.Confram)
                    {
                        btnC3.BackColor = Color.FromArgb(255, 255, 205);
                        busSeat.c3 = (byte)SeatBookingStatus.Unbooked;
                    }
                    else if (busSeat.c3 == (byte)SeatBookingStatus.Unbooked)
                    {
                        btnC3.BackColor = Color.Yellow;
                        busSeat.c3 = (byte)SeatBookingStatus.Pending;
                    }
                    else if (busSeat.c3 == (byte)SeatBookingStatus.Pending)
                    {
                        btnC3.BackColor = Color.Green;
                        busSeat.c3 = (byte)SeatBookingStatus.Confram;
                    }
                }
                else
                {
                    if (busSeat.c3 == (byte)SeatBookingStatus.Unbooked)
                    {
                        btnC3.BackColor = Color.Yellow;
                        busSeat.c3 = (byte)SeatBookingStatus.Pending;
                    }
                    else if (busSeat.c3 == (byte)SeatBookingStatus.Pending)
                    {
                        btnC3.BackColor = Color.FromArgb(255, 255, 205);
                        busSeat.c3 = (byte)SeatBookingStatus.Unbooked;
                    }

                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }

        private void btnC4_Click(object sender, EventArgs e)
        {
            seat busSeat = BusSeat;
            //C4
            try
            {
                if (this.isAdmin)
                {
                    if (busSeat.c4 == (byte)SeatBookingStatus.Confram)
                    {
                        btnC4.BackColor = Color.FromArgb(255, 255, 205);
                        busSeat.c4 = (byte)SeatBookingStatus.Unbooked;
                    }
                    else if (busSeat.c4 == (byte)SeatBookingStatus.Unbooked)
                    {
                        btnC4.BackColor = Color.Yellow;
                        busSeat.c4 = (byte)SeatBookingStatus.Pending;
                    }
                    else if (busSeat.c4 == (byte)SeatBookingStatus.Pending)
                    {
                        btnC4.BackColor = Color.Green;
                        busSeat.c4 = (byte)SeatBookingStatus.Confram;
                    }
                }
                else
                {
                    if (busSeat.c4 == (byte)SeatBookingStatus.Unbooked)
                    {
                        btnC4.BackColor = Color.Yellow;
                        busSeat.c4 = (byte)SeatBookingStatus.Pending;
                    }
                    else if (busSeat.c4 == (byte)SeatBookingStatus.Pending)
                    {
                        btnC4.BackColor = Color.FromArgb(255, 255, 205);
                        busSeat.c4 = (byte)SeatBookingStatus.Unbooked;
                    }

                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }

        private void btnD1_Click(object sender, EventArgs e)
        {
            seat busSeat = BusSeat;
            //d1
            try
            {
                if (this.isAdmin)
                {
                    if (busSeat.d1 == (byte)SeatBookingStatus.Confram)
                    {
                        btnD1.BackColor = Color.FromArgb(255, 255, 205);
                        busSeat.d1 = (byte)SeatBookingStatus.Unbooked;
                    }
                    else if (busSeat.d1 == (byte)SeatBookingStatus.Unbooked)
                    {
                        btnD1.BackColor = Color.Yellow;
                        busSeat.d1 = (byte)SeatBookingStatus.Pending;
                    }
                    else if (busSeat.d1 == (byte)SeatBookingStatus.Pending)
                    {
                        btnD1.BackColor = Color.Green;
                        busSeat.d1 = (byte)SeatBookingStatus.Confram;
                    }
                }
                else
                {
                    if (busSeat.d1 == (byte)SeatBookingStatus.Unbooked)
                    {
                        btnD1.BackColor = Color.Yellow;
                        busSeat.d1 = (byte)SeatBookingStatus.Pending;
                    }
                    else if (busSeat.d1 == (byte)SeatBookingStatus.Pending)
                    {
                        btnD1.BackColor = Color.FromArgb(255, 255, 205);
                        busSeat.d1 = (byte)SeatBookingStatus.Unbooked;
                    }

                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }

        private void btnD2_Click(object sender, EventArgs e)
        {
            seat busSeat = BusSeat;
            //d2
            try
            {
                if (this.isAdmin)
                {
                    if (busSeat.d2 == (byte)SeatBookingStatus.Confram)
                    {
                        btnD2.BackColor = Color.FromArgb(255, 255, 205);
                        busSeat.d2 = (byte)SeatBookingStatus.Unbooked;
                    }
                    else if (busSeat.d2 == (byte)SeatBookingStatus.Unbooked)
                    {
                        btnD2.BackColor = Color.Yellow;
                        busSeat.d2 = (byte)SeatBookingStatus.Pending;
                    }
                    else if (busSeat.d2 == (byte)SeatBookingStatus.Pending)
                    {
                        btnD2.BackColor = Color.Green;
                        busSeat.d2 = (byte)SeatBookingStatus.Confram;
                    }
                }
                else
                {
                    if (busSeat.d2 == (byte)SeatBookingStatus.Unbooked)
                    {
                        btnD2.BackColor = Color.Yellow;
                        busSeat.d2 = (byte)SeatBookingStatus.Pending;
                    }
                    else if (busSeat.d2 == (byte)SeatBookingStatus.Pending)
                    {
                        btnD2.BackColor = Color.FromArgb(255, 255, 205);
                        busSeat.d2 = (byte)SeatBookingStatus.Unbooked;
                    }

                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }

        private void btnD3_Click(object sender, EventArgs e)
        {
            seat busSeat = BusSeat;
            //d3
            try
            {
                if (this.isAdmin)
                {
                    if (busSeat.d3 == (byte)SeatBookingStatus.Confram)
                    {
                        btnD3.BackColor = Color.FromArgb(255, 255, 205);
                        busSeat.d3 = (byte)SeatBookingStatus.Unbooked;
                    }
                    else if (busSeat.d3 == (byte)SeatBookingStatus.Unbooked)
                    {
                        btnD3.BackColor = Color.Yellow;
                        busSeat.d3 = (byte)SeatBookingStatus.Pending;
                    }
                    else if (busSeat.d3 == (byte)SeatBookingStatus.Pending)
                    {
                        btnD3.BackColor = Color.Green;
                        busSeat.d3 = (byte)SeatBookingStatus.Confram;
                    }
                }
                else
                {
                    if (busSeat.d3 == (byte)SeatBookingStatus.Unbooked)
                    {
                        btnD3.BackColor = Color.Yellow;
                        busSeat.d3 = (byte)SeatBookingStatus.Pending;
                    }
                    else if (busSeat.d3 == (byte)SeatBookingStatus.Pending)
                    {
                        btnD3.BackColor = Color.FromArgb(255, 255, 205);
                        busSeat.d3 = (byte)SeatBookingStatus.Unbooked;
                    }

                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }

        private void btnD4_Click(object sender, EventArgs e)
        {
            seat busSeat = BusSeat;
            //d4
            try
            {
                if (this.isAdmin)
                {
                    if (busSeat.d4 == (byte)SeatBookingStatus.Confram)
                    {
                        btnD4.BackColor = Color.FromArgb(255, 255, 205);
                        busSeat.d4 = (byte)SeatBookingStatus.Unbooked;
                    }
                    else if (busSeat.d4 == (byte)SeatBookingStatus.Unbooked)
                    {
                        btnD4.BackColor = Color.Yellow;
                        busSeat.d4 = (byte)SeatBookingStatus.Pending;
                    }
                    else if (busSeat.d4 == (byte)SeatBookingStatus.Pending)
                    {
                        btnD4.BackColor = Color.Green;
                        busSeat.d4 = (byte)SeatBookingStatus.Confram;
                    }
                }
                else
                {
                    if (busSeat.d4 == (byte)SeatBookingStatus.Unbooked)
                    {
                        btnD4.BackColor = Color.Yellow;
                        busSeat.d4 = (byte)SeatBookingStatus.Pending;
                    }
                    else if (busSeat.d4 == (byte)SeatBookingStatus.Pending)
                    {
                        btnD4.BackColor = Color.FromArgb(255, 255, 205);
                        busSeat.d4 = (byte)SeatBookingStatus.Unbooked;
                    }

                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }

        private void btnE1_Click(object sender, EventArgs e)
        {

            seat busSeat = BusSeat;
            //e1
            try
            {
                if (this.isAdmin)
                {
                    if (busSeat.e1 == (byte)SeatBookingStatus.Confram)
                    {
                        btnE1.BackColor = Color.FromArgb(255, 255, 205);
                        busSeat.e1 = (byte)SeatBookingStatus.Unbooked;
                    }
                    else if (busSeat.e1 == (byte)SeatBookingStatus.Unbooked)
                    {
                        btnE1.BackColor = Color.Yellow;
                        busSeat.e1 = (byte)SeatBookingStatus.Pending;
                    }
                    else if (busSeat.e1 == (byte)SeatBookingStatus.Pending)
                    {
                        btnE1.BackColor = Color.Green;
                        busSeat.e1 = (byte)SeatBookingStatus.Confram;
                    }
                }
                else
                {
                    if (busSeat.e1 == (byte)SeatBookingStatus.Unbooked)
                    {
                        btnE1.BackColor = Color.Yellow;
                        busSeat.e1 = (byte)SeatBookingStatus.Pending;
                    }
                    else if (busSeat.e1 == (byte)SeatBookingStatus.Pending)
                    {
                        btnE1.BackColor = Color.FromArgb(255, 255, 205);
                        busSeat.e1 = (byte)SeatBookingStatus.Unbooked;
                    }

                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }

        private void btnE2_Click(object sender, EventArgs e)
        {
            seat busSeat = BusSeat;
            //e2
            try
            {
                if (this.isAdmin)
                {
                    if (busSeat.e2 == (byte)SeatBookingStatus.Confram)
                    {
                        btnE2.BackColor = Color.FromArgb(255, 255, 205);
                        busSeat.e2 = (byte)SeatBookingStatus.Unbooked;
                    }
                    else if (busSeat.e2 == (byte)SeatBookingStatus.Unbooked)
                    {
                        btnE2.BackColor = Color.Yellow;
                        busSeat.e2 = (byte)SeatBookingStatus.Pending;
                    }
                    else if (busSeat.e2 == (byte)SeatBookingStatus.Pending)
                    {
                        btnE2.BackColor = Color.Green;
                        busSeat.e2 = (byte)SeatBookingStatus.Confram;
                    }
                }
                else
                {
                    if (busSeat.e2 == (byte)SeatBookingStatus.Unbooked)
                    {
                        btnE2.BackColor = Color.Yellow;
                        busSeat.e2 = (byte)SeatBookingStatus.Pending;
                    }
                    else if (busSeat.e2 == (byte)SeatBookingStatus.Pending)
                    {
                        btnE2.BackColor = Color.FromArgb(255, 255, 205);
                        busSeat.e2 = (byte)SeatBookingStatus.Unbooked;
                    }

                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }

        private void btnE3_Click(object sender, EventArgs e)
        {
            seat busSeat = BusSeat;
            //e3
            try
            {
                if (this.isAdmin)
                {
                    if (busSeat.e3 == (byte)SeatBookingStatus.Confram)
                    {
                        btnE3.BackColor = Color.FromArgb(255, 255, 205);
                        busSeat.e3 = (byte)SeatBookingStatus.Unbooked;
                    }
                    else if (busSeat.e3 == (byte)SeatBookingStatus.Unbooked)
                    {
                        btnE3.BackColor = Color.Yellow;
                        busSeat.e3 = (byte)SeatBookingStatus.Pending;
                    }
                    else if (busSeat.e3 == (byte)SeatBookingStatus.Pending)
                    {
                        btnE3.BackColor = Color.Green;
                        busSeat.e3 = (byte)SeatBookingStatus.Confram;
                    }
                }
                else
                {
                    if (busSeat.e3 == (byte)SeatBookingStatus.Unbooked)
                    {
                        btnE3.BackColor = Color.Yellow;
                        busSeat.e3 = (byte)SeatBookingStatus.Pending;
                    }
                    else if (busSeat.e3 == (byte)SeatBookingStatus.Pending)
                    {
                        btnE3.BackColor = Color.FromArgb(255, 255, 205);
                        busSeat.e3 = (byte)SeatBookingStatus.Unbooked;
                    }

                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }

        private void btnE4_Click(object sender, EventArgs e)
        {
            seat busSeat = BusSeat;
            //e4
            try
            {
                if (this.isAdmin)
                {
                    if (busSeat.e4 == (byte)SeatBookingStatus.Confram)
                    {
                        btnE4.BackColor = Color.FromArgb(255, 255, 205);
                        busSeat.e4 = (byte)SeatBookingStatus.Unbooked;
                    }
                    else if (busSeat.e4 == (byte)SeatBookingStatus.Unbooked)
                    {
                        btnE4.BackColor = Color.Yellow;
                        busSeat.e4 = (byte)SeatBookingStatus.Pending;
                    }
                    else if (busSeat.e4 == (byte)SeatBookingStatus.Pending)
                    {
                        btnE4.BackColor = Color.Green;
                        busSeat.e4 = (byte)SeatBookingStatus.Confram;
                    }
                }
                else
                {
                    if (busSeat.e4 == (byte)SeatBookingStatus.Unbooked)
                    {
                        btnE4.BackColor = Color.Yellow;
                        busSeat.e4 = (byte)SeatBookingStatus.Pending;
                    }
                    else if (busSeat.e4 == (byte)SeatBookingStatus.Pending)
                    {
                        btnE4.BackColor = Color.FromArgb(255, 255, 205);
                        busSeat.e4 = (byte)SeatBookingStatus.Unbooked;
                    }

                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            if(isAdmin)
            {
                var a = new AdminAcc();
                a.Show();
                this.Hide();
            }
            else
            {
                var u = new UserAcc();
                u.Show();
                this.Hide();
            }
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            try
            {


                db.SaveChanges();
                UILoad();
                MessageBox.Show("Bokked Succesfully");
                var u = new UserAcc();
                u.Show();
                this.Hide();
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