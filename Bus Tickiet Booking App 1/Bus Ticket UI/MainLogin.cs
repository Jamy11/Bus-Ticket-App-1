using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusTicketUi
{
    public partial class MainLogin : Form
    {
        int mov;
        int movX;
        int movY;
        public MainLogin()
        {
            InitializeComponent();
        }

        private void x_btn_click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void admin_btn_click(object sender, EventArgs e)
        {
            AdminLogin j = new AdminLogin();
            j.Show();
            this.Hide();

        }

        private void user_btn_click(object sender, EventArgs e)
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
            if(mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }
    }
}
