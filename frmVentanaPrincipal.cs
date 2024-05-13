using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryDacunteVs3
{
    public partial class frmVentanaPrincipal : Form
    {
        public frmVentanaPrincipal()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void galagaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenuJuego menuJuego = new frmMenuJuego();
            menuJuego.Show();
        }

        private void firmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmFirma firma = new frmFirma();
            firma.Show();
        }
    }
}
