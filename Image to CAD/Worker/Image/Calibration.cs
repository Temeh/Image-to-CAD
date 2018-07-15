using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Image_to_CAD.Image
{
    /// <summary>
    /// Takes an image of the background to calibrate the "greenscreen" values.
    /// </summary>
    class Calibration
    {
        Bitmap image;
        public int r = 0;
        public int g = 0;
        public int b = 0;
        bool calibrated = false;

        public Calibration(string path)
        {
            {
                //Loads a picture of the background and finds median colour values
                image = new Bitmap(path);

                int width = image.Width;
                int height = image.Height;

                int[] red = new int[256];
                int[] green = new int[256];
                int[] blue = new int[256];
                for (int i = 0; i < 256; i++)
                {
                    red[i] = 0;
                    green[i] = 0;
                    blue[i] = 0;
                }

                int pixels = 0;
                for (int x = 0; x < width; x++)
                {
                    for (int y = 0; y < height; y++)
                    {
                        Color k = image.GetPixel(x, y);
                        red[k.R]++;
                        green[k.G]++;
                        blue[k.B]++;
                        pixels++;
                    }
                }
                pixels = pixels / 2;
                int counter = 0;
                int median = 0;
                while (median < pixels)
                {
                    median += red[counter];
                    counter++;
                }
                r = median; median = 0; counter = 0;
                while (median < pixels)
                {
                    median += green[counter];
                    counter++;
                }
                g = median; median = 0; counter = 0;
                while (median < pixels)
                {
                    median += blue[counter];
                    counter++;
                }
                b = median; median = 0; counter = 0;
                calibrated = true;
            }
        }
    }
}
