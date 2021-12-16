
namespace study_string
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbText = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbContain = new System.Windows.Forms.Label();
            this.lbEquals = new System.Windows.Forms.Label();
            this.lbLength = new System.Windows.Forms.Label();
            this.lbReplace = new System.Windows.Forms.Label();
            this.lbSplit = new System.Windows.Forms.Label();
            this.lbSubstring = new System.Windows.Forms.Label();
            this.lbToLower = new System.Windows.Forms.Label();
            this.lbTrim = new System.Windows.Forms.Label();
            this.lbToUpper = new System.Windows.Forms.Label();
            this.lbSplit3 = new System.Windows.Forms.Label();
            this.lbSplit2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbText
            // 
            this.lbText.AutoSize = true;
            this.lbText.Location = new System.Drawing.Point(24, 34);
            this.lbText.Name = "lbText";
            this.lbText.Size = new System.Drawing.Size(114, 12);
            this.lbText.TabIndex = 0;
            this.lbText.Text = "Samp le, Test,Text";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(170, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "실행";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contain (\"Text\")";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "Equals";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "Length";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(295, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "ToLower";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 12);
            this.label6.TabIndex = 6;
            this.label6.Text = "Replace";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(295, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 12);
            this.label7.TabIndex = 7;
            this.label7.Text = "Substring";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(295, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 8;
            this.label8.Text = "ToUpper";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(295, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 12);
            this.label9.TabIndex = 9;
            this.label9.Text = "Trim";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 137);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 10;
            this.label10.Text = "Split";
            // 
            // lbContain
            // 
            this.lbContain.AutoSize = true;
            this.lbContain.Location = new System.Drawing.Point(168, 89);
            this.lbContain.Name = "lbContain";
            this.lbContain.Size = new System.Drawing.Size(11, 12);
            this.lbContain.TabIndex = 11;
            this.lbContain.Text = "-";
            // 
            // lbEquals
            // 
            this.lbEquals.AutoSize = true;
            this.lbEquals.Location = new System.Drawing.Point(168, 101);
            this.lbEquals.Name = "lbEquals";
            this.lbEquals.Size = new System.Drawing.Size(11, 12);
            this.lbEquals.TabIndex = 12;
            this.lbEquals.Text = "-";
            // 
            // lbLength
            // 
            this.lbLength.AutoSize = true;
            this.lbLength.Location = new System.Drawing.Point(168, 113);
            this.lbLength.Name = "lbLength";
            this.lbLength.Size = new System.Drawing.Size(11, 12);
            this.lbLength.TabIndex = 13;
            this.lbLength.Text = "-";
            // 
            // lbReplace
            // 
            this.lbReplace.AutoSize = true;
            this.lbReplace.Location = new System.Drawing.Point(168, 125);
            this.lbReplace.Name = "lbReplace";
            this.lbReplace.Size = new System.Drawing.Size(11, 12);
            this.lbReplace.TabIndex = 14;
            this.lbReplace.Text = "-";
            // 
            // lbSplit
            // 
            this.lbSplit.AutoSize = true;
            this.lbSplit.Location = new System.Drawing.Point(168, 137);
            this.lbSplit.Name = "lbSplit";
            this.lbSplit.Size = new System.Drawing.Size(11, 12);
            this.lbSplit.TabIndex = 15;
            this.lbSplit.Text = "-";
            // 
            // lbSubstring
            // 
            this.lbSubstring.AutoSize = true;
            this.lbSubstring.Location = new System.Drawing.Point(413, 89);
            this.lbSubstring.Name = "lbSubstring";
            this.lbSubstring.Size = new System.Drawing.Size(11, 12);
            this.lbSubstring.TabIndex = 16;
            this.lbSubstring.Text = "-";
            // 
            // lbToLower
            // 
            this.lbToLower.AutoSize = true;
            this.lbToLower.Location = new System.Drawing.Point(413, 101);
            this.lbToLower.Name = "lbToLower";
            this.lbToLower.Size = new System.Drawing.Size(11, 12);
            this.lbToLower.TabIndex = 17;
            this.lbToLower.Text = "-";
            // 
            // lbTrim
            // 
            this.lbTrim.AutoSize = true;
            this.lbTrim.Location = new System.Drawing.Point(413, 125);
            this.lbTrim.Name = "lbTrim";
            this.lbTrim.Size = new System.Drawing.Size(11, 12);
            this.lbTrim.TabIndex = 18;
            this.lbTrim.Text = "-";
            // 
            // lbToUpper
            // 
            this.lbToUpper.AutoSize = true;
            this.lbToUpper.Location = new System.Drawing.Point(413, 113);
            this.lbToUpper.Name = "lbToUpper";
            this.lbToUpper.Size = new System.Drawing.Size(11, 12);
            this.lbToUpper.TabIndex = 19;
            this.lbToUpper.Text = "-";
            // 
            // lbSplit3
            // 
            this.lbSplit3.AutoSize = true;
            this.lbSplit3.Location = new System.Drawing.Point(168, 161);
            this.lbSplit3.Name = "lbSplit3";
            this.lbSplit3.Size = new System.Drawing.Size(11, 12);
            this.lbSplit3.TabIndex = 20;
            this.lbSplit3.Text = "-";
            // 
            // lbSplit2
            // 
            this.lbSplit2.AutoSize = true;
            this.lbSplit2.Location = new System.Drawing.Point(168, 149);
            this.lbSplit2.Name = "lbSplit2";
            this.lbSplit2.Size = new System.Drawing.Size(11, 12);
            this.lbSplit2.TabIndex = 21;
            this.lbSplit2.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbSplit2);
            this.Controls.Add(this.lbSplit3);
            this.Controls.Add(this.lbToUpper);
            this.Controls.Add(this.lbTrim);
            this.Controls.Add(this.lbToLower);
            this.Controls.Add(this.lbSubstring);
            this.Controls.Add(this.lbSplit);
            this.Controls.Add(this.lbReplace);
            this.Controls.Add(this.lbLength);
            this.Controls.Add(this.lbEquals);
            this.Controls.Add(this.lbContain);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbContain;
        private System.Windows.Forms.Label lbEquals;
        private System.Windows.Forms.Label lbLength;
        private System.Windows.Forms.Label lbReplace;
        private System.Windows.Forms.Label lbSplit;
        private System.Windows.Forms.Label lbSubstring;
        private System.Windows.Forms.Label lbToLower;
        private System.Windows.Forms.Label lbTrim;
        private System.Windows.Forms.Label lbToUpper;
        private System.Windows.Forms.Label lbSplit3;
        private System.Windows.Forms.Label lbSplit2;
    }
}

