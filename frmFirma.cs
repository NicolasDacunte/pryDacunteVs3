using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;

namespace pryDacunteVs3
{
    public partial class frmFirma : Form
    {
        public frmFirma()
        {
            InitializeComponent();
        }
        public bool Click = false;
        Point previousPoint;

        private void frmFirma_Load(object sender, EventArgs e)
        {

        }

        
        private void pctFirma_MouseDown_1(object sender, MouseEventArgs e)
        {
            Click = true;
            previousPoint = e.Location;
        }

        private void pctFirma_MouseUp(object sender, MouseEventArgs e)
        {
            Click = false;
        }

        private void pctFirma_MouseMove(object sender, MouseEventArgs e)
        {
            if (Click == true)
            {
                using (Graphics g = pctFirma.CreateGraphics())
                {
                    using (Pen pen = new Pen(Color.Black, 4))
                    {
                        g.DrawLine(pen, previousPoint, e.Location);
                        previousPoint = e.Location;

                    }
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string rutaDir = Application.StartupPath + "Firmas";

                if (Directory.Exists(rutaDir))
                {
                    string rutaCarpeta = Application.StartupPath + "Firmas\\";
                    string NombreArchivo = "Firma_" + DateTime.Now.ToString("yy-MM-dd-HH-mm-ss") + ".jpg";
                    rutaCarpeta += NombreArchivo;

                    Bitmap bmp = new Bitmap(pctFirma.Width, pctFirma.Height);

                    using (Graphics g = Graphics.FromImage(bmp))
                    {
                        g.CopyFromScreen(pctFirma.PointToScreen(Point.Empty), Point.Empty, pctFirma.Size);
                    }

                    bmp.Save(rutaCarpeta, System.Drawing.Imaging.ImageFormat.Jpeg);

                    MessageBox.Show("SU FIRMA SE GUARDO CORRECTAMENTE");
                    pctFirma.Invalidate();

                }
                else
                {
                    Directory.CreateDirectory(rutaDir);
                    MessageBox.Show("La carpeta Firmas no existe, se creara una nueva");
                    string rutaCarpeta = Application.StartupPath + "Firmas\\";
                    string NombreArchivo = "Firma_" + DateTime.Now.ToString("yy-MM-dd-HH-mm-ss") + ".jpg";
                    rutaCarpeta += NombreArchivo;

                    Bitmap bmp = new Bitmap(pctFirma.Width, pctFirma.Height);

                    using (Graphics g = Graphics.FromImage(bmp))
                    {
                        g.CopyFromScreen(pctFirma.PointToScreen(Point.Empty), Point.Empty, pctFirma.Size);
                    }

                    bmp.Save(rutaCarpeta, System.Drawing.Imaging.ImageFormat.Jpeg);

                    MessageBox.Show("SU FIRMA SE GUARDO CORRECTAMENTE");
                    pctFirma.Invalidate();
                }




            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la imagen" + ex.Message);

            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmVentanaPrincipal MenuPrincipal = new frmVentanaPrincipal();
            MenuPrincipal.Show();
        }
    }
}
