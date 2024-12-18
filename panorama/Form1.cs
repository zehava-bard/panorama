using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Stitching;
using Emgu.CV.Structure;
using System.IO;
using System.Numerics;
using System.Windows.Forms;

namespace panorama
{
    public partial class Form1 : Form
    {
        Mat[] imgs=new Mat[3];
        Mat pano = new Mat();
        public Form1()
        {
            InitializeComponent();
        }

        private void image1_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                imgs[0] = CvInvoke.Imread(filePath);
                CvInvoke.Resize(imgs[0], imgs[0], image1_pb.Size);
                image1_pb.Image = imgs[0].ToBitmap();
                image1_pb.Visible = true;
            }
        }

        private void image2_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                imgs[1] = CvInvoke.Imread(filePath);
                CvInvoke.Resize(imgs[1], imgs[1], image2_pb.Size);
                image2_pb.Image = imgs[1].ToBitmap();
                image2_pb.Visible = true;
            }
        }

        private void image3_btn_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                imgs[2] = CvInvoke.Imread(filePath);
                CvInvoke.Resize(imgs[2], imgs[2], image3_pb.Size);
                image3_pb.Image = imgs[2].ToBitmap();
                image3_pb.Visible = true;
            }
        }

        private void stitcher_btn_Click(object sender, EventArgs e)
        {
            

            try
            {
                using (var stitcher = new Stitcher(Stitcher.Mode.Panorama))
                using (var vectorOfMat = new Emgu.CV.Util.VectorOfMat())
                {
                    foreach (var img in imgs)
                    {
                        vectorOfMat.Push(img);
                    }
                    if(vectorOfMat.Length<3)
                    {
                        MessageBox.Show("enter 3 images");
                        return;
                    }
                    var status = stitcher.Stitch(vectorOfMat, pano);
                    if (status == (int)Stitcher.Status.Ok)
                    {
                        Mat a = pano;
                        CvInvoke.Resize(a, a, res_pb.Size);
                        res_pb.Image = a.ToBitmap();
                        res_pb.Visible = true;
                        CvInvoke.Imshow("panorama", pano);
                        MessageBox.Show("Panorama created successfully!");
                    }
                    else
                    {
                        MessageBox.Show($"Stitching failed: {status}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
