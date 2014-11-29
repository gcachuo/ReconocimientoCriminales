using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using Microsoft.Kinect;

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
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            sensor = KinectSensor.KinectSensors[0];
            sensor.Start();
            sensor.ColorStream.Enable();
            sensor.ColorFrameReady += sensor_ColorFrameReady;
        }

        void sensor_ColorFrameReady(object sensor, ColorImageFrameReadyEventArgs e)
        {
            using (var frameImagen = e.OpenColorImageFrame())
            {
                if (frameImagen == null) return;
                var datosColor=new byte[frameImagen.PixelDataLength];

                frameImagen.CopyPixelDataTo(datosColor);
                mostrarVideo.Source = BitmapSource.Create(
                    frameImagen.Width,frameImagen.Height,
                    96,
                    96,
                    PixelFormats.Bgr32,
                    null,
                    datosColor,
                    frameImagen.Width * frameImagen.BytesPerPixel
                    );
            }
        }
    }
}
