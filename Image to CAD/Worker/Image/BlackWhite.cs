using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Image_to_CAD.Image
{
    class BlackWhite
    {       
        Calibration cal;
        /// <summary>
        /// Turns an image into white(background) and black(objects)
        /// </summary>
        /// <param name="path">path of the image used for calibrating the greenscreen background</param>
        public BlackWhite(string path)
        {
            cal = new Calibration(path);
        }

        public Bitmap Work(Bitmap image, int RedVariation, int GreenVariation, int BlueVariation)
        {
            Bitmap imageModified = new Bitmap(image);
            int width = imageModified.Width;
            int height = imageModified.Height;

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color p = imageModified.GetPixel(x, y);

                    //Checks if the pixel is part of the background or not
                    bool background = false;

                    //Checks if Red is within the range of the background
                    if (p.R < cal.r + RedVariation && p.R > cal.r - RedVariation)
                    {
                        //Checks if Green is within the range of the background
                        if (p.G < cal.g + GreenVariation && p.G > cal.g - GreenVariation)
                        {
                            //Checks if Blue is within the range of the background
                            if (p.B < cal.b + BlueVariation && p.B > cal.b - BlueVariation)
                            {
                                background = true;
                            }
                        }
                    }
                    if (background) imageModified.SetPixel(x, y, Color.FromArgb(255, 255, 255, 255));
                    else imageModified.SetPixel(x, y, Color.FromArgb(255, 0, 0, 0));
                }
            }
            imageModified.Save("E:\\c#\\ImageToCAD\\imageblackwhite.png");
            return imageModified;
        }
    }
}
