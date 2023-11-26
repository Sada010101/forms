using Saadat_Form;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Load += Form1_Load;
        }



        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string log = "123";
            string pws = "123";

            if (textBox1.Text == log && textBox2.Text == pws)
            {
                Form3 form3 = new Form3();
                form3.Show();
                Hide();
            }
            else
            {
                label2.Visible = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
