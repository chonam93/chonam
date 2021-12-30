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
        string 현재열린파일명 = "";

        public fMain()
        {
            InitializeComponent();
        }

        //로그인부분
        private void fMain_Load(object sender, EventArgs e)
        {
            this.Show(); //메인화면 띄우고
            현재열린파일명 = AppDomain.CurrentDomain.BaseDirectory + "Data2\\" + DateTime.Now.ToString("yyyy-MM") + ".csv";

            user_Login(); //그 위에 로그인 창 실행
            loadData();
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
            summary();
        }

        private void fEdit_Click(object sender, EventArgs e)
        {
            edit_data();
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
            string 파일명 = 저장폴더 + "\\" + DateTime.Now.ToString("yyyy-MM") + ".csv";

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

            System.IO.File.WriteAllText(파일명, rows, Encoding.UTF8);
            Console.WriteLine("저장파일명 : " + 파일명);
            Console.WriteLine("저장내용 : " + rows);

        }
        void loadData()
        {
            //불러오기
            string 저장폴더 = AppDomain.CurrentDomain.BaseDirectory/*현재파일주소*/ + "Data2";

            DateTime 현재시간 = DateTime.Now;
            string 파일명 = 현재열린파일명;//저장폴더 + "\\" + 현재시간.ToString("yyyy-MM-dd")+".csv";

            //파일이 없으면 사용 불가
            if (System.IO.File.Exists(파일명) == false)
            {
                MessageBox.Show("저장된 파일이 없습니다\n\n" + 파일명, "확인", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string 선택월 = 파일명.Substring(파일명.LastIndexOf("\\") + 1, 7);
            tbMonth.Text = 선택월;

            //목록 초기화
            listView1.Items.Clear();

            //파일을 읽는다 
            string[] 내용 = System.IO.File.ReadAllLines(파일명, System.Text.Encoding.UTF8);

            int 건수 = 내용.Length;

            for (int i = 1; i < 건수; i++)
            {
                string 줄내용 = 내용[i];
                string[] 줄버퍼 = 줄내용.Split(',');

                ListViewItem item = listView1.Items.Add(줄버퍼[0]);
                item.SubItems.Add(줄버퍼[1]);

                if (줄버퍼[2] == "") 줄버퍼[2] = "0";
                if (줄버퍼[3] == "") 줄버퍼[3] = "0";

                long 입금액 = long.Parse(줄버퍼[2]);
                long 출금액 = long.Parse(줄버퍼[3]);


                if (입금액 != 0)
                    item.SubItems.Add(입금액.ToString("N0"));
                else
                    item.SubItems.Add("");

                if (출금액 != 0)
                    item.SubItems.Add(출금액.ToString("N0"));
                else
                    item.SubItems.Add("");

                item.SubItems.Add(줄버퍼[4]);
            }
            summary();

            Console.WriteLine("저장된내용=" + 내용);
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
            tbSumSum.Text = (입금합 - 출금합).ToString("N0");

        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            edit_data();
        }

        private void fsave_Click(object sender, EventArgs e)
        {
            string 파일명 = 현재열린파일명.Substring(현재열린파일명.LastIndexOf("\\") + 1, 7);
            MessageBox.Show("저장하시겠습니까?\n\n 파일명 : " + 파일명, "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            save_data();
        }

        private void switchMonth_Click(object sender, EventArgs e)
        {

            fileList f = new fileList();
            if (f.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                현재열린파일명 = f.선택된파일명;
                loadData();
            }

            
        }

        private void endMonth_Click(object sender, EventArgs e)
        {

            var dlg = MessageBox.Show("마감확인? \n\n", "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlg != System.Windows.Forms.DialogResult.Yes) return;
            //월마감
            //불러오기
            string 선택월 = tbMonth.Text;
            string 저장폴더 = AppDomain.CurrentDomain.BaseDirectory/*현재파일주소*/ + "Data2";

            //2021-12
            DateTime 현재월 = DateTime.Parse(선택월 + "-01");
            DateTime 다음월 = 현재월.AddMonths(1);
            string 파일명 = 다음월.ToString("yyyy-MM") + ".csv";
            string 전체파일명 = 저장폴더 + "\\" + 파일명;

            //if (System.IO.File.Exists(전체파일명) == true) return;


            long 잔액 = long.Parse(tbSumSum.Text.Replace(",", ""));





            string 내용 = "날짜,분류,입금,출금,비고";
            string 날짜 = 다음월.ToString("yyyy_MM_dd");
            string 분류 = "잔액이월";
            string 입금 = 잔액.ToString();
            string 출금 = "";
            string 비고 = string.Format("{0}월 잔액이월", 현재월.ToString("yyyy_MM"));
            내용 += "\n" + 날짜 + "," + 분류 + "," + 입금 + "," + 출금 + "," + 비고;


            System.IO.File.WriteAllText(전체파일명, 내용, System.Text.Encoding.UTF8);
            Console.WriteLine("저장파일명=" + 파일명);

            현재열린파일명 = 전체파일명;
            loadData();

            

        }
    }
}
