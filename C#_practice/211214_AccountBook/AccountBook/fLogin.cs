using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountBook
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //확인 개발자 1234만 로그인 가능하게
            if (tbName.Text == "개발자" && tbPassword.Text == "1234")
            {
                DialogResult = System.Windows.Forms.DialogResult.OK; //자신의 결과를 밖에 내보내는 경우 (버튼누르면 ok가 나간다)
            }
            else
            {
                MessageBox.Show("등록되지 않은 사용자이거나 암호가 일치하지 않습니다","확인",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                tbPassword.Focus();
                tbPassword.SelectAll();
            }

        }

        private void tbName_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                //입력값체크
                if (tbName.Text != "") tbPassword.Focus();
                
            }
        }

        private void tbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //입력값체크
                if (this.tbPassword.Text != "") btnOK.Focus();

            }
        }
    }
}
