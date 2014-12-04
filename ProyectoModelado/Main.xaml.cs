using System;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Microsoft.Kinect;
using System.Drawing.Imaging;


namespace ProyectoModelado
{
    /// <summary>
    /// Interaction logic for Main.xaml
    /// </summary>
    public partial class Main1
    {
        public Main1()
        {
            InitializeComponent();
        }

        private KinectSensor sensor;
        private WriteableBitmap bitmapImagenColor = null;
        private byte[] bytesColor;
        Skeleton[] esqueletos;
        private bool MovAdelante;
        private bool MovAtras = false;
        private SolidColorBrush brushActivo = new SolidColorBrush(Colors.Green);
        private SolidColorBrush brushInactivo = new SolidColorBrush(Colors.Red);
        //Image[] fotos=new Image[5]{"",};


        //Metodo para convertir un arreglo de bytes a imagen
        public static BitmapImage GetImage(Byte[] bytes)
        {
            MemoryStream stream = new MemoryStream(bytes);
            stream.Seek(0, SeekOrigin.Begin);
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.StreamSource = stream;
            image.EndInit();
            return image;
        }




        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var form = new Form1();
            form.Hide();
            try
            {
                //Cargar lista de criminales
                /////
                ////
                ///

                //Por cada campo de imagen llamar el metodo GetImage



                sensor = KinectSensor.KinectSensors[0];
                sensor.SkeletonStream.Enable();
                sensor.Start();
                sensor.ColorStream.Enable();
                sensor.ColorFrameReady += sensor_ColorFrameReady;
                sensor.SkeletonFrameReady += sensor_SkeletonFrameReady;
                //Application.Current.Exit += Current_Exit;
            }
            catch (Exception)
            {

                MessageBox.Show("Conecte el Dispositivo");
            }
        }

        private void Current_Exit(object sender, ExitEventArgs e)
        {
            if (sensor == null) return;
            sensor.Stop();
            sensor = null;
        }

        void sensor_SkeletonFrameReady(object sender, SkeletonFrameReadyEventArgs e)
        {
            using (var frame = e.OpenSkeletonFrame())
            {
                if (frame != null)
                {
                    esqueletos = new Skeleton[frame.SkeletonArrayLength];
                    frame.CopySkeletonDataTo(esqueletos);
                }
            }
            if (esqueletos == null) return;
            var esqueletoCercano =
                esqueletos.Where(s => s.TrackingState == SkeletonTrackingState.Tracked)
                    .OrderBy(s => s.Position.Z * Math.Abs(s.Position.X))
                    .FirstOrDefault();
            if (esqueletoCercano == null) return;

            var cabeza = esqueletoCercano.Joints[JointType.Head];
            var pecho = esqueletoCercano.Joints[JointType.ShoulderCenter];
            var manoDer = esqueletoCercano.Joints[JointType.HandRight];
            var manoIzq = esqueletoCercano.Joints[JointType.HandLeft];
            var hombroDer = esqueletoCercano.Joints[JointType.ShoulderRight];

            if (cabeza.TrackingState == JointTrackingState.NotTracked ||
                manoDer.TrackingState == JointTrackingState.NotTracked ||
                manoIzq.TrackingState == JointTrackingState.NotTracked)
            {
                return;
            }

            //PosicionEllipse(EllipseCabeza, pecho, false);
            //PosicionEllipse(EllipseManoIzq, manoIzq, MovAtras);
            PosicionEllipse(EllipseManoDer, manoDer, MovAdelante);
            ProcesoAdelanteAtras(pecho, manoDer, hombroDer);
        }

        private int x;
        private void ProcesoAdelanteAtras(Joint cabeza, Joint manoDer, Joint hombroDer)
        {
            if (manoDer.Position.Y > cabeza.Position.Y)
            {
                if (!MovAdelante)
                {
                    MovAdelante = true;
                    MessageBox.Show("Arriba");
                }

            }

            else if (manoDer.Position.X < hombroDer.Position.X)
            {
                if (!MovAdelante)
                {
                    MovAdelante = true;
                    MessageBox.Show("Vuelta");
                }
            }

            else
            {
                MovAdelante = false;
                System.Windows.Forms.SendKeys.SendWait("{Enter}");
            }

        }


        private void PosicionEllipse(Shape ellipse, Joint joint, bool activo)
        {

            if (activo)
            {
                ellipse.Width = 60;
                ellipse.Height = 60;
                ellipse.Fill = brushActivo;
            }
            else
            {
                ellipse.Width = 20;
                ellipse.Height = 20;
                ellipse.Fill = brushInactivo;
            }
            var mapping = sensor.CoordinateMapper;
            var point = mapping.MapSkeletonPointToColorPoint(joint.Position, sensor.ColorStream.Format);
            Canvas.SetLeft(ellipse, point.X - ellipse.Width / 2);
            Canvas.SetTop(ellipse, point.Y - ellipse.Height / 2);
        }

        void sensor_ColorFrameReady(object sender, ColorImageFrameReadyEventArgs e)
        {
            using (var frameImagen = e.OpenColorImageFrame())
            {

                if (frameImagen == null) return;
                if (bytesColor == null || bytesColor.Length != frameImagen.PixelDataLength)
                    bytesColor = new byte[frameImagen.PixelDataLength];

                frameImagen.CopyPixelDataTo(bytesColor);

                if (bitmapImagenColor == null)
                {
                    bitmapImagenColor = new WriteableBitmap(
                        frameImagen.Width,
                        frameImagen.Height,
                        96,
                        96,
                        PixelFormats.Bgr32,
                        null);
                }

                bitmapImagenColor.WritePixels(
                    new Int32Rect(0, 0, frameImagen.Width, frameImagen.Height),
                    bytesColor,
                    frameImagen.Width * frameImagen.BytesPerPixel,
                    0);
                mostrarVideo.Source = bitmapImagenColor;
            }
        }

        private bool d;
        private void Window_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key.Equals(System.Windows.Input.Key.A))
            {
                //var i = mostrarVideo.Source;
                //if (d)
                //{
                //    var x = 0;
                //    while (File.Exists(AppDomain.CurrentDomain.BaseDirectory + @"/foto" + x + ".jpg"))
                //    {
                //        x++;
                //    }
                //    i.Save (AppDomain.CurrentDomain.BaseDirectory + @"/foto" + x + ".jpg");
                //    savetopng
                //    d = false;
                //}
            }
        }
    }
}
