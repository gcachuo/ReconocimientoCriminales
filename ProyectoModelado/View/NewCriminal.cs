using AForge.Imaging.Filters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoModelado.View
{
    public partial class NewCriminal : Form
    {
        public NewCriminal()
        {
            InitializeComponent();
        }

        #region Variables Globales
        string actualPath = "";
        Bitmap bmpCambio;
        int width = 0;
        #endregion


        #region General Methods

        public void ClearAll()
        {
            imgCriminal.Image = null;
            imgCriminal.Refresh();

            actualPath = "";

        }

        public void AbrirImagen()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    imgCriminal.Image = new Bitmap(dialog.FileName);
                    actualPath = dialog.FileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading image, Error: " + ex.Message);
                }

            }
        }

        //Aplicar Filtro a la imagen
        public void AplicaFiltro(IFilter filtro, ref Bitmap bmpDestino, Bitmap bmpOrigen)
        {
            Bitmap auxiliar = filtro.Apply(bmpOrigen);
            bmpDestino = AForge.Imaging.Image.Clone(auxiliar, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            imgCriminal.Image = bmpDestino;
        }

        void GrayScale()
        {
            bmpCambio = (Bitmap)imgCriminal.Image;
            AplicaFiltro(Grayscale.CommonAlgorithms.BT709, ref bmpCambio, bmpCambio);
        }

        void Sepia()
        {
            bmpCambio = (Bitmap)imgCriminal.Image;
            AplicaFiltro(new Sepia(), ref bmpCambio, bmpCambio);
        }
        void InvertImage()
        {
            bmpCambio = (Bitmap)imgCriminal.Image;
            AplicaFiltro(new Invert(), ref bmpCambio, bmpCambio);
        }
        void GaussianBlur()
        {
            bmpCambio = (Bitmap)imgCriminal.Image;
            AplicaFiltro(new GaussianBlur(), ref bmpCambio, bmpCambio);
        }
        void HorizontalMirror()
        {
            bmpCambio = (Bitmap)imgCriminal.Image;
            AplicaFiltro(new Mirror(false, true), ref bmpCambio, bmpCambio);
        }

        void verticalMirror()
        {
            bmpCambio = (Bitmap)imgCriminal.Image;
            AplicaFiltro(new Mirror(true, false), ref bmpCambio, bmpCambio);
        }
        void Brightness()
        {
            bmpCambio = (Bitmap)imgCriminal.Image;
            AplicaFiltro(new BrightnessCorrection(), ref bmpCambio, bmpCambio);
        }

        void CannyDetector()
        {
            bmpCambio = (Bitmap)imgCriminal.Image;
            bmpCambio = Grayscale.CommonAlgorithms.RMY.Apply(bmpCambio);
            AplicaFiltro(new CannyEdgeDetector(), ref bmpCambio, bmpCambio);
        }
        void Smoothing()
        {
            bmpCambio = (Bitmap)imgCriminal.Image;
            AplicaFiltro(new AdaptiveSmoothing(), ref bmpCambio, bmpCambio);
        }
        void sharpen()
        {
            bmpCambio = (Bitmap)imgCriminal.Image;
            AplicaFiltro(new Sharpen(), ref bmpCambio, bmpCambio);
        }

        #endregion




        private void newCriminalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirImagen();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void escalaDeGrisesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imgCriminal.Image = new Bitmap(actualPath);
        }

        private void escalaDeGrisesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GrayScale();
        }

        private void sephiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sepia();
        }

        private void contornoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CannyDetector();
        }

        private void brilloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Brightness();
        }

        private void suavizadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Smoothing();
        }

        private void nitidezToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sharpen();
        }

        private void efectoGaussianoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GaussianBlur();
        }

        private void agregarImagenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PictureBox pic = new PictureBox();
            pic.Image = imgCriminal.Image;
            pic.Location = new Point(20 + width, 24);
            pic.Size = new Size(115, 145);
            pic.SizeMode = PictureBoxSizeMode.StretchImage;
            pnlFotos.Controls.Add(pic);

            width += 135;
        }


    }
}
