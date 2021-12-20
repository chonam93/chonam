using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace new_accountBook
{
    public partial class fIN : Form
    {
        public fIN()
        {
            InitializeComponent();
        }
        public fIN(string 날짜, string 분류, string 금액, string 비고)
        {
            InitializeComponent();
            tbDate.Value = DateTime.Parse(날짜);
            tbType.Text = 분류;
            tbAmt.Text = 금액;
            tbMemo.Text = 비고;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
