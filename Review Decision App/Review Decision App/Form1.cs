using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Review_Decision_App
{
    public partial class Form1 : Form
    {
        int count = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int x, y;
            //Generate a random location
            Random r = new Random();
            //x=r.Next(100,400);
            //y = r.Next(100,400);

            //button1.Location = new Point(x.Next(), x.Next());
            //button1.Location = new Point(x,y);
            //button1.Visible = false;

            //button1.Text = button1.Location.X.ToString() + " " + button1.Location.Y.ToString();
            //button1.Location = new Point(button1.Location.X+1,button1.Location.Y+1);
            //MessageBox.Show(x.ToString()+ " " + y.ToString());


            /*
             //Match review
           if (count<3)
            {
                MessageBox.Show("review taken " + (count) + " times.");
                count++;
              }
            else
            {
                button1.Enabled = false;
                button1.Text = "Review Taken";
                
            }
            */

            MessageBox.Show(textBox1.Text);

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
            button1.Enabled = true;

            }
            else
            button1.Enabled = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;

        }
    }
}
