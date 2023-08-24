using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionHotel.Views
{
    public partial class BarForm : Form
    {
        public BarForm()
        {
            InitializeComponent();
        }
       private int second = 0;

        private void bartime_Tick(object sender, EventArgs e)
        {
            second++;

            panel2.Left +=2;
            if (panel2.Left + panel2.Width > panel1.Width+100)
                panel2.Left = 0;
            if (second == 400)
            {
                Login log=new Login();
                bartime.Stop();
                this.Hide();
                log.Show();
            }
        }
       
    }
}
