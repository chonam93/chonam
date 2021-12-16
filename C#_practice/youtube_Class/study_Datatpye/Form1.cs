using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace study_Datatpye
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShort_Click(object sender, EventArgs e)
        {
            try
            {
                short shortnum = short.Parse(tbText.Text);
                lbShort.Text = shortnum.ToString();
                lbException.Text = "-";

            }
            catch (Exception ex)
            {
                lbException.Text = ex.ToString();
            }



        }

        private void btnInt_Click(object sender, EventArgs e)
        {
            try
            {
                int intnum = int.Parse(tbText.Text);
                lbInt.Text = intnum.ToString();
                lbException.Text = "-";

            }
            catch (Exception ex)
            {
                lbException.Text = ex.ToString();
            }
        }

        private void btnDouble_Click(object sender, EventArgs e)
        {
            try
            {
                double doublenum = double.Parse(tbText.Text);
                lbDouble.Text = doublenum.ToString();
                lbException.Text = "-";

            }
            catch (Exception ex)
            {
                lbException.Text = ex.ToString();
            }
        }

        private void btenConfirm_Click(object sender, EventArgs e)
        {
            lbShort.Text = "0";
            lbInt.Text = "0";
            lbShort.Text = "0";
            short snum = 0;
            int inum = 0;
            double dnum = 0;

            if (short.TryParse(tbText.Text, out snum))
            {
                lbShort.Text = snum.ToString();
            }
            else if (int.TryParse(tbText.Text, out inum))
            {
                lbInt.Text = inum.ToString();
            }
            else if (double.TryParse(tbText.Text, out dnum))
            {
                lbDouble.Text = dnum.ToString();
            }
            else
            {
                lbException.Text = "변환할수 없다리";
            }
        }
        public class Solution
        {
            public long solution(int a, int b)
            {
                long answer = 0;
                
                if (a < b)
                {
                    for(int i = a; i<=b;i++)
                    {
                        answer += a;
                    }
                }
                    
                    /*{
                    for ( a; a <= b; a++)
                    {
                        answer += a;
                    }
                }

                else if (a > b)
                {
                    for (b; b <= a; b++)
                    {
                        answer += b;
                    }
                }

                else if (a == b)
                {
                    answer = a;
                }*/
                return answer;
            }
        }

    }
}
