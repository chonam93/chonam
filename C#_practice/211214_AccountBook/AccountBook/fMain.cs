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
    public partial class fMain : Form
    {
        string 현재열린파일명 = "";
        public fMain()
        {
            InitializeComponent();
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            //메인폼 화면에 실행
            this.Show();

            현재열린파일명 = AppDomain.CurrentDomain.BaseDirectory + "Data\\" + DateTime.Now.ToString("yyyy-MM") + ".csv";
            userLogin();
        }

        void userLogin()
        {
            //로그인창
            fLogin f = new fLogin();
            DialogResult result = f.ShowDialog(); //show는 창이동이 가능하지만 showdialog는 해당창을 종료해야만 이동 가능. 강제성부여
            //showDialog가 끝나면 DialogResult가 생기고 그걸 result변수로 받음
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                //로그인 성공
                //1.자료를 불러와서 표시(목록)
                string 사용자명 = f.tbName.Text;
                sbUserName.Text = 사용자명;

                //2.입/출금 등록버튼을 활성화
                btnIN.Enabled = true;
                btnOUT.Enabled = true;

                loadData();
            }
            else
            {
                //로그인 실패
                //1.현재 표시되는 목록 제거 
                //2.입/출금 등록버튼을 비활성
                btnIN.Enabled = false; //입금버튼 비활성
                btnOUT.Enabled = false; //출금버튼 비활성
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            userLogin();
        }

        private void btnIN_Click(object sender, EventArgs e)
        {
            fIN f = new fIN();

            DialogResult result = f.ShowDialog();
            if(result == System.Windows.Forms.DialogResult.OK)
            {
                //입력데이터 확인
                DateTime 입력일 = f.dtDate.Value;
                string 분류 = f.tbType.Text;
                string 금액 = f.tbAmt.Text;
                string 비고 = f.tbMemo.Text;
                //데이터를 추가
                //>>데이터읽기

                long 금액1 = long.Parse(금액);

                string 입금액 = 금액1.ToString("N0");

                //목록 추가
                ListViewItem lv = lv1.Items.Add(입력일.ToShortDateString());
                lv.SubItems.Add(분류);//분류
                lv.SubItems.Add(입금액);//금액
                lv.SubItems.Add("");//출금
                lv.SubItems.Add(비고);//비고

                Summary();
                saveData();
            }


        }

        private void btnOUT_Click(object sender, EventArgs e)
        {
            fOUT f = new fOUT();

            DialogResult result = f.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                //입력데이터 확인
                DateTime 입력일 = f.dtDate.Value;
                string 분류 = f.tbType.Text;
                string 금액 = f.tbAmt.Text;
                string 비고 = f.tbMemo.Text;
                //데이터를 추가
                //>>데이터읽기

                long 금액1 = long.Parse(금액);

                string 출금액 = 금액1.ToString("N0");

                //목록 추가
                ListViewItem lv = lv1.Items.Add(입력일.ToShortDateString());
                lv.SubItems.Add(분류);//분류
                lv.SubItems.Add("");//입금
                lv.SubItems.Add(출금액);//금액
                lv.SubItems.Add(비고);//비고
                Summary();
                saveData();
            }
 
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            editData();            
        }

        void editData()
        {
            //편집메뉴
            if (lv1.SelectedItems.Count < 1) //사용자가 선택한게 없다!
            {
                MessageBox.Show("데이터를 선택하세요");
                return;
            }
            //선택된 자료의 구분을 확인한다
            ListViewItem lv = lv1.SelectedItems[0];
            string 날짜 = lv.SubItems[0].Text;
            string 분류 = lv.SubItems[1].Text;
            string 입금액 = lv.SubItems[2].Text;
            string 출금액 = lv.SubItems[3].Text;
            string 비고 = lv.SubItems[4].Text;
            if (입금액 != "")
            {
                //입금화면을 호출하고 현재 데이터를 전송
                fIN f = new fIN(날짜, 분류, 입금액, 비고);
                if (f.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    //현재 선택된 자료를 업데이트
                    lv.SubItems[0].Text = f.dtDate.Value.ToShortDateString();
                    lv.SubItems[1].Text = f.tbType.Text;

                    string 입력값 = f.tbAmt.Text.Replace(",","");
                    long 숫자값 = long.Parse(입력값);
                    lv.SubItems[2].Text = 숫자값.ToString("N0");
                    lv.SubItems[3].Text = "";
                    lv.SubItems[4].Text = f.tbMemo.Text;
                }
            }
            else
            {
                //출금화면 호출하고 ,,,
                fOUT f = new fOUT(날짜, 분류, 출금액, 비고);
                if (f.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    //현재 선택된 자료를 업데이트
                    lv.SubItems[0].Text = f.dtDate.Value.ToShortDateString();
                    lv.SubItems[1].Text = f.tbType.Text;
                    lv.SubItems[2].Text = "";
                    string 입력값 = f.tbAmt.Text.Replace(",", "");
                    long 숫자값 = long.Parse(입력값);
                    lv.SubItems[3].Text = 숫자값.ToString("N0");
                    lv.SubItems[4].Text = f.tbMemo.Text;
                }

            }
            Summary();
            saveData();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            delData();
        }

        void delData()
        {
            //삭제메뉴
            if (lv1.SelectedItems.Count < 1) //사용자가 선택한게 없다!
            {
                MessageBox.Show("데이터를 선택하세요");
                return;
            }

            ListViewItem lv = lv1.SelectedItems[0];
            string 분류 = lv.SubItems[1].Text;
            string 입금액 = lv.SubItems[2].Text;
            string 출금액 = lv.SubItems[3].Text;
            string 표시금액 = 입금액;
            if (표시금액 == "") 표시금액 = 출금액;

            string 메세지 = "삭제하시겠습니까?\n\n" +
                            "분류 = " + 분류 + "\n" +
                            "금액 = " + 표시금액;


            DialogResult result = MessageBox.Show(메세지, "삭제확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                lv1.Items.Remove(lv);
                MessageBox.Show("삭제완료");
                saveData();
                Summary();
            } 
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveData();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            loadData();            
        }
        void saveData()
        {
            //저장하기
            //날짜,분류,입금,출금,비고
            string 저장폴더 = AppDomain.CurrentDomain.BaseDirectory/*현재파일주소*/ + "Data";
            DateTime 현재시간 = DateTime.Now;
            string 파일명 = 현재열린파일명;//저장폴더 + "\\" + 현재시간.ToString("yyyy-MM-dd") + ".csv";
            string 내용 = "날짜,분류,입금,출금,비고";

            //저장폴더가 없는 경우에만 생성
            if (System.IO.Directory.Exists(저장폴더) == false)
                System.IO.Directory.CreateDirectory(저장폴더);//폴더생성

            int 건수 = lv1.Items.Count;
            for (int i = 0; i < 건수; i++)
            {
                ListViewItem item = lv1.Items[i];
                string 날짜 = item.SubItems[0].Text.Replace(",", "");
                string 분류 = item.SubItems[1].Text.Replace(",", "");
                string 입금 = item.SubItems[2].Text.Replace(",","");
                string 출금 = item.SubItems[3].Text.Replace(",", "");
                string 비고 = item.SubItems[4].Text.Replace(",", "");
                내용 += "\n" + 날짜 + "," + 분류 + "," + 입금 + "," + 출금 + "," + 비고;
            }

            System.IO.File.WriteAllText(파일명, 내용, System.Text.Encoding.UTF8);
            Console.WriteLine("저장파일명=" + 파일명);
            Console.WriteLine("저장된내용=" + 내용);
        }
        void loadData()
        {
            //불러오기
            string 저장폴더 = AppDomain.CurrentDomain.BaseDirectory/*현재파일주소*/ + "Data";

            DateTime 현재시간 = DateTime.Now;
            string 파일명 = 현재열린파일명;//저장폴더 + "\\" + 현재시간.ToString("yyyy-MM-dd")+".csv";
                 
            //파일이 없으면 사용 불가
            if (System.IO.File.Exists(파일명) == false)
            {
                MessageBox.Show("저장된 파일이 없습니다\n\n"+파일명, "확인", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string 선택월 = 파일명.Substring(파일명.LastIndexOf("\\") + 1,7);
            tbMonth.Text = 선택월;

            //목록 초기화
            lv1.Items.Clear();

            //파일을 읽는다 
            string[] 내용 = System.IO.File.ReadAllLines(파일명, System.Text.Encoding.UTF8);

            int 건수 = 내용.Length;
            
            for (int i = 1; i < 건수; i++)
            {
                string 줄내용 = 내용[i];
                string[] 줄버퍼 = 줄내용.Split(',');

                ListViewItem item = lv1.Items.Add(줄버퍼[0]);
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
            Summary();

            Console.WriteLine("저장된내용=" + 내용); 
        }

        private void lv1_DoubleClick(object sender, EventArgs e)
        {
            editData();
        }

        private void lv1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void 편집ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editData();
        }

        private void 삭제ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            delData();
        }

        void Summary()
        {
            //입금액 출금액 합 계산 표시
            int 목록건수 = this.lv1.Items.Count;
            int 입금총합 = 0;
            int 출금총합 = 0;
            long 잔액 = 0;
            
            for (int i = 0; i < 목록건수; i++)
            {
                ListViewItem item = lv1.Items[i];
                string 입금 = item.SubItems[2].Text.Replace(",","");
                string 출금 = item.SubItems[3].Text.Replace(",","");

                if (입금 == "") 입금 = "0";
                if (출금 == "") 출금 = "0";

                int 입금액 = int.Parse(입금);
                int 출금액 = int.Parse(출금);
                
                입금총합 += 입금액;
                출금총합 += 출금액;

                잔액 += 입금액 - 출금액;
            }

            sbSumIn.Text = 입금총합.ToString("N0");
            sbSumOut.Text = 출금총합.ToString("N0");
            sbAmt.Text = 잔액.ToString("N0");
        }

        private void switch_month_Click(object sender, EventArgs e)
        {
            fFileList f = new fFileList();
            if(f.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                현재열린파일명 = f.선택된파일명;
                loadData();
            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            var dlg = MessageBox.Show("마감확인? \n\n", "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlg != System.Windows.Forms.DialogResult.Yes) return;
            //월마감
            //불러오기
            string 선택월 = tbMonth.Text;
            string 저장폴더 = AppDomain.CurrentDomain.BaseDirectory/*현재파일주소*/ + "Data";

            //2021-12
            DateTime 현재월 = DateTime.Parse(선택월 + "-01");
            DateTime 다음월 = 현재월.AddMonths(1);
            string 파일명 = 다음월.ToString("yyyy_MM") + ".csv";
            string 전체파일명 = 저장폴더 + "\\" + 파일명;

            int 잔액 = int.Parse(sbAmt.Text.Replace(",",""));
        




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
