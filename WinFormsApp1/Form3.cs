using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3(string text)
        {
            InitializeComponent();
            this.label1.Text = text + "_pt";
            this.label2.Text = text + "_mo";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.toolStripStatusLabel1.Text = DateTime.Now.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = "";
            foreach (var item in this.panel1.Controls)
            {
                if(item is CheckBox)
                {
                    CheckBox? checkBox = item as CheckBox;    
                    if (checkBox.Checked)
                    {
                        str += checkBox.Text + ",";
                    }
                }
            }
            if (str.Length > 0)
            {
                MessageBox.Show(str.Substring(0, str.Length - 1));
            }
            else
            {
                MessageBox.Show("勾选的项为空");
            }
        }
    }
}
