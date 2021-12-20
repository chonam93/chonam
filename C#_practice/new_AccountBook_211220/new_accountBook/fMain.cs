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
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void btn_fIN_Click(object sender, EventArgs e)
        {
            fIN f = new fIN();

            DialogResult result = f.ShowDialog();

            if(result == DialogResult.OK)
            {
                DateTime 입력일 = f.tbDate.Value;
                string 분류 = f.tbType.Text;
                string 금액 = f.tbAmt.Text;
                string 비고 = f.tbMemo.Text;

                //데이터 추가
                long 금액1 = long.Parse(금액);

                string 입금액 = 금액1.ToString("N0"); // string으로 입력된 금액을 long으로 변환 후 3자리씩 끊은 뒤 문자열로 다시 변환 후 입력

                ListViewItem lv = lv1.Items.Add(입력일.ToShortDateString());
                lv.SubItems.Add(분류); 
                lv.SubItems.Add(입금액);
                lv.SubItems.Add("");
                lv.SubItems.Add(비고);



            }

        }

        private void btn_fOUT_Click(object sender, EventArgs e)
        {
            fOUT f = new fOUT();

            DialogResult result = f.ShowDialog();

            if (result == DialogResult.OK)
            {
                DateTime 입력일 = f.tbDate.Value;
                string 분류 = f.tbType.Text;
                string 금액 = f.tbAmt.Text;
                string 비고 = f.tbMemo.Text;

                //데이터 추가
                long 금액1 = long.Parse(금액);

                string 출금액 = 금액1.ToString("N0"); // string으로 입력된 금액을 long으로 변환 후 3자리씩 끊은 뒤 문자열로 다시 변환 후 입력

                ListViewItem lv = lv1.Items.Add(입력일.ToShortDateString());
                lv.SubItems.Add(분류);
                lv.SubItems.Add("");
                lv.SubItems.Add(출금액);
                lv.SubItems.Add(비고);



            }
        }

        private void btn_fEdit_Click(object sender, EventArgs e)
        {
            edit_data();
        }

        void edit_data()
        {
            //선택한 데이터가 없을 때
            if(lv1.SelectedItems.Count < 1)
            {
                MessageBox.Show("편집할 데이터를 선택하세요.");
                return;
            }

            //선택데이터 구분
            ListViewItem lv = lv1.SelectedItems[0];
            string 날짜 = lv.SubItems[0].Text;
            string 분류 = lv.SubItems[1].Text;
            string 입금액 = lv.SubItems[2].Text;
            string 출금액 = lv.SubItems[3].Text;
            string 비고 = lv.SubItems[4].Text;

            //입금 데이터 선택 시..
            if (입금액 != "")
            {
                //입금 화면 호출하고 수정 후 다시 저장
                fIN f = new fIN(날짜, 분류, 입금액, 비고);
                if (f.ShowDialog() == DialogResult.OK)
                {
                    lv.SubItems[0].Text = f.tbDate.Value.ToShortDateString();
                    lv.SubItems[1].Text = f.tbType.Text;

                    string 입금값 = f.tbAmt.Text.Replace(",", "");
                    long 숫자 = long.Parse(입금값);

                    lv.SubItems[2].Text = 숫자.ToString("N0");
                    lv.SubItems[3].Text = "";
                    lv.SubItems[4].Text = f.tbMemo.Text;
                }
            }

            else
            {
                fOUT f = new fOUT(날짜, 분류, 출금액, 비고);
                if (f.ShowDialog() == DialogResult.OK)
                {
                    lv.SubItems[0].Text = f.tbDate.Value.ToShortDateString();
                    lv.SubItems[1].Text = f.tbType.Text;

                    string 출금값 = f.tbAmt.Text.Replace(",", "");
                    long 숫자 = long.Parse(출금값);

                    lv.SubItems[2].Text = "";
                    lv.SubItems[3].Text = 숫자.ToString("N0");
                    lv.SubItems[4].Text = f.tbMemo.Text;
                }
            }

            MessageBox.Show("편집 완료");
        }

        private void btn_fDelete_Click(object sender, EventArgs e)
        {
            delete_data();
        }
        void delete_data()
        {
            //선택한 데이터가 없을 때
            if (lv1.SelectedItems.Count < 1)
            {
                MessageBox.Show("삭제할 데이터를 선택하세요.");
                return;
            }
            //선택데이터 구분
            ListViewItem lv = lv1.SelectedItems[0];
            string 날짜 = lv.SubItems[0].Text;
            string 분류 = lv.SubItems[1].Text;
            string 입금액 = lv.SubItems[2].Text;
            string 출금액 = lv.SubItems[3].Text;
            string 비고 = lv.SubItems[4].Text;
            string 표시금액 = 입금액;
            if (표시금액 == "") 표시금액 = 출금액;

            string 메세지 = "정말 삭제하시겠습니까?\n" +
                            "분류 = " + 분류 + "\n" +
                            "금액 = " + 표시금액;

            DialogResult result = MessageBox.Show(메세지, "삭제확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                lv1.Items.Remove(lv);
                MessageBox.Show("삭제완료");
            }
        }
    }
}
