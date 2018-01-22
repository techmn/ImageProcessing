using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace BasicImageProcessing
{
    public partial class Form1 : Form
    {
        private Bitmap curImg, prevImg;
        private int threshVal;
        private Color tintColor;

        private delegate void showImageDelegate(PictureBox picBox);

        private enum operation { GRAYSCALE, NEGATIVE, SEPIA, BLUR, EDGE, THRESH, TINT };

        public Form1()
        {
            InitializeComponent();
            threshVal = thresholdBar.Value;
            tintColor = Color.FromArgb(redTintBar.Value, greenTintBar.Value, blueTintBar.Value);
        }

        private void processImage(object op)
        {
            switch ((int)op)
            {
                case (int)operation.GRAYSCALE:
                    curImg = ImageOperation.grayScale(curImg);
                    showImage(imgBox);
                    break;
                case (int)operation.NEGATIVE:
                    curImg = ImageOperation.negative(curImg);
                    showImage(imgBox);
                    break;
                case (int)operation.SEPIA:
                    curImg = ImageOperation.sepia(curImg);
                    showImage(imgBox);
                    break;
                case (int)operation.BLUR:
                    curImg = ImageOperation.blur(curImg);
                    showImage(imgBox);
                    break;
                case (int)operation.EDGE:
                    curImg = ImageOperation.detectEdges(curImg);
                    showImage(imgBox);
                    break;
                case (int)operation.THRESH:
                    curImg = ImageOperation.threshold(curImg, threshVal);
                    showImage(imgBox);
                    break;
                case (int)operation.TINT:
                    curImg = ImageOperation.tint(curImg, tintColor);
                    showImage(imgBox);
                    break;
            }
        }

        private void showImage(PictureBox picBox)
        {
            if (picBox.InvokeRequired)
            {
                showImageDelegate d = new showImageDelegate(showImage);
                this.Invoke(d, new object[] { picBox });
            }
            else
                picBox.BackgroundImage = curImg;
        }

        private void browseFileBtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.InitialDirectory = "C:\\";
                ofd.Filter = "jpg files (*.jpg)|*.jpg|png files (*.png)|*.png|bmp files (*.bmp)|*.bmp|All image files (*.jpg;*.png;*.bmp)|*.jpg;*.png;*.bmp";
                ofd.Multiselect = false;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string imgPath = ofd.FileName;
                    if (imgPath.EndsWith(".jpg") | imgPath.EndsWith(".png") | imgPath.EndsWith(".bmp"))
                    {
                        curImg = new Bitmap(imgPath);
                        prevImg = new Bitmap(curImg);
                        imgBox.BackgroundImage = curImg;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void undoBtn_Click(object sender, EventArgs e)
        {
            curImg = prevImg;
            imgBox.BackgroundImage = curImg;
        }

        private void grayScaleBtn_Click(object sender, EventArgs e)
        {
            if (curImg != null)
            {
                imgBox.BackgroundImage = BasicImageProcessing.Properties.Resources.processing;
                prevImg = curImg;
                Thread t = new Thread(new ParameterizedThreadStart(processImage));
                t.Start((int)operation.GRAYSCALE);
            }
        }

        private void negativeBtn_Click(object sender, EventArgs e)
        {
            if (curImg != null)
            {
                imgBox.BackgroundImage = BasicImageProcessing.Properties.Resources.processing;
                prevImg = curImg;
                Thread t = new Thread(new ParameterizedThreadStart(processImage));
                t.Start((int)operation.NEGATIVE);
            }
        }

        private void sepiaBtn_Click(object sender, EventArgs e)
        {
            if (curImg != null)
            {
                imgBox.BackgroundImage = BasicImageProcessing.Properties.Resources.processing;
                prevImg = curImg;
                Thread t = new Thread(new ParameterizedThreadStart(processImage));
                t.Start((int)operation.SEPIA);
            }
        }

        private void blurBtn_Click(object sender, EventArgs e)
        {
            if (curImg != null)
            {
                imgBox.BackgroundImage = BasicImageProcessing.Properties.Resources.processing;
                prevImg = curImg;
                Thread t = new Thread(new ParameterizedThreadStart(processImage));
                t.Start((int)operation.BLUR);
            }
        }

        private void edgeBtn_Click(object sender, EventArgs e)
        {
            if (curImg != null)
            {
                imgBox.BackgroundImage = BasicImageProcessing.Properties.Resources.processing;
                prevImg = curImg;
                Thread t = new Thread(new ParameterizedThreadStart(processImage));
                t.Start((int)operation.EDGE);
            }
        }

        private void thresholdBar_Scroll(object sender, EventArgs e)
        {
            threshVal = thresholdBar.Value;
        }

        private void thresholdBtn_Click(object sender, EventArgs e)
        {
            if (curImg != null)
            {
                imgBox.BackgroundImage = BasicImageProcessing.Properties.Resources.processing;
                prevImg = curImg;
                Thread t = new Thread(new ParameterizedThreadStart(processImage));
                t.Start((int)operation.THRESH);
            }
        }

        private void tintBar_Scroll(object sender, EventArgs e)
        {
            tintColor = Color.FromArgb(redTintBar.Value, greenTintBar.Value, blueTintBar.Value);
        }

        private void tintBtn_Click(object sender, EventArgs e)
        {
            if (curImg != null)
            {
                imgBox.BackgroundImage = BasicImageProcessing.Properties.Resources.processing;
                prevImg = curImg;
                Thread t = new Thread(new ParameterizedThreadStart(processImage));
                t.Start((int)operation.TINT);
            }
        }

    }
}
