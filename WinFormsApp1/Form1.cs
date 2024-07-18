using ClassLibrary1;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "yu" && textBox2.Text == "yu")
            {
                MessageBox.Show(textBox1.Text + "  Login Success");

                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            }
            if (textBox1.Text != "yu")
            {
                MessageBox.Show(textBox1.Text + "  not exists");
            }
            else if (textBox2.Text != "yu")
            {
                MessageBox.Show("Password error");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Text = "»¶Ó­Ê¹ÓÃµÇÂ¼Ò³Ãæ£¡";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ÍË³öµÇÂ¼");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}