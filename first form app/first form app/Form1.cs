namespace first_form_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to psl");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Review Taken");
            button1.Enabled = false;
        }
    }
}