using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace checkListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool found=false;
        string fruits;
        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
                MessageBox.Show(checkedListBox1.CheckedItems[i].ToString());
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        /*{
            for (int i = 0; i<checkedListBox1.Items.Count; i++)
            {
 found = false;
                for (int j = 0; j<checkedListBox1.CheckedItems.Count; j++)
                {
                    if (checkedListBox1.Items[i].ToString() == checkedListBox1.CheckedItems[j].ToString())
                    {
                        found = true;
                    }}

if (found == false)
{
    fruits += checkedListBox1.Items[i].ToString() + " ";
} }
MessageBox.Show("Fruits unchecked are " + fruits);
 }*/
        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                found = false;
                for (int j = 0; j < checkedListBox1.CheckedItems.Count; j++)
                {
                    if (checkedListBox1.Items[i].ToString() == checkedListBox1.CheckedItems[j].ToString())
                    {
                        found = true;
                    }
                }
                if (found == false)
                {
                    fruits += checkedListBox1.Items[i].ToString() + " ";
                    
                }

            }
                MessageBox.Show(fruits);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length <= 6)
            checkedListBox1.Items.Add(textBox1.Text);
            else
            {
                MessageBox.Show("limit excedes");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Remove(textBox1.Text);

        }

        private
            void button5_Click(object sender, EventArgs e)
        {
            string listofItems="";
            for(int i = 0; i < comboBox1.Items.Count; i++)
            {
                if(i==comboBox1.Items.Count-1)
                listofItems += comboBox1.Items[i].ToString()+ " ";
                else
                {
                    listofItems += comboBox1.Items[i].ToString() + ", ";

                }
            }
            MessageBox.Show(listofItems);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Text = "Country";
           // comboBox1.Text = comboBox1.Items[comboBox1.Items.Count-1].ToString();
        }
    }
}
