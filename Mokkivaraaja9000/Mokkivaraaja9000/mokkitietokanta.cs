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
    public partial class mokkitietokanta : Form
    {
        public mokkitietokanta()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

        }

        private void mokkitietokanta_Load(object sender, EventArgs e)
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEtsimokki_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mokkitietokantaDataSet.Toimipiste' table. You can move, or remove it, as needed.
            this.toimipisteTableAdapter.Fill(this.mokkitietokantaDataSet.Toimipiste);
        }
    }
}
