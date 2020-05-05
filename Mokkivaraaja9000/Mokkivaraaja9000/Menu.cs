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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tietoselaus ts = new tietoselaus();
            ts.Show();
            this.Hide();
        }

        private void btnVaraa_mokki_Click(object sender, EventArgs e)
        {
            mokkitietokanta mtk = new mokkitietokanta();
            mtk.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Mahdollistaa formin liikuttelun näytöllä.
        //Liikuttaminen ei ole muuten mahdollista koska formin border style on false.
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);
        }

        private void btnMinMenu_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnSyota_tietoa_Click(object sender, EventArgs e)
        {
            tietosyotto ts = new tietosyotto();
            ts.Show();
            this.Hide();
        }
    }
}
