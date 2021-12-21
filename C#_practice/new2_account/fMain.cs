using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace new2_account
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        //로그인부분
        private void fMain_Load(object sender, EventArgs e)
        {
            this.Show(); //메인화면 띄우고
            user_Login(); //그 위에 로그인 창 실행
        }
        void user_Login()
        {
            fLogin f = new fLogin(); //객체불러오고 
            DialogResult result = f.ShowDialog(); //showdialog로 맨앞 고정
            if (result == DialogResult.OK) //로그인창 확인버튼 누르면
            {
                string 사용자명 = f.tbID.Text;
                tbName.Text = 사용자명; //아래 사용자명칸에 ID넣어주고 툴바 활성화
                fIN.Enabled = true;
                fOUT.Enabled = true;
                fEdit.Enabled = true;
                fDelete.Enabled = true;
            }
            else // 틀릴 시 비활성
            {
                fIN.Enabled = false;
                fOUT.Enabled = false;
                fEdit.Enabled = false;
                fDelete.Enabled = false;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e) //로그인상태에서 로그인 버튼 누를 경우
        {
            if (fIN.Enabled == true)
            {
                string message = "이미 접속중입니다.\n" + "ID : " + tbName.Text;
                MessageBox.Show(message);
                return;
            }
            user_Login();
        }


        private void fIN_Click(object sender, EventArgs e)
        {
            fIN f = new fIN();
            DialogResult result = f.ShowDialog();

            if(result == DialogResult.OK)
            {
                DateTime 입력일 = f.dtTime.Value;
                string 분류 = f.tbType.Text;
                string 금액 = f.tbAmt.Text;
                string 비고 = f.tbMemo.Text;

                string 입금액 = long.Parse(금액).ToString("N0");

                ListViewItem lv = listView1.Items.Add(입력일.ToShortDateString());
                lv.SubItems.Add(분류);
                lv.SubItems.Add(입금액);
                lv.SubItems.Add("");
                lv.SubItems.Add(비고);

            }

            save_data();
            summary();
        }

        private void fOUT_Click(object sender, EventArgs e)
        {
            fOUT f = new fOUT();

            DialogResult result =  f.ShowDialog();

            if (result == DialogResult.OK)
            {
                DateTime 입력일 = f.dtTime.Value;
                string 분류 = f.tbType.Text;
                string 금액 = f.tbAmt.Text;
                string 비고 = f.tbMemo.Text;

                string 출금액 = long.Parse(금액).ToString("N0");

                ListViewItem lv = listView1.Items.Add(입력일.ToShortDateString());
                lv.SubItems.Add(분류);
                lv.SubItems.Add("");
                lv.SubItems.Add(출금액);
                lv.SubItems.Add(비고);
            }
            save_data();
            summary();
        }

        private void fEdit_Click(object sender, EventArgs e)
        {
            edit_data();
            save_data();
            summary();
        }
        void edit_data()
        {
            if (listView1.SelectedItems.Count < 1)
            {
                MessageBox.Show("데이터를 선택하세요.");
                return;
            }

            //리스트 아이템 구분
            ListViewItem lv = listView1.SelectedItems[0];
            string 날짜 = lv.SubItems[0].Text;
            string 분류 = lv.SubItems[1].Text;
            string 입금액 = lv.SubItems[2].Text;
            string 출금액 = lv.SubItems[3].Text;
            string 비고 = lv.SubItems[4].Text;


            //입금 편집일 경우
            if(입금액 != "")
            {
                //입금창 띄우기
                fIN f = new fIN(날짜, 분류, 입금액, 비고);

                if(f.ShowDialog() == DialogResult.OK)
                {
                    lv.SubItems[0].Text = f.dtTime.Value.ToShortDateString();
                    lv.SubItems[1].Text = f.tbType.Text;

                    string 입금 = long.Parse(f.tbAmt.Text.Replace(",","")).ToString("N0");
                    lv.SubItems[2].Text = 입금;
                    lv.SubItems[3].Text = "";
                    lv.SubItems[4].Text = f.tbMemo.Text;
                }

            }
            else
            {
                //출금창 띄우기
                fOUT f = new fOUT(날짜, 분류, 출금액, 비고);

                if (f.ShowDialog() == DialogResult.OK)
                {
                    lv.SubItems[0].Text = f.dtTime.Value.ToShortDateString();
                    lv.SubItems[1].Text = f.tbType.Text;                    
                    lv.SubItems[2].Text = "";

                    string 출금 = long.Parse(f.tbAmt.Text.Replace(",", "")).ToString("N0");
                    lv.SubItems[3].Text = 출금;
                    lv.SubItems[4].Text = f.tbMemo.Text;
                }

            }
            
        }

        private void fDelete_Click(object sender, EventArgs e)
        {
            delete_data();
            save_data();
            summary();
        }
        void delete_data()
        {
            if (listView1.SelectedItems.Count < 1)
            {
                MessageBox.Show("데이터를 선택하세요.");
                return;
            }

            ListViewItem lv = listView1.SelectedItems[0];

            string message = "선택하신 데이터가 삭제됩니다.\n" +
                             "분류 = " + lv.SubItems[1].Text + "\n" +
                             "금액 = " + lv.SubItems[2].Text + lv.SubItems[3].Text;
            if (MessageBox.Show(message, "삭제확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                listView1.Items.Remove(lv);
                MessageBox.Show("삭제완료");
            }
            else return;
        }

        void save_data()
        {
            string 저장폴더 = AppDomain.CurrentDomain.BaseDirectory + "Data2";
            
            string rows = "날짜,분류,입금,출금,비고";

            if (System.IO.Directory.Exists(저장폴더) == false)
            {
                System.IO.Directory.CreateDirectory(저장폴더);
            }

            int rownum = listView1.Items.Count;
            for (int i = 0; i < rownum; i++)
            {
                ListViewItem lv = listView1.Items[i];
                string 날짜 = lv.SubItems[0].Text.Replace(",", "");
                string 분류 = lv.SubItems[1].Text.Replace(",", "");
                string 입금 = lv.SubItems[2].Text.Replace(",", "");
                string 출금 = lv.SubItems[3].Text.Replace(",", "");
                string 비고 = lv.SubItems[4].Text.Replace(",", "");
                rows += "\n" + 날짜 + "," + 분류 + "," + 입금 + "," + 출금 + "," + 비고;
            }

            string 파일명 = 저장폴더 + "\\" + DateTime.Now.ToString("yyyy-MM") + ".csv";
            System.IO.File.WriteAllText(파일명, rows, Encoding.UTF8);
            Console.WriteLine("저장파일명 : " + 파일명);
            Console.WriteLine("저장내용 : " + rows);

        }

        void summary()
        {
            int rownum = listView1.Items.Count;
            long 입금합 = 0;
            long 출금합 = 0;

            for (int i = 0; i < rownum; i++)
            {
                ListViewItem lv = listView1.Items[i];
                
                string 입금 = lv.SubItems[2].Text.Replace(",", "");
                string 출금 = lv.SubItems[3].Text.Replace(",", "");
                if (입금 != "") 입금합 += long.Parse(입금);
                else if (출금 != "") 출금합 += long.Parse(출금);

            }

            tbInSum.Text = 입금합.ToString("N0");
            tbOutSum.Text = 출금합.ToString("N0");
        }


    }
}
