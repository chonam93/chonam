
namespace new2_account
{
    partial class fIN
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtTime = new System.Windows.Forms.DateTimePicker();
            this.tbType = new System.Windows.Forms.TextBox();
            this.tbAmt = new System.Windows.Forms.TextBox();
            this.tbMemo = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "날짜";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "분류";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "금액";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "비고";
            // 
            // dtTime
            // 
            this.dtTime.Location = new System.Drawing.Point(47, 3);
            this.dtTime.Name = "dtTime";
            this.dtTime.Size = new System.Drawing.Size(200, 21);
            this.dtTime.TabIndex = 5;
            // 
            // tbType
            // 
            this.tbType.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.tbType.Location = new System.Drawing.Point(48, 29);
            this.tbType.Name = "tbType";
            this.tbType.Size = new System.Drawing.Size(199, 21);
            this.tbType.TabIndex = 6;
            // 
            // tbAmt
            // 
            this.tbAmt.Location = new System.Drawing.Point(48, 61);
            this.tbAmt.Name = "tbAmt";
            this.tbAmt.Size = new System.Drawing.Size(199, 21);
            this.tbAmt.TabIndex = 7;
            // 
            // tbMemo
            // 
            this.tbMemo.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.tbMemo.Location = new System.Drawing.Point(48, 92);
            this.tbMemo.Multiline = true;
            this.tbMemo.Name = "tbMemo";
            this.tbMemo.Size = new System.Drawing.Size(199, 111);
            this.tbMemo.TabIndex = 8;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(48, 210);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(199, 41);
            this.btnOK.TabIndex = 9;
            this.btnOK.Text = "확인";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // fIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 269);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tbMemo);
            this.Controls.Add(this.tbAmt);
            this.Controls.Add(this.tbType);
            this.Controls.Add(this.dtTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "입금";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnOK;
        public System.Windows.Forms.DateTimePicker dtTime;
        public System.Windows.Forms.TextBox tbType;
        public System.Windows.Forms.TextBox tbAmt;
        public System.Windows.Forms.TextBox tbMemo;
    }
}