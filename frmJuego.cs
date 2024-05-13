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
    public partial class frmJuego : Form
    {
        public frmJuego()
        {
            InitializeComponent();
            /*timerEnemigos.Interval = 1500;
            timerEnemigos.Tick += timerEnemigos_Tick;
            timerEnemigos.Start();*/
        }

        //public System.Windows.Forms.Timer timerEnemigos = new System.Windows.Forms.Timer();


        bool derecha;
        bool izquierda;
        bool espacio;

        void movimiento_flechas()
        {
            //si la variable derecha es verdadera, jugador se mueve a la derecha
            if (derecha == true)
            {
                if (pctJugador.Left < 792)
                {
                    pctJugador.Left += 40;
                }
            }
            //si la variable derecha es verdadera, jugador se mueve a la izquierda
            if (izquierda == true)
            {
                if (pctJugador.Left > -16)
                {
                    pctJugador.Left -= 40;
                }
            }
        }
        
        Random rnd = new Random();
        clsNave naves = new clsNave();

        void disparos()
        {
            PictureBox disparo = new PictureBox();
            disparo.SizeMode = PictureBoxSizeMode.Zoom;
            disparo.Image = pryDacunteVs3.Properties.Resources.bala;
            disparo.BackColor = System.Drawing.Color.Transparent;
            disparo.Tag = "disparo";
            disparo.Left = pctJugador.Left;
            disparo.Top = pctJugador.Top - 50;
            this.Controls.Add(disparo);
            disparo.BringToFront();

        }

        void disparo_mov()
        {
            foreach (Control x in this.Controls)
            {
                //primero se tagea el disparo desde la funcion y luego se mueve hacia arriba
                if (x is PictureBox && x.Tag == "disparo")
                {
                    x.Top -= 20;
                    if (x.Top < 100)
                    {
                        this.Controls.Remove(x);

                    }
                }
            }
        }

        int puntos;
        Random random = new Random();
        void SCORE()
        {
            //hace que cuando instersecte la bala con el bicho, este se muera y reaparezca
            foreach (Control e in this.Controls)
            {
                foreach (Control i in this.Controls)
                {
                    if (e is PictureBox && e.Tag == "disparo")
                    {
                        if (i is PictureBox && i.Tag == "enemigo")
                        {
                            if (e.Bounds.IntersectsWith(i.Bounds))
                            {
                                // Generar nuevas coordenadas aleatorias
                                int newX = random.Next(0, this.ClientSize.Width - i.Width);
                                //int newY = random.Next(0, this.ClientSize.Height - i.Height);

                                // Establecer nuevas coordenadas para el enemigo
                                i.Location = new Point(newX);
                                i.Top += 5;
                                ((PictureBox)e).Image = Properties.Resources.explosion;
                                System.Windows.Forms.Timer timerExplosion = new System.Windows.Forms.Timer();
                                timerExplosion.Interval = 80;
                                timerExplosion.Tick += (sender, arges) =>
                                {
                                    this.Controls.Remove(e);
                                    e.Dispose();
                                    timerExplosion.Stop();
                                };
                                timerExplosion.Start();
                                puntos++;
                                lblScore.Text = "Puntos : " + puntos;
                            }
                        }
                    }
                }
            }
            if (pctJugador.Bounds.IntersectsWith(pctNave.Bounds))
            {
                btnReiniciar.BringToFront();

                timer1.Stop();

                btnReiniciar.Visible = true;
                btnReiniciar.Enabled = true;
                btnSalir.Visible = true;
                btnSalir.Enabled = true;

            }
            if (pctJugador.Bounds.IntersectsWith(pctAlien.Bounds))
            {


                timer1.Stop();

                btnReiniciar.Visible = true;
                btnReiniciar.Enabled = true;
                btnSalir.Visible = true;
                btnSalir.Enabled = true;
                lblCartel.Visible = true;
                btnReiniciar.BringToFront();

            }
            if (puntos >= 10)
            {
                btnReiniciar.BringToFront();
                timer1.Stop();
                btnReiniciar.Visible = true;
                btnReiniciar.Enabled = true;
                btnSalir.Visible = true;
                btnSalir.Enabled = true;
                lblCartel.Visible = true;
                lblGanar.Visible = true;
            }
        }
        
        private void frmJuego_KeyDown_1(object sender, KeyEventArgs e)
        {
            //Cada tecla de estas si es presionada se activa la variable booleana
            if (e.KeyCode == Keys.Right)
            {
                derecha = true;
            }
            if (e.KeyCode == Keys.Left)
            {
                izquierda = true;
            }
            if (e.KeyCode == Keys.Space)
            {
                espacio = true;
                disparos();
            }
        }
        private void frmJuego_KeyUp_1(object sender, KeyEventArgs e)
        {
            //Cada tecla de estas deja de presionarse se desactiva la variable booleana
            if (e.KeyCode == Keys.Right)
            {
                derecha = false;
            }
            if (e.KeyCode == Keys.Left)
            {
                izquierda = false;
            }
            if (e.KeyCode == Keys.Space)
            {
                espacio = false;
            }
        }

        /*private void timerEnemigos_Tick(object sender, EventArgs e)
        {
            
            movEnemigo.Enemigo(this);
        }*/

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            //llama funcion y clases

            movimiento_flechas();
            naves.MoverEnemigo(pctAlien, pctNave);
            disparo_mov();
            SCORE();
        }

        private void frmJuego_Load(object sender, EventArgs e)
        {

        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmJuego juego = new frmJuego();
            juego.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            frmVentanaPrincipal volver = new frmVentanaPrincipal();
            volver.Show();
            this.Hide();
        }
    }
}
