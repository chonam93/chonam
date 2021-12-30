using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace resume
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();

        }
        private void fMain_Load(object sender, EventArgs e)
        {
            this.Show();
            user_Login();
            fileList();
        }
        void user_Login()
        {
            fLogin f = new fLogin();
            DialogResult result = f.ShowDialog();
            if (result == DialogResult.OK)
            {
                string 사용자명 = f.tbID.Text;
                tbusername.Text = 사용자명;
                btnAdd.Enabled = true;
                btnDelete.Enabled = true;
                btnAllDelete.Enabled = true;
                btnEdit.Enabled = true;
                btnSort.Enabled = true;
            }
            else
            {
                btnAdd.Enabled = false;
                btnDelete.Enabled = false;
                btnAllDelete.Enabled = false;
                btnEdit.Enabled = false;
                btnSort.Enabled = false;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbusername.Text != "..")
            {
                MessageBox.Show("이미 접속중입니다. \n" + "ID : " + tbusername.Text);
                return;
            }
            user_Login();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            fResume resume = new fResume();
            DialogResult result = resume.ShowDialog();
            if (result == DialogResult.OK)
            {
                string 등록시간 = resume.lbTime.Text;
                string 회사분류 = resume.cbType.Text;
                string 이름 = resume.tbName.Text;
                string 성별 = resume.cbSex.Text;
                string 생년월일 = resume.tbBirth.Text;
                string 핸드폰번호 = resume.tbPhone.Text;
                char check = resume.tbBirth.Text[0];
                string Age;
                if (check == '0' || check == '1' || check == '2')
                {
                    Age = (int.Parse(DateTime.Now.ToString("yyyy")) - int.Parse("20" + 생년월일.Substring(0, 2)) + 1).ToString();
                }
                else
                {
                    Age = (int.Parse(DateTime.Now.ToString("yyyy")) - int.Parse("19" + 생년월일.Substring(0, 2)) + 1).ToString();
                }

                string 나이 = Age;

                ListViewItem lv = listView1.Items.Add(등록시간);

                lv.SubItems.Add(회사분류);
                lv.SubItems.Add(이름);
                lv.SubItems.Add(성별);
                lv.SubItems.Add(나이);
                lv.SubItems.Add(핸드폰번호);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {


            if (listView1.SelectedItems.Count < 1)
            {
                MessageBox.Show("삭제할 항목을 선택해주세요", "확인", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ListViewItem lv = listView1.SelectedItems[0];
            string 이름 = lv.SubItems[2].Text;
            string 폰번호 = lv.SubItems[5].Text;
            string fileName = 이름 + "_" + 폰번호 + ".xml";

            if (MessageBox.Show("정말 삭제하시겠습니까?\n" + "이름 : " + 이름, "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                listView1.Items.Remove(lv);
                del_one_data(fileName);
                MessageBox.Show("삭제완료");
            }
            else return;
        }

        private void btnAllDelete_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count == 0)
            {
                MessageBox.Show("삭제할 항목이 없습니다.", "확인", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (MessageBox.Show("전부 삭제하시겠습니까?", "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                listView1.Items.Clear();
                del_data();
                MessageBox.Show("삭제완료");

            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count < 1)
            {
                MessageBox.Show("편집할 항목을 선택하세요", "확인", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            load_save_xml();

            fileList();
            /*load_data();*/

        }

        void load_save_xml()
        {
            XmlDocument xml = new XmlDocument();
            ListViewItem lv = listView1.SelectedItems[0];

            string 이름 = lv.SubItems[2].Text;

            string 연락처 = lv.SubItems[5].Text;
            string path = AppDomain.CurrentDomain.BaseDirectory + "DataXML";
            string fileName = path + "\\" + 이름 + "_" + 연락처 + ".xml";

            xml.Load(fileName);
            XmlNode resume = xml.SelectNodes("resume")[0];
            string 이름2 = resume.SelectNodes("Name")[0].InnerText;
            string 시간 = resume.SelectNodes("Time")[0].InnerText;
            string 성별 = resume.SelectNodes("Sex")[0].InnerText;
            string 생년월일 = resume.SelectNodes("Birth")[0].InnerText;
            string 학교명 = resume.SelectNodes("University")[0].InnerText;
            string 현주소 = resume.SelectNodes("Address")[0].InnerText;
            string 메일 = resume.SelectNodes("Mail")[0].InnerText;
            string 병역 = resume.SelectNodes("Army")[0].InnerText;
            string 보훈 = resume.SelectNodes("Veteran")[0].InnerText;
            string 지원 = resume.SelectNodes("Type")[0].InnerText;
            string 문항1 = resume.SelectNodes("Question1")[0].InnerText;
            string 문항2 = resume.SelectNodes("Question2")[0].InnerText;

            fResume f = new fResume(시간, 이름2, 생년월일, 성별, 연락처, 학교명, 현주소, 메일, 병역, 보훈, 지원, 문항1, 문항2);
            /*            if (f.ShowDialog() == DialogResult.OK)
                        {
                            *//*save_xml();*//*
                        }*/
            DialogResult result = f.ShowDialog();
            if (result == DialogResult.OK)
            {
                string 등록시간 = f.lbTime.Text;
                string 회사분류 = f.cbType.Text;
                string 이름3 = f.tbName.Text;
                string 성별2 = f.cbSex.Text;
                string 생년월일2 = f.tbBirth.Text;
                string 핸드폰번호 = f.tbPhone.Text;
                char check = f.tbBirth.Text[0];
                string Age;
                if (check == '0' || check == '1' || check == '2')
                {
                    Age = (int.Parse(DateTime.Now.ToString("yyyy")) - int.Parse("20" + 생년월일2.Substring(0, 2)) + 1).ToString();
                }
                else
                {
                    Age = (int.Parse(DateTime.Now.ToString("yyyy")) - int.Parse("19" + 생년월일2.Substring(0, 2)) + 1).ToString();
                }

                string 나이 = Age;

                lv.SubItems[0].Text = DateTime.Parse(등록시간).ToString("yyyy-MM-dd HH:mm");
                lv.SubItems[1].Text = 회사분류;
                lv.SubItems[2].Text = 이름3;
                lv.SubItems[3].Text = 성별2;
                lv.SubItems[4].Text = 나이;
                lv.SubItems[5].Text = 핸드폰번호;
            } //리스트뷰 업데이트


            XmlDocument xml2 = new XmlDocument();

            XmlNode resume2 = xml2.CreateElement("resume");

            XmlNode time = xml2.CreateElement("Time");
            time.InnerText = f.lbTime.Text;
            resume2.AppendChild(time);

            XmlNode name = xml2.CreateElement("Name");
            name.InnerText = f.tbName.Text;
            resume2.AppendChild(name);

            XmlNode birth = xml2.CreateElement("Birth");
            birth.InnerText = f.tbBirth.Text;
            resume2.AppendChild(birth);

            XmlNode Sex = xml2.CreateElement("Sex");
            Sex.InnerText = f.cbSex.Text;
            resume2.AppendChild(Sex);

            XmlNode Phone = xml2.CreateElement("PhoneNumber");
            Phone.InnerText = f.tbPhone.Text;
            resume2.AppendChild(Phone);

            XmlNode University = xml2.CreateElement("University");
            University.InnerText = f.tbSchool.Text;
            resume2.AppendChild(University);

            XmlNode Address = xml2.CreateElement("Address");
            Address.InnerText = f.tbAddress.Text;
            resume2.AppendChild(Address);

            XmlNode Mail = xml2.CreateElement("Mail");
            Mail.InnerText = f.tbMail.Text;
            resume2.AppendChild(Mail);

            XmlNode Army = xml2.CreateElement("Army");
            Army.InnerText = f.cbArmy.Text;
            resume2.AppendChild(Army);

            XmlNode Veteran = xml2.CreateElement("Veteran");
            Veteran.InnerText = f.cbVeteran.Text;
            resume2.AppendChild(Veteran);

            XmlNode Type = xml2.CreateElement("Type");
            Type.InnerText = f.cbType.Text;
            resume2.AppendChild(Type);

            XmlNode Question1 = xml2.CreateElement("Question1");
            Question1.InnerText = f.tbQ1.Text;
            resume2.AppendChild(Question1);

            XmlNode Question2 = xml2.CreateElement("Question2");
            Question2.InnerText = f.tbQ2.Text;
            resume2.AppendChild(Question2);

            xml2.AppendChild(resume2);

            string fileName2 = path + "\\" + f.tbName.Text + "_" + f.tbPhone.Text + ".xml";
            if (System.IO.Directory.Exists(path) == false)
            {
                System.IO.Directory.CreateDirectory(path);
            }
            xml2.Save(fileName2);
            fileList();
        }
        void fileList()
        {
            listView1.Items.Clear();

            string FolderName = AppDomain.CurrentDomain.BaseDirectory + "DataXML";
            System.IO.DirectoryInfo filelist = new System.IO.DirectoryInfo(FolderName);
            foreach (System.IO.FileInfo File in filelist.GetFiles())
            {
                if (File.Extension.ToLower().CompareTo(".xml") == 0)
                {
                    //String FileNameOnly = File.Name.Substring(0, File.Name.Length - 4);
                    String FullFileName = File.FullName;

                    XmlDocument xml = new XmlDocument();
                    xml.Load(FullFileName);
                    XmlNode resume = xml.SelectNodes("resume")[0];
                    string 이름 = resume.SelectNodes("Name")[0].InnerText;
                    string 폰번호 = resume.SelectNodes("PhoneNumber")[0].InnerText;
                    string 시간 = resume.SelectNodes("Time")[0].InnerText;
                    string 성별 = resume.SelectNodes("Sex")[0].InnerText;
                    string 생년월일 = resume.SelectNodes("Birth")[0].InnerText;
                    string 학교명 = resume.SelectNodes("University")[0].InnerText;
                    string 현주소 = resume.SelectNodes("Address")[0].InnerText;
                    string 메일 = resume.SelectNodes("Mail")[0].InnerText;
                    string 병역 = resume.SelectNodes("Army")[0].InnerText;
                    string 보훈 = resume.SelectNodes("Veteran")[0].InnerText;
                    string 지원 = resume.SelectNodes("Type")[0].InnerText;
                    string 문항1 = resume.SelectNodes("Question1")[0].InnerText;
                    string 문항2 = resume.SelectNodes("Question2")[0].InnerText;


                    char check = 생년월일[0];
                    string Age;
                    if (check == '0' || check == '1' || check == '2')
                    {
                        Age = (int.Parse(DateTime.Now.ToString("yyyy")) - int.Parse("20" + 생년월일.Substring(0, 2)) + 1).ToString();
                    }
                    else
                    {
                        Age = (int.Parse(DateTime.Now.ToString("yyyy")) - int.Parse("19" + 생년월일.Substring(0, 2)) + 1).ToString();
                    }

                    string 나이 = Age;

                    ListViewItem lv = listView1.Items.Add(시간);

                    lv.SubItems.Add(지원);
                    lv.SubItems.Add(이름);
                    lv.SubItems.Add(성별);
                    lv.SubItems.Add(나이);
                    lv.SubItems.Add(폰번호);
                }
            }

        }

        void del_data()
        {
            string FolderName = AppDomain.CurrentDomain.BaseDirectory + "DataXML";
            System.IO.DirectoryInfo filelist = new System.IO.DirectoryInfo(FolderName);
            foreach (System.IO.FileInfo onefile in filelist.GetFiles())
            {
                if (onefile.Extension.ToLower().CompareTo(".xml") == 0)
                {
                    String FullFileName = onefile.FullName;
                    File.Delete(FullFileName);
                }

            }
        }

        void del_one_data(string fileName)
        {
            string FolderName = AppDomain.CurrentDomain.BaseDirectory + "DataXML";
            File.Delete(FolderName + "\\" + fileName);
        }


        /*        void save_xml()
       {
           XmlDocument xml = new XmlDocument();

           XmlNode resume = xml.CreateElement("resume");

           XmlNode name = xml.CreateElement("Name");
           name.InnerText = f.tbName.Text;
           resume.AppendChild(name);

           XmlNode birth = xml.CreateElement("Birth");
           birth.InnerText = f.tbBirth.Text;
           resume.AppendChild(birth);

           XmlNode Sex = xml.CreateElement("Sex");
           Sex.InnerText = cbSex.Text;
           resume.AppendChild(Sex);

           XmlNode Phone = xml.CreateElement("PhoneNumber");
           Phone.InnerText = tbPhone.Text;
           resume.AppendChild(Phone);

           XmlNode University = xml.CreateElement("University");
           University.InnerText = tbSchool.Text;
           resume.AppendChild(University);

           XmlNode Address = xml.CreateElement("Address");
           Address.InnerText = tbAddress.Text;
           resume.AppendChild(Address);

           XmlNode Mail = xml.CreateElement("Mail");
           Mail.InnerText = tbMail.Text;
           resume.AppendChild(Mail);

           XmlNode Army = xml.CreateElement("Army");
           Army.InnerText = cbArmy.Text;
           resume.AppendChild(Army);

           XmlNode Veteran = xml.CreateElement("Veteran");
           Veteran.InnerText = cbVeteran.Text;
           resume.AppendChild(Veteran);

           XmlNode Type = xml.CreateElement("Type");
           Type.InnerText = cbType.Text;
           resume.AppendChild(Type);

           XmlNode Question1 = xml.CreateElement("Question1");
           Question1.InnerText = tbQ1.Text;
           resume.AppendChild(Question1);

           XmlNode Question2 = xml.CreateElement("Question2");
           Question2.InnerText = tbQ2.Text;
           resume.AppendChild(Question2);

           xml.AppendChild(resume);

           string path = AppDomain.CurrentDomain.BaseDirectory + "DataXML";
           string fileName = path + "\\" + tbName.Text + tbPhone.Text + ".xml";
           if (System.IO.Directory.Exists(path) == false)
           {
               System.IO.Directory.CreateDirectory(path);
           }
           xml.Save(fileName);
       }*/
        /*  void load_data()
        {
            string folderName = AppDomain.CurrentDomain.BaseDirectory + "Data";
            ListViewItem lv = listView1.SelectedItems[0];
            string 이름 = lv.SubItems[2].Text;
            string fileName = folderName + "\\" + 이름 + ".csv";

            fResume f = new fResume();
            var reader = new StreamReader(File.OpenRead(fileName));
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(',');

                f.tbName.Text = values[0];
                f.tbBirth.Text = values[1];
                f.cbSex.Text = values[2];
                f.tbPhone.Text = values[3];



            }
            f.ShowDialog();
        
            if (f.ShowDialog() == DialogResult.OK)
            {
                save_data();
            }
        }*/

    }
}
