using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CBS_Management_Assignmt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool found = false;
        string removemember;
        string addexecutive;

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == string.Empty)
            {
                MessageBox.Show("Write Name of member first!");
            }
            else if (textBox1.Text != string.Empty)
            {
                checkedListBox1.Items.Add(textBox2.Text);
                MessageBox.Show("Member added successfully!");
            }
            else
            {
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    if (textBox2.Text == checkedListBox1.Items[i].ToString())
                    {
                        MessageBox.Show("Already exists");
                    }
                    else
                    {

                    }

                }
            
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Remove(checkedListBox1.Text);
            comboBox1.Items.Remove(checkedListBox1.Text);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
    
            comboBox1.Items.Add(checkedListBox1.Text);
               
      
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == comboBox1.Text)
                MessageBox.Show("Same President Already exists.");
            else
            {
                MessageBox.Show("Do you want to change President?");
                
            textBox1.Text =comboBox1.Text;
            }

        }
    }
}
