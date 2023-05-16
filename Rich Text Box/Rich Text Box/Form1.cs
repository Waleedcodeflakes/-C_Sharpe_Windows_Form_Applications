using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rich_Text_Box
{
    public partial class Form1 : Form
    {
        int index =-1;
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Add (richTextBox1.Text);
           /* for(int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            {

             richTextBox1.Text = checkedListBox1.CheckedItems.ToString();
            }*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(checkedListBox1.Text);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Load images from disk
            label4.Text = index.ToString();
            imageList1.Images.Add(Image.FromFile(@"C:\Users\Waleed Ahmed\Pictures\Camera Roll\WIN_20230411_10_41_25_Pro.jpg"));
            imageList1.Images.Add(Image.FromFile(@"C:\Users\Waleed Ahmed\Pictures\Camera Roll\WIN_20230411_10_41_24_Pro.jpg"));
            imageList1.Images.Add(Image.FromFile(@"C:\Users\Waleed Ahmed\Pictures\Camera Roll\WIN_20230327_10_57_51_Pro.jpg"));
        }
        private void button3_Click(object sender, EventArgs e)
        {
            //Code: show previous image
            if(index >= 0 && index < imageList1.Images.Count)
            {
                index--;
                pictureBox1.Image = imageList1.Images[index];
            } else
            {
                MessageBox.Show("No other image on left available!");
            }
            label4.Text = index.ToString();   //Handle PREVIOUS index of image
        }


        private void button4_Click(object sender, EventArgs e)
        {
            //Code for NEXT btn:
            //pictureBox1.Image = imageList1.Images[++index];
            if ( index < imageList1.Images.Count)
            {
                index++;
                pictureBox1.Image = imageList1.Images[index];
            }
            else
            {
                MessageBox.Show("No other image on right available!");
            }
            label3.Text = index.ToString();    //Handle NEXT index of image

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
    
}
