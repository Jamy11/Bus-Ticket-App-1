using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bus_Tickiet_Booking_App_1.Data_Access;
using BusTicketUi;

namespace Bus_Tickiet_Booking_App_1.Data_Controller
{
    class AdminController
    {
        public static string userName;
        BusTicketDb db = new BusTicketDb();

        public bool AdminCheckLogin(string i,string j)
        {
            try
            {

                var user =db.Admin.SingleOrDefault(x => x.username.Equals(i) & x.password.Equals(j));
                if (user != null)
                {
                  
                    return true;
                }
                else
                {
                    MessageBox.Show("User name or password not valid");
                    return false;
                }


            }
            catch (Exception)
            {
                MessageBox.Show("Login Feild!!!!");
                return false;
            }

        }
      

    }
}
