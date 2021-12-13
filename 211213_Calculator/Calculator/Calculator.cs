using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            int number1 = 10;
            int number2 = 10;

            int sum = number1 + number2;

            label1.Text = sum.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number1 = Convert.ToInt32(textBox1.Text);
            int number2 = Convert.ToInt32(textBox2.Text);

            /*int sum = number1 + number2;*/
            int sum = Add(number1, number2);

            result.Text = sum.ToString();

        }
        public int Add(int number1, int number2)
        {
            int sum = number1 + number2;
            return sum;
        }
    }
}