using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator2
{
    public partial class Calculator2 : Form
    {
        public Calculator2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number1 = 0;
            int number2 = 0;

            if (String.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("textBox1에 숫자를 입력하세요.");
                textBox1.Focus();
                return;
            }


            if (int.TryParse(textBox1.Text, out number1) == false)
            {
                MessageBox.Show("textBox1에 문자가 들어왔습니다. 숫자를 입력해주세요.");
                textBox1.SelectAll();
                textBox1.Focus();
                return;
            }


            if (String.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("textBox2에 숫자를 입력하세요.");
                textBox2.Focus();
                return;
            }

            if (int.TryParse(textBox2.Text, out number2) == false)
            {
                MessageBox.Show("textBox2에 문자가 들어왔습니다. 숫자를 입력해주세요.");
                textBox2.SelectAll();
                textBox2.Focus();
                return;
            }
            
/*

            number1 = Convert.ToInt32(textBox1.Text);
            number2 = Convert.ToInt32(textBox2.Text);
*/
            /*int sum = number1 + number2;*/
            int sum = Add(number1, number2);
             
            ResultBox.Text = sum.ToString();

        }
        public int Add(int number1, int number2)
        {
            int sum = number1 + number2;
            return sum;
        }

        public float Add(float number1, float number2)
        {
            float sum = number1 + number2;
            return sum;
        }

        public int Sub(int number1, int number2)
        {
            int sub = number1 - number2;
            return sub;
        }
    }
}
