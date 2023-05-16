using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Image_List_Box
{
    public partial class Form1 : Form
    {
        int index= -1;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Code: show previous image
            if (index >= 0 && index < imageList1.Images.Count)
            {
                index--;
                pictureBox1.Image = imageList1.Images[index];
                pictureBox2.Image = imageList1.Images[index+1];
                pictureBox3.Image = imageList1.Images[index+2];
            }
            else
            {
                MessageBox.Show("No other image on left available!");
            }
            label1.Text = index.ToString();   //Handle PREVIOUS index of image

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Code: show previous image
            if ( index < imageList1.Images.Count)
            {
                index++;
                pictureBox1.Image = imageList1.Images[index];
                pictureBox2.Image = imageList1.Images[index+1];
                pictureBox3.Image = imageList1.Images[index + 2];
            }
            else
            {
                MessageBox.Show("No other image on Right available!");
            }
            label2.Text = index.ToString();   //Handle NEXT index of image

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Load images from disk
            label2.Text = index.ToString();
            imageList1.Images.Add(Image.FromFile(@"C:\Users\Waleed Ahmed\Pictures\Camera Roll\WIN_20230411_10_41_25_Pro.jpg"));
            imageList1.Images.Add(Image.FromFile(@"C:\Users\Waleed Ahmed\Pictures\Camera Roll\WIN_20230411_10_41_24_Pro.jpg"));
            imageList1.Images.Add(Image.FromFile(@"C:\Users\Waleed Ahmed\Pictures\Camera Roll\WIN_20230327_10_57_51_Pro.jpg"));
            imageList1.Images.Add(Image.FromFile(@"C:\Users\Waleed Ahmed\Pictures\Camera Roll\WIN_20230411_10_41_25_Pro.jpg"));
            imageList1.Images.Add(Image.FromFile(@"C:\Users\Waleed Ahmed\Pictures\Camera Roll\WIN_20230411_10_41_24_Pro.jpg"));
            imageList1.Images.Add(Image.FromFile(@"C:\Users\Waleed Ahmed\Pictures\Camera Roll\WIN_20230327_10_57_51_Pro.jpg"));
            imageList1.Images.Add(Image.FromFile(@"C:\Users\Waleed Ahmed\Pictures\Camera Roll\WIN_20230411_10_41_25_Pro.jpg"));
            imageList1.Images.Add(Image.FromFile(@"C:\Users\Waleed Ahmed\Pictures\Camera Roll\WIN_20230411_10_41_24_Pro.jpg"));
            imageList1.Images.Add(Image.FromFile(@"C:\Users\Waleed Ahmed\Pictures\Camera Roll\WIN_20230327_10_57_51_Pro.jpg"));

        }
    }
}
