using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace new_Calculator_1214
{
    public partial class Form1 : Form
    {
        private double saved;
        private double memory;
        private char op = '\0';
        private bool opFlag = false;
        private bool percentFlag;

        public Form1()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string s = btn.Text;

            if (textBox1.Text == "0" || opFlag == true)
            {
                textBox1.Text = s;
                opFlag = false;
            }
            else
                textBox1.Text = textBox1.Text + s;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            saved = Double.Parse(textBox1.Text);
        }
    }
}
