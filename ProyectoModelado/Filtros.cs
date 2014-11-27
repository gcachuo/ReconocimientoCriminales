using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace ProyectoModelado
{
    internal class Filtros
    {
        #region Variables

        private Image _resultado;
        public static int Desplazamiento = 0;

        #endregion
        public static Bitmap Sobel3X3Filter(Bitmap sourceBitmap, bool grayscale = true)
        {
            double[,] matrizH =
            {
                {-1, 0, 1,},
                {-2, 0, 2,},
                {-1, 0, 1,},
            };
            double[,] matrizV =
            {
                {1, 2, 1,},
                {0, 0, 0,},
                {-1, -2, -1,},
            };
            Bitmap resultBitmap = ConvolutionFilter(sourceBitmap,
                matrizH, matrizV,
                1.0, 0, grayscale);

            return resultBitmap;
        }
        public static Bitmap ConvolutionFilter(Bitmap sourceBitmap, double[,] xFilterMatrix, double[,] yFilterMatrix, double factor = 1, int bias = 0, bool grayscale = false)
        {
            BitmapData sourceData = sourceBitmap.LockBits(new Rectangle(0, 0,
                                     sourceBitmap.Width, sourceBitmap.Height),
                                                       ImageLockMode.ReadOnly,
                                                  PixelFormat.Format32bppArgb);

            byte[] pixelBuffer = new byte[sourceData.Stride * sourceData.Height];
            byte[] resultBuffer = new byte[sourceData.Stride * sourceData.Height];

            Marshal.Copy(sourceData.Scan0, pixelBuffer, 0, pixelBuffer.Length);
            sourceBitmap.UnlockBits(sourceData);

            if (grayscale)
            {
                float rgb = 0;

                for (int k = 0; k < pixelBuffer.Length; k += 4)
                {
                    rgb = pixelBuffer[k] * 0.11f;
                    rgb += pixelBuffer[k + 1] * 0.59f;
                    rgb += pixelBuffer[k + 2] * 0.3f;

                    pixelBuffer[k] = (byte)rgb;
                    pixelBuffer[k + 1] = pixelBuffer[k];
                    pixelBuffer[k + 2] = pixelBuffer[k];
                    pixelBuffer[k + 3] = 255;
                }
            }

            double blueX = 0.0;
            double greenX = 0.0;
            double redX = 0.0;

            double blueY = 0.0;
            double greenY = 0.0;
            double redY = 0.0;

            double blueTotal = 0.0;
            double greenTotal = 0.0;
            double redTotal = 0.0;

            int filterOffset = 1;
            int calcOffset = 0;

            int byteOffset = 0;

            for (int offsetY = filterOffset; offsetY <
                sourceBitmap.Height - filterOffset; offsetY++)
            {
                for (int offsetX = filterOffset; offsetX <
                    sourceBitmap.Width - filterOffset; offsetX++)
                {
                    blueX = greenX = redX = 0;
                    blueY = greenY = redY = 0;

                    blueTotal = greenTotal = redTotal = 0.0;

                    byteOffset = offsetY *
                                 sourceData.Stride +
                                 offsetX * 4;

                    for (int filterY = -filterOffset;
                        filterY <= filterOffset; filterY++)
                    {
                        for (int filterX = -filterOffset;
                            filterX <= filterOffset; filterX++)
                        {
                            calcOffset = byteOffset +
                                         (filterX * 4) +
                                         (filterY * sourceData.Stride);

                            blueX += (double)(pixelBuffer[calcOffset]) *
                                      xFilterMatrix[filterY + filterOffset,
                                              filterX + filterOffset];

                            greenX += (double)(pixelBuffer[calcOffset + 1]) *
                                      xFilterMatrix[filterY + filterOffset,
                                              filterX + filterOffset];

                            redX += (double)(pixelBuffer[calcOffset + 2]) *
                                      xFilterMatrix[filterY + filterOffset,
                                              filterX + filterOffset];

                            blueY += (double)(pixelBuffer[calcOffset]) *
                                      yFilterMatrix[filterY + filterOffset,
                                              filterX + filterOffset];

                            greenY += (double)(pixelBuffer[calcOffset + 1]) *
                                      yFilterMatrix[filterY + filterOffset,
                                              filterX + filterOffset];

                            redY += (double)(pixelBuffer[calcOffset + 2]) *
                                      yFilterMatrix[filterY + filterOffset,
                                              filterX + filterOffset];
                        }
                    }

                    blueTotal = Math.Sqrt((blueX * blueX) + (blueY * blueY));
                    greenTotal = Math.Sqrt((greenX * greenX) + (greenY * greenY));
                    redTotal = Math.Sqrt((redX * redX) + (redY * redY));

                    if (blueTotal > 255)
                    { blueTotal = 255; }
                    else if (blueTotal < 0)
                    { blueTotal = 0; }

                    if (greenTotal > 255)
                    { greenTotal = 255; }
                    else if (greenTotal < 0)
                    { greenTotal = 0; }

                    if (redTotal > 255)
                    { redTotal = 255; }
                    else if (redTotal < 0)
                    { redTotal = 0; }

                    resultBuffer[byteOffset] = (byte)(blueTotal);
                    resultBuffer[byteOffset + 1] = (byte)(greenTotal);
                    resultBuffer[byteOffset + 2] = (byte)(redTotal);
                    resultBuffer[byteOffset + 3] = 255;
                }
            }

            Bitmap resultBitmap = new Bitmap(sourceBitmap.Width, sourceBitmap.Height);

            BitmapData resultData = resultBitmap.LockBits(new Rectangle(0, 0,
                                     resultBitmap.Width, resultBitmap.Height),
                                                      ImageLockMode.WriteOnly,
                                                  PixelFormat.Format32bppArgb);

            Marshal.Copy(resultBuffer, 0, resultData.Scan0, resultBuffer.Length);
            resultBitmap.UnlockBits(resultData);

            return resultBitmap;
        }
        public static Bitmap PrewittFilter(Bitmap sourceBitmap, bool grayscale = true)
        {
            double[,] matrizH =
            {
                {-1, 0, 1,},
                {-1, 0, 1,},
                {-1, 0, 1,},
            };
            double[,] matrizV =
            {
                {1, 1, 1,},
                {0, 0, 0,},
                {-1, -1, -1,},
            };
            Bitmap resultBitmap = ConvolutionFilter(sourceBitmap,
                matrizH, matrizV,
                1.0, 0, grayscale);

            return resultBitmap;
        }
        public static Bitmap Convolucion3X3(Bitmap imgModificar, int[,] elementos, int factor)
        {
            Bitmap imgCopia = (Bitmap)imgModificar.Clone();
            if (factor == 0) factor = 1;
            //Obtencion del espacio de la imagen original
            Rectangle rcImg = new Rectangle(0, 0, imgModificar.Width, imgModificar.Height);
            Rectangle rcImgCopia = new Rectangle(0, 0, imgCopia.Width, imgCopia.Height);
            //Atributos de la imagen y bloqueo en el uso de memoria para su modificacion
            BitmapData imgDatos = imgModificar.LockBits(rcImg, ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            BitmapData imgDatosCopia = imgCopia.LockBits(rcImgCopia, ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            int anchoRen01 = imgDatos.Stride;
            int anchoRen02 = anchoRen01 * 2;
            IntPtr pttInicio01 = imgDatos.Scan0;
            IntPtr pttInicio02 = imgDatosCopia.Scan0;
            unsafe
            {
                byte* ptt = (byte*)pttInicio01;
                byte* pttCopia = (byte*)pttInicio02;
                int nDesplaza = anchoRen01 - imgModificar.Width * 3;
                int nAncho = imgModificar.Width - 2;
                int nAlto = imgModificar.Height - 2;
                int nPixel;
                for (int ren = 0; ren < nAlto; ren++)
                {
                    for (int colo = 0; colo < nAncho; colo++)
                    {
                        //AZUL
                        nPixel = (pttCopia[0] * elementos[0, 0] + pttCopia[3] * elementos[0, 1] + pttCopia[6] * elementos[0, 2] +
                            pttCopia[0 + anchoRen01] * elementos[1, 0] + pttCopia[3 + anchoRen01] * elementos[1, 1] + pttCopia[6 + anchoRen01] * elementos[1, 2] +
                             pttCopia[0 + anchoRen02] * elementos[2, 0] + pttCopia[3 + anchoRen02] * elementos[2, 1] + pttCopia[6 + anchoRen02] * elementos[2, 2]) / factor;
                        nPixel += Desplazamiento;
                        if (nPixel < 0) nPixel = 0;
                        if (nPixel > 255) nPixel = 255;
                        ptt[3 + anchoRen01] = (byte)nPixel;
                        //VERDE
                        nPixel = (pttCopia[1] * elementos[0, 0] + pttCopia[4] * elementos[0, 1] + pttCopia[7] * elementos[0, 2] +
                           pttCopia[1 + anchoRen01] * elementos[1, 0] + pttCopia[4 + anchoRen01] * elementos[1, 1] + pttCopia[7 + anchoRen01] * elementos[1, 2] +
                            pttCopia[1 + anchoRen02] * elementos[2, 0] + pttCopia[4 + anchoRen02] * elementos[2, 1] + pttCopia[7 + anchoRen02] * elementos[2, 2]) / factor;
                        if (nPixel < 0) nPixel = 0;
                        if (nPixel > 255) nPixel = 255;
                        ptt[4 + anchoRen01] = (byte)nPixel;
                        //ROJO
                        nPixel = (pttCopia[2] * elementos[0, 0] + pttCopia[5] * elementos[0, 1] + pttCopia[8] * elementos[0, 2] +
                           pttCopia[2 + anchoRen01] * elementos[1, 0] + pttCopia[5 + anchoRen01] * elementos[1, 1] + pttCopia[8 + anchoRen01] * elementos[1, 2] +
                            pttCopia[2 + anchoRen02] * elementos[2, 0] + pttCopia[5 + anchoRen02] * elementos[2, 1] + pttCopia[8 + anchoRen02] * elementos[2, 2]) / factor;
                        if (nPixel < 0) nPixel = 0;
                        if (nPixel > 255) nPixel = 255;
                        ptt[5 + anchoRen01] = (byte)nPixel;

                        ptt += 3;
                        pttCopia += 3;

                    }
                    ptt += nDesplaza + 6;
                    pttCopia += nDesplaza + 6;

                }
            }
            imgModificar.UnlockBits(imgDatos);
            imgCopia.UnlockBits(imgDatosCopia);
            return imgModificar;
        }
        public static Bitmap EscalaGrises(Bitmap imgModificar)
        {
            //rectángulo de la imagen original
            var rcImg = new Rectangle(0, 0, imgModificar.Width, imgModificar.Height);

            //atributos de la imagen, y bloquear su uso en memoria  para su modificación
            var imgDatos = imgModificar.LockBits(rcImg, ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            //obtiene los datos de ancho, altura, desplazamiento de la imagen
            var grosorImg = imgDatos.Stride;
            var pttInicio = imgDatos.Scan0;
            byte colAzul;
            byte colRojo;
            byte colVerde;
            int anchoPx = imgModificar.Width * 3;
            int offsetImg = grosorImg - anchoPx;
            int anchoImg = imgModificar.Width;
            int altoImg = imgModificar.Height;
            unsafe
            {
                byte* ptt = (byte*)pttInicio;

                //ciclo que toma  cada byte de la imagen y lo enví a la escala de grises
                //sumándole  los 3 colores  y diviéndolo entre 3
                //se asigna  a cada color el mismo color resultante
                for (int ren = 0; ren < altoImg; ren++)
                {
                    for (int col = 0; col < anchoImg; col++)
                    {
                        colAzul = ptt[0];
                        colVerde = ptt[1];
                        colRojo = ptt[2];
                        byte colGris = (byte)((colAzul + colVerde + colRojo) / 3);
                        lstGraficas.Grises[int.Parse(colGris.ToString())] += 1;
                        ptt[0] = colGris;
                        ptt[1] = colGris;
                        ptt[2] = colGris;
                        ptt += 3;
                    }
                    ptt += offsetImg;
                }
            }
            imgModificar.UnlockBits(imgDatos);
            return imgModificar;
        }


        public Image AplicaFiltro(string filtro, Bitmap img)
        {

            switch (filtro)
            {
                case "sobel":
                    var imgOrigen = new Bitmap(img);
                    imgOrigen = Sobel3X3Filter(imgOrigen);
                    _resultado = imgOrigen;
                    return _resultado;
                case "prewitt":
                    imgOrigen = new Bitmap(img);
                    imgOrigen = PrewittFilter(imgOrigen);
                    _resultado = imgOrigen;
                    return _resultado;
                case "bordes":
                    imgOrigen = new Bitmap(img);

                    int[,] elementos =
                    {
                        {-1, -1, -1},
                        {0, 0, 0},
                        {1, 1, 1}
                    };
                    Desplazamiento = 127;
                    imgOrigen = Convolucion3X3(imgOrigen, elementos, 4);
                    _resultado = imgOrigen;
                    return _resultado;

                case "escala de grises":
                    imgOrigen = new Bitmap(img);
                    imgOrigen = EscalaGrises(imgOrigen);
                    _resultado = imgOrigen;
                    return _resultado;
                case "canny":
                    var cannyData = new Canny(img, 20, 10, 5, 1);
                    return cannyData.DisplayImage(cannyData.EdgeMap);

            }
            return null;
        }

    }
}
