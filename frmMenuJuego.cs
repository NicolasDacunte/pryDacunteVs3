﻿using System;
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
    public partial class frmMenuJuego : Form
    {
        public frmMenuJuego()
        {
            InitializeComponent();
        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmJuego frmJuego = new frmJuego();
            frmJuego.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmVentanaPrincipal MenuPrincipal = new frmVentanaPrincipal();
            MenuPrincipal.ShowDialog();
        }
    }
}
