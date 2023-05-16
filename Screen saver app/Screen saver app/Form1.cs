using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Screen_saver_app
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
            int x = 0, y = 0;
            /*for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    x++; y++;
                    button1.Location = new Point(x, y);
                    button2.Location = new Point(x, y);
                    button3.Location = new Point(x, y);
                    button4.Location = new Point(x, y);
                }

            }*/
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        int size = this.Size.Width;
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
                    button3.Location = new Point(x, y);
                }

            }
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    x--; y++;
                    button4.Location = new Point(x, y);
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
                    button4.Location = new Point(x, y);
                }

            }
        }
    }
}
