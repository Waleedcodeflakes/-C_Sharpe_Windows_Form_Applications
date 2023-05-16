using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Screen_Saver
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x =0 , y = 0;
            int size = this.Size.Height;
            /*while (x!=this.Size.Width && y!=this.Size.Height)
            {
                
            }*/
            for (int i = 0; i < size; i++)
            {
/*                for (int j = 0; j < size; j++)
*/                {
                    x++; y++;
                    button1.Location = new Point(x, y);
                    if (y == 403 )
                    {
                        x++;y--;
                    button1.Location = new Point(x, y);
                    }
                     if(x == 191)
                    {
                        x--; y++;
                        button1.Location = new Point(x, y);

                    }
                    
                    /*
                    button2.Location = new Point(x, y);
                    button3.Location = new Point(x, y);
                    button4.Location = new Point(x, y);*/
                }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int size = this.Size.Height;
            int x = 0, y = 0;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    x++; y++;
                    button1.Location = new Point(x, y);
                }

            }
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    x--; y++;
                    button2.Location = new Point(x, y);
                }

            }
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    x++; y--;
                    /*button3.Location = new Point(x, y);*/
                }

            }
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    x--; y++;
                    /*button4.Location = new Point(x, y);*/
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int size = this.Size.Width;
            int x = 0, y = 0;

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    x--; y++;
/*                    button4.Location = new Point(x, y);
*/                }

            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            label2.Text = folderBrowserDialog1.SelectedPath;
            /*label2.Font = fontDialog1.Font;*/

        }

        private void button5_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            label2.Font = fontDialog1.Font;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
