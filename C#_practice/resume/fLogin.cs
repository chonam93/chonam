using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace resume
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if(tbID.Text == "admin" && tbPass.Text == "1234")
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("ID 혹은 PW가 일치하지 않습니다. 다시 시도하시기 바랍니다.", "확인", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbPass.Focus();
                tbPass.SelectAll();
                return;
            }
        }
        private void tbID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (tbID.Text != "") tbPass.Focus();
            }
        }

        private void tbPW_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (tbPass.Text != "") btnOK.Focus();
            }
        }

    }
}
