using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace BasicImageProcessing
{
    class ImageOperation
    {
        public ImageOperation()
        {
        }

        public static Bitmap grayScale(Bitmap img)
        {
            Bitmap outImg = new Bitmap(img.Width, img.Height);

            for (int x = 0; x < img.Width; x++)
            {
                for (int y = 0; y < img.Height; y++)
                {
                    Color c = img.GetPixel(x, y);
                    int gray = (int)Math.Floor(0.21 * c.R + 0.72 * c.G + 0.07 * c.B);
                    outImg.SetPixel(x, y, Color.FromArgb(gray, gray, gray));
                }
            }

            return outImg;
        }

        public static Bitmap negative(Bitmap img)
        {
            Bitmap outImg = new Bitmap(img.Width, img.Height);

            for (int x = 0; x < img.Width; x++)
            {
                for (int y = 0; y < img.Height; y++)
                {
                    Color c = img.GetPixel(x, y);
                    outImg.SetPixel(x, y, Color.FromArgb(255 - c.R, 255 - c.G, 255 - c.B));
                }
            }

            return outImg;
        }

        public static Bitmap sepia(Bitmap img)
        {
            Bitmap outImg = new Bitmap(img.Width, img.Height);

            for (int x = 0; x < img.Width; x++)
            {
                for (int y = 0; y < img.Height; y++)
                {
                    Color c = img.GetPixel(x, y);
                    int r = c.R, g = c.G, b = c.B;

                    r = (int)(b * 0.189 + g * 0.769 + r * 0.393);
                    g = (int)(b * 0.168 + g * 0.686 + r * 0.349);
                    b = (int)(b * 0.131 + g * 0.534 + r * 0.272);

                    r = (r > 255) ? 255 : r;
                    g = (g > 255) ? 255 : g;
                    b = (b > 255) ? 255 : b;

                    outImg.SetPixel(x, y, Color.FromArgb(r, g, b));
                }
            }

            return outImg;
        }

        public static Bitmap blur(Bitmap img)
        {
            Bitmap outImg = new Bitmap(img, img.Width, img.Height);

            for (int x = 2; x < img.Width - 3; x++)
            {
                for (int y = 2; y < img.Height - 3; y++)
                {
                    int r = 0, g = 0, b = 0;
                    for (int xx = x - 2; xx <= x + 2; xx++)
                    {
                        for (int yy = y - 2; yy <= y + 2; yy++)
                        {
                            Color c = img.GetPixel(xx, yy);
                            r += c.R;
                            g += c.G;
                            b += c.B;
                        }
                    }
                    r /= 25;
                    g /= 25;
                    b /= 25;
                    outImg.SetPixel(x, y, Color.FromArgb(r, g, b));
                }
            }
            return outImg;
        }

        public static Bitmap detectEdges(Bitmap img)
        {
            Bitmap outImg = new Bitmap(img, img.Width, img.Height);

            for (int x = 1; x < img.Width - 2; x++)
            {
                for (int y = 1; y < img.Height - 2; y++)
                {
                    int r = 0, g = 0, b = 0;
                    for (int xx = x - 1; xx <= x + 1; xx++)
                    {
                        for (int yy = y - 1; yy <= y + 1; yy++)
                        {
                            Color c = img.GetPixel(xx, yy);
                            if (xx == x && yy == y)
                            {
                                r += (8 * c.R);
                                g += (8 * c.G);
                                b += (8 * c.B);
                            }
                            else
                            {
                                r -= c.R;
                                g -= c.G;
                                b -= c.B;
                            }
                        }
                    }
                    if (r < 0)
                        r = 0;
                    else if (r > 255)
                        r = 255;

                    if (g < 0)
                        g = 0;
                    else if (g > 255)
                        g = 255;

                    if (b < 0)
                        b = 0;
                    else if (b > 255)
                        b = 255;
                    outImg.SetPixel(x, y, Color.FromArgb(r, g, b));
                }
            }
            return outImg;
        }

        public static Bitmap threshold(Bitmap img, int threshVal)
        {
            Bitmap outImg = new Bitmap(img, img.Width, img.Height);

            for (int x = 0; x < img.Width - 1; x++)
            {
                for (int y = 0; y < img.Height - 1; y++)
                {
                    Color c = img.GetPixel(x, y);
                    int gray = (int)Math.Floor(0.21 * c.R + 0.72 * c.G + 0.07 * c.B);
                    if (gray < threshVal)
                        outImg.SetPixel(x, y, Color.FromArgb(0, 0, 0));
                    else
                        outImg.SetPixel(x, y, Color.FromArgb(255, 255, 255));
                }
            }
            return outImg;
        }

        public static Bitmap tint(Bitmap img, Color tintColor)
        {
            Bitmap outImg = new Bitmap(img, img.Width, img.Height);

            for (int x = 0; x < img.Width - 1; x++)
            {
                for (int y = 0; y < img.Height - 1; y++)
                {
                    Color c = img.GetPixel(x, y);
                    int r=c.R, g=c.G, b=c.B;
                    r = (int)(r + tintColor.R * 0.25);
                    g = (int)(g + tintColor.G * 0.25);
                    b = (int)(b + tintColor.B * 0.25);

                    r = (r > 255) ? 255 : r;
                    g = (g > 255) ? 255 : g;
                    b = (b > 255) ? 255 : b;

                    r = (r < 0) ? 0 : r;
                    g = (g < 0) ? 0 : g;
                    b = (b < 0) ? 0 : b;

                    outImg.SetPixel(x, y, Color.FromArgb(r, g, b));
                }
            }
            return outImg;
        }

    }
}
