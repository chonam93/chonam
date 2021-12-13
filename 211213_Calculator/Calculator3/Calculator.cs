using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator3
{

    public enum Operators { Add, Sub, Multi, Div }

    public partial class Calculator : Form
    {
        public int Result = 0;
        public bool isNewNum = true;
        public Operators Opt = Operators.Add;

        public Calculator()
        {
            InitializeComponent();
        }
        public void SetNum(string num)
        {
            /*대기화면이 0일 경우 num으로 바꿔주고 시작*/
            if (isNewNum)
            {
                NumScreen.Text = num;
                isNewNum = false;
            }
            else if (NumScreen.Text == "0")
            {
                NumScreen.Text = num;
            }
            else
            {
                NumScreen.Text = NumScreen.Text + num;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Button numButton = (Button)sender;
            SetNum(numButton.Text);

        }

        private void NumPlus_Click(object sender, EventArgs e)
        {
            Button optButton = (Button)sender;
            if (optButton.Text == "+")
                Opt = Operators.Add;
            else if (optButton.Text == "-")
                Opt = Operators.Sub;
            else if (optButton.Text == "x")
                Opt = Operators.Multi;
            else if (optButton.Text == "%")
                Opt = Operators.Div;

            if (isNewNum == false)
            {
                int num = int.Parse(NumScreen.Text);
                if (Opt == Operators.Add)
                    Result = Result + num;
                else if (Opt == Operators.Sub)
                    Result = Result - num;
                else if (Opt == Operators.Multi)
                    Result = Result * num;
                else if (Opt == Operators.Div)
                    Result = Result / num;
                NumScreen.Text = Result.ToString();
                /*새로운넘버입력*/
                isNewNum = true;
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Result = 0;
            isNewNum = true;
            Opt = Operators.Add;
            NumScreen.Text = "0";
        }
    }
}
