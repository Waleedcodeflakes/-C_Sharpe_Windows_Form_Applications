using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Age_calculator
{
    public partial class Form1 : Form
    {
        void themeChanger(Color c)
        {
            button1.BackColor = c;
            button2.BackColor = c;
            button3.BackColor = c;
            button4.BackColor = c;
            button5.BackColor = c;
            button6.BackColor = c;
            this.BackColor = c;
            this.ForeColor = Color.White;
        }
        public Form1()
        {
            InitializeComponent();
        }
        char color;
        private void button1_Click(object sender, EventArgs e)
        {
            //Shows current date
            MessageBox.Show(dateTimePicker1.Value.Date.ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Shows total years.
            int years = dateTimePicker1.Value.Year;
            int currentYear = dateTimePicker2.Value.Year;
           int totalYears =  years- currentYear;
            MessageBox.Show(totalYears.ToString() + " years");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Shows total months.
            int months = dateTimePicker1.Value.Month;
            int currentMonths = dateTimePicker2.Value.Month;
            int totalYears = months - currentMonths;
            MessageBox.Show(currentMonths.ToString() + " months");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Shows total days.
            int days = dateTimePicker1.Value.Day;
            int currentDay = dateTimePicker2.Value.Day;
            int totalDays = days - currentDay;
            MessageBox.Show(totalDays.ToString() + " days");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Shows current date of birth.
            MessageBox.Show(dateTimePicker2.Value.Date.ToString());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            button6.BackColor= colorDialog1.Color;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                themeChanger(Color.White);
                this.ForeColor = Color.Black;
            }
            else if (textBox1.Text == "1")
            {
                themeChanger(Color.Red);
                //button1.BackColor = Color.Red;
                //button1.ForeColor = Color.White;
            }
            else if (textBox1.Text == "2")
            {
                themeChanger(Color.Green);

               // button1.BackColor = Color.Green;
                //button1.ForeColor = Color.White;
            }
            else if (textBox1.Text == "3")
            {
                themeChanger(Color.Blue);
            }
            else if (textBox1.Text == "4")
            {
                themeChanger(Color.Yellow);
                this.ForeColor = Color.Black;


            }
            else if (textBox1.Text == "5")
            {
                themeChanger(Color.Aqua);
                this.ForeColor = Color.Black;

            }
            else if (textBox1.Text == "6")
            {
                themeChanger(Color.Indigo);
            }
            
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
