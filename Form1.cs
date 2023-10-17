using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _10.Compute_the_sum_of_three_given_integers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CenterToParent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                int num1 = int.Parse(textBox1.Text);
                int num2 = int.Parse(textBox2.Text);
                int num3 = int.Parse(textBox3.Text);

                int sum = num1 + num2 + num3;

                if (num1 == num2 || num1 == num3 || num2 == num3)
                {
                    textBox4.Text = num3.ToString();
                }
                else
                {
                    textBox4.Text = sum.ToString();
                }
            }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
             textBox2.Clear();   
             textBox3.Clear();
             textBox4.Clear();
        }
    }
}
