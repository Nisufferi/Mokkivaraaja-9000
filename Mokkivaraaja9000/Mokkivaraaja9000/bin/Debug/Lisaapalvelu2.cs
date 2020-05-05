using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mokkivaraaja9000
{
    public partial class Lisaapalvelu2 : Form
    {
        public Lisaapalvelu2()
        {
            InitializeComponent();
        }

        private void lpminbtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lpbackbtn_Click(object sender, EventArgs e)
        {
            tietosyotto ts = new tietosyotto();
            ts.Show();
            this.Hide();
        }

        private void lisaapalvelubtn_Click(object sender, EventArgs e)
        {

        }
    }
}
