using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int add(int a, int b)
        {
            return a + b;
        }
        int minus(int a, int b)
        {
            return a - b;
        }

        delegate int Calc_dele(int a, int b);
        


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int nResult;
            Calc_dele calc = new Calc_dele(add);
            nResult = calc(20, 10);

            Console.WriteLine("result = " + nResult);

            calc = new Calc_dele(minus);
            nResult = calc(20, 10);

            Console.WriteLine("result = " + nResult);



        }
    }
}
