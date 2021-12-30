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
    public partial class fResume : Form
    {
        public fResume()
        {
            InitializeComponent();
            DateTime time = DateTime.Now;
            lbTime.Text = time.ToString("yyyy-MM-dd HH:mm");
        }
        public fResume(string 시간, string 이름, string 생년월일, string 성별, string 연락처, string 학교명, string 현주소, string 메일, string 병역, string 보훈, string 지원, string 문항1, string 문항2)
        {
            InitializeComponent();
            lbTime.Text = DateTime.Parse(시간).ToString("yyyy-MM-dd HH:mm");
            tbName.Text = 이름;
            tbBirth.Text = 생년월일;
            cbSex.Text = 성별;
            tbPhone.Text = 연락처;
            tbSchool.Text = 학교명;
            tbAddress.Text = 현주소;
            tbMail.Text = 메일;
            cbArmy.Text = 병역;
            cbVeteran.Text = 보훈;
            cbType.Text = 지원;
            tbQ1.Text = 문항1;
            tbQ2.Text = 문항2;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {   
            string image_file = string.Empty;

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = @"C:\Users\User\Desktop";
            
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                image_file = dialog.FileName;
            }
            else
            {
                return;
            }

            pictureBox1.Image = Bitmap.FromFile(image_file);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            MessageBox.Show("사진 업로드 완료", "확인");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int check1;
            int check2;
            DialogResult result = MessageBox.Show("저장하시겠습니까?", "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {

                if (tbName.Text == "" || tbBirth.Text == "" || tbPhone.Text == "" || cbSex.Text == "") 
                {
                    MessageBox.Show("필수항목(*)은 모두 작성해주십시오.", "확인", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (!int.TryParse(tbBirth.Text, out check1) || !int.TryParse(tbPhone.Text, out check2))
                {
                    MessageBox.Show("생년월일 / 전화번호는 숫자로 작성해주십시오.", "확인", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    DialogResult = DialogResult.OK;
/*                    save_data();*/
                    save_xml();
                }
            }
            else return;
        }
/*        void save_data()
        {
            string folderName = AppDomain.CurrentDomain.BaseDirectory + "Data";
            string fileName = folderName + "\\" + tbName.Text + ".csv";
            if (System.IO.Directory.Exists(folderName) == false)
            {
                System.IO.Directory.CreateDirectory(folderName);
            }
            StreamWriter sw = File.CreateText(fileName);
            sw.WriteLine($"{tbName.Text},{tbBirth.Text},{cbSex.Text},{tbPhone.Text}");
            sw.Close();
        }*/
        void save_xml()
        {
            XmlDocument xml = new XmlDocument();

            XmlNode resume = xml.CreateElement("resume");

            XmlNode time = xml.CreateElement("Time");
            time.InnerText = lbTime.Text;
            resume.AppendChild(time);

            XmlNode name = xml.CreateElement("Name");
            name.InnerText = tbName.Text;
            resume.AppendChild(name);

            XmlNode birth = xml.CreateElement("Birth");
            birth.InnerText = tbBirth.Text;
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
            string fileName = path + "\\" + tbName.Text + "_" + tbPhone.Text + ".xml";
            if (System.IO.Directory.Exists(path) == false)
            {
                System.IO.Directory.CreateDirectory(path);
            }
            xml.Save(fileName);
        }
    }
}
