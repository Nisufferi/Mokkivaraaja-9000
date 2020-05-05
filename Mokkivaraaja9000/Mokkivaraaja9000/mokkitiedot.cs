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
    public partial class haemokkeja : Form
    {
        public haemokkeja()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Menu fm = new Menu();
            fm.Show();
            this.Hide();
        }

        private void tbHlomaara_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbHlomaara_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnVaraa_mokki_Click(object sender, EventArgs e)
        {
            mokkitietokanta mtk = new mokkitietokanta();
            mtk.Show();
            this.Hide();
        }

        private void btnHaemokkeja_Load(object sender, EventArgs e)
        {

        }
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

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
