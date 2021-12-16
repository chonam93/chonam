using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace study_string
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strText = lbText.Text.ToString();
            lbContain.Text = strText.Contains("Text").ToString();
            lbEquals.Text = strText.Equals("Text").ToString();
            lbLength.Text = strText.Length.ToString();
            lbReplace.Text = strText.Replace("Test", "i can").ToString();

            string[] strSplit = strText.Split(',');
            lbSplit.Text = strSplit[0].ToString();
            lbSplit2.Text = strSplit[1].ToString();
            lbSplit3.Text = strSplit[2].ToString();

            lbSubstring.Text = strText.Substring(3, 5).ToString();
            lbToLower.Text = strText.ToLower().ToString();
            lbToUpper.Text = strText.ToUpper().ToString();

            lbTrim.Text = strText.Trim().ToString();

        }
    }
}
