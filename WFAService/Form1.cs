using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAService
{
    public partial class Form1 : Form
    {

        ServiceReferenceWPC.Service1Client cal = new ServiceReferenceWPC.Service1Client();



        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(cal.WebAdd(int.Parse(textBox1.Text),
int.Parse(textBox2.Text)));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(cal.WebMultiply(int.Parse(textBox1.Text),
int.Parse(textBox2.Text)));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(int.Parse(textBox2.Text) == 0)
            {
                textBox3.Text = "undefined";
            }
            else
            {
                textBox3.Text = Convert.ToString(cal.WebDivision(int.Parse(textBox1.Text),
int.Parse(textBox2.Text)));
            }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(cal.WebSoustraction(int.Parse(textBox1.Text),
int.Parse(textBox2.Text)));
        }
    }
}
