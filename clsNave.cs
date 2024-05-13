using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryDacunteVs3
{
    internal class clsNave
    {
        private PictureBox alien;
        private PictureBox nave;
        public Random rnd;
        /*public List<PictureBox> listaEnemigos = new List<PictureBox>(); // Lista para almacenar los enemigos
        public System.Windows.Forms.Timer timerEnemigos = new System.Windows.Forms.Timer();
        public clsNave()
        {
            timerEnemigos.Interval = 18;
            timerEnemigos.Tick += timerEnemigos_Tick;
        }*/
        //boca
        public void MoverEnemigo(PictureBox pctAlien, PictureBox pctNave)
        {
            this.alien = pctAlien;
            this.nave = pctNave;
            this.rnd = new Random();
            int x, y;
            if (pctAlien.Top >= 500)
            {
                x = rnd.Next(0, 300);
                pctAlien.Location = new Point(x, 0);
            }
            if (pctNave.Top >= 500)
            {
                y = rnd.Next(0, 300);
                pctNave.Location = new Point(y, 0);
            }
            else
            {
                pctAlien.Top += 13;
                pctNave.Top += 8;

            }
        }

        /*private void timerEnemigos_Tick(object sender, EventArgs e)
        {

            foreach (var pctEnemigo in listaEnemigos)
            {

                if (pctEnemigo != null)
                {
                    pctEnemigo.Top += 4;

                }
            }
        }

        public void Enemigo(frmJuego frmJuego)
        {
            PictureBox pctEnemigo = new PictureBox();
            PictureBox pctEnemigo2 = new PictureBox();
            Random random = new Random();
            int rndX = random.Next(0, 820);

            pctEnemigo.Image = pryDacunte.Properties.Resources.alien2_removebg_preview;
            pctEnemigo.SizeMode = PictureBoxSizeMode.Zoom;
            pctEnemigo.BackColor = Color.Transparent;
            pctEnemigo.Location = new Point(rndX, 0);
            pctEnemigo.Visible = true;
            frmJuego.Controls.Add(pctEnemigo);
            listaEnemigos.Add(pctEnemigo);
            pctEnemigo.BringToFront();

            pctEnemigo2.Image = pryDacunte.Properties.Resources.alien_removebg_preview;
            pctEnemigo2.SizeMode = PictureBoxSizeMode.Zoom;
            pctEnemigo2.BackColor = Color.Transparent;
            pctEnemigo2.Location = new Point(rndX, 0);
            pctEnemigo2.Visible = true;
            frmJuego.Controls.Add(pctEnemigo);
            listaEnemigos.Add(pctEnemigo);
            pctEnemigo2.BringToFront();
            timerEnemigos.Start();

        }*/
              
        
       
    }
}
