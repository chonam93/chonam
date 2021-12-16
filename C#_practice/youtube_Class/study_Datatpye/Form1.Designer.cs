
namespace study_Datatpye
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
            this.tbText = new System.Windows.Forms.TextBox();
            this.btenConfirm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbShort = new System.Windows.Forms.Label();
            this.lbInt = new System.Windows.Forms.Label();
            this.lbDouble = new System.Windows.Forms.Label();
            this.lbException = new System.Windows.Forms.Label();
            this.btnShort = new System.Windows.Forms.Button();
            this.btnInt = new System.Windows.Forms.Button();
            this.btnDouble = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbText
            // 
            this.tbText.Location = new System.Drawing.Point(12, 12);
            this.tbText.Name = "tbText";
            this.tbText.Size = new System.Drawing.Size(659, 21);
            this.tbText.TabIndex = 0;
            // 
            // btenConfirm
            // 
            this.btenConfirm.Location = new System.Drawing.Point(677, 10);
            this.btenConfirm.Name = "btenConfirm";
            this.btenConfirm.Size = new System.Drawing.Size(111, 23);
            this.btenConfirm.TabIndex = 1;
            this.btenConfirm.Text = "변환";
            this.btenConfirm.UseVisualStyleBackColor = true;
            this.btenConfirm.Click += new System.EventHandler(this.btenConfirm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Short";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Int";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "Double";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "Exception";
            // 
            // lbShort
            // 
            this.lbShort.AutoSize = true;
            this.lbShort.Location = new System.Drawing.Point(98, 63);
            this.lbShort.Name = "lbShort";
            this.lbShort.Size = new System.Drawing.Size(11, 12);
            this.lbShort.TabIndex = 6;
            this.lbShort.Text = "0";
            // 
            // lbInt
            // 
            this.lbInt.AutoSize = true;
            this.lbInt.Location = new System.Drawing.Point(98, 94);
            this.lbInt.Name = "lbInt";
            this.lbInt.Size = new System.Drawing.Size(11, 12);
            this.lbInt.TabIndex = 7;
            this.lbInt.Text = "0";
            // 
            // lbDouble
            // 
            this.lbDouble.AutoSize = true;
            this.lbDouble.Location = new System.Drawing.Point(98, 127);
            this.lbDouble.Name = "lbDouble";
            this.lbDouble.Size = new System.Drawing.Size(11, 12);
            this.lbDouble.TabIndex = 8;
            this.lbDouble.Text = "0";
            // 
            // lbException
            // 
            this.lbException.AutoSize = true;
            this.lbException.Location = new System.Drawing.Point(98, 165);
            this.lbException.Name = "lbException";
            this.lbException.Size = new System.Drawing.Size(11, 12);
            this.lbException.TabIndex = 9;
            this.lbException.Text = "-";
            // 
            // btnShort
            // 
            this.btnShort.Location = new System.Drawing.Point(223, 52);
            this.btnShort.Name = "btnShort";
            this.btnShort.Size = new System.Drawing.Size(111, 23);
            this.btnShort.TabIndex = 10;
            this.btnShort.Text = "short 변환";
            this.btnShort.UseVisualStyleBackColor = true;
            this.btnShort.Click += new System.EventHandler(this.btnShort_Click);
            // 
            // btnInt
            // 
            this.btnInt.Location = new System.Drawing.Point(223, 83);
            this.btnInt.Name = "btnInt";
            this.btnInt.Size = new System.Drawing.Size(111, 23);
            this.btnInt.TabIndex = 11;
            this.btnInt.Text = "int 변환";
            this.btnInt.UseVisualStyleBackColor = true;
            this.btnInt.Click += new System.EventHandler(this.btnInt_Click);
            // 
            // btnDouble
            // 
            this.btnDouble.Location = new System.Drawing.Point(221, 116);
            this.btnDouble.Name = "btnDouble";
            this.btnDouble.Size = new System.Drawing.Size(111, 23);
            this.btnDouble.TabIndex = 12;
            this.btnDouble.Text = "button4";
            this.btnDouble.UseVisualStyleBackColor = true;
            this.btnDouble.Click += new System.EventHandler(this.btnDouble_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDouble);
            this.Controls.Add(this.btnInt);
            this.Controls.Add(this.btnShort);
            this.Controls.Add(this.lbException);
            this.Controls.Add(this.lbDouble);
            this.Controls.Add(this.lbInt);
            this.Controls.Add(this.lbShort);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btenConfirm);
            this.Controls.Add(this.tbText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbText;
        private System.Windows.Forms.Button btenConfirm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbShort;
        private System.Windows.Forms.Label lbInt;
        private System.Windows.Forms.Label lbDouble;
        private System.Windows.Forms.Label lbException;
        private System.Windows.Forms.Button btnShort;
        private System.Windows.Forms.Button btnInt;
        private System.Windows.Forms.Button btnDouble;
    }
}

