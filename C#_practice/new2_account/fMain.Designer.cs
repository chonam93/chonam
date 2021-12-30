
namespace new2_account
{
    partial class fMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.fIN = new System.Windows.Forms.ToolStripButton();
            this.fOUT = new System.Windows.Forms.ToolStripButton();
            this.fEdit = new System.Windows.Forms.ToolStripButton();
            this.fDelete = new System.Windows.Forms.ToolStripButton();
            this.fsave = new System.Windows.Forms.ToolStripButton();
            this.btnLogin = new System.Windows.Forms.ToolStripButton();
            this.switchMonth = new System.Windows.Forms.ToolStripButton();
            this.endMonth = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tbName = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.tbMonth = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.tbInSum = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.tbOutSum = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.tbSumSum = new System.Windows.Forms.ToolStripButton();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fIN,
            this.fOUT,
            this.fEdit,
            this.fDelete,
            this.fsave,
            this.btnLogin,
            this.switchMonth,
            this.endMonth});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(755, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "출금";
            // 
            // fIN
            // 
            this.fIN.Image = ((System.Drawing.Image)(resources.GetObject("fIN.Image")));
            this.fIN.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fIN.Name = "fIN";
            this.fIN.Size = new System.Drawing.Size(51, 22);
            this.fIN.Text = "입금";
            this.fIN.Click += new System.EventHandler(this.fIN_Click);
            // 
            // fOUT
            // 
            this.fOUT.Image = ((System.Drawing.Image)(resources.GetObject("fOUT.Image")));
            this.fOUT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fOUT.Name = "fOUT";
            this.fOUT.Size = new System.Drawing.Size(51, 22);
            this.fOUT.Text = "출금";
            this.fOUT.Click += new System.EventHandler(this.fOUT_Click);
            // 
            // fEdit
            // 
            this.fEdit.Image = ((System.Drawing.Image)(resources.GetObject("fEdit.Image")));
            this.fEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fEdit.Name = "fEdit";
            this.fEdit.Size = new System.Drawing.Size(51, 22);
            this.fEdit.Text = "편집";
            this.fEdit.Click += new System.EventHandler(this.fEdit_Click);
            // 
            // fDelete
            // 
            this.fDelete.Image = ((System.Drawing.Image)(resources.GetObject("fDelete.Image")));
            this.fDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fDelete.Name = "fDelete";
            this.fDelete.Size = new System.Drawing.Size(51, 22);
            this.fDelete.Text = "삭제";
            this.fDelete.Click += new System.EventHandler(this.fDelete_Click);
            // 
            // fsave
            // 
            this.fsave.Image = ((System.Drawing.Image)(resources.GetObject("fsave.Image")));
            this.fsave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fsave.Name = "fsave";
            this.fsave.Size = new System.Drawing.Size(75, 22);
            this.fsave.Text = "저장하기";
            this.fsave.Click += new System.EventHandler(this.fsave_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnLogin.Image = ((System.Drawing.Image)(resources.GetObject("btnLogin.Image")));
            this.btnLogin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(63, 22);
            this.btnLogin.Text = "로그인";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // switchMonth
            // 
            this.switchMonth.Image = ((System.Drawing.Image)(resources.GetObject("switchMonth.Image")));
            this.switchMonth.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.switchMonth.Name = "switchMonth";
            this.switchMonth.Size = new System.Drawing.Size(63, 22);
            this.switchMonth.Text = "월변경";
            this.switchMonth.Click += new System.EventHandler(this.switchMonth_Click);
            // 
            // endMonth
            // 
            this.endMonth.Image = ((System.Drawing.Image)(resources.GetObject("endMonth.Image")));
            this.endMonth.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.endMonth.Name = "endMonth";
            this.endMonth.Size = new System.Drawing.Size(63, 22);
            this.endMonth.Text = "월마감";
            this.endMonth.Click += new System.EventHandler(this.endMonth_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.tbName,
            this.toolStripButton2,
            this.tbMonth,
            this.toolStripButton4,
            this.tbInSum,
            this.toolStripButton6,
            this.tbOutSum,
            this.toolStripButton8,
            this.tbSumSum});
            this.toolStrip2.Location = new System.Drawing.Point(0, 420);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(755, 25);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(47, 22);
            this.toolStripButton1.Text = "사용자";
            // 
            // tbName
            // 
            this.tbName.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tbName.Image = ((System.Drawing.Image)(resources.GetObject("tbName.Image")));
            this.tbName.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(23, 22);
            this.tbName.Text = "..";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(47, 22);
            this.toolStripButton2.Text = "선택월";
            // 
            // tbMonth
            // 
            this.tbMonth.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tbMonth.Image = ((System.Drawing.Image)(resources.GetObject("tbMonth.Image")));
            this.tbMonth.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbMonth.Name = "tbMonth";
            this.tbMonth.Size = new System.Drawing.Size(23, 22);
            this.tbMonth.Text = "..";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(47, 22);
            this.toolStripButton4.Text = "입금합";
            // 
            // tbInSum
            // 
            this.tbInSum.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tbInSum.Image = ((System.Drawing.Image)(resources.GetObject("tbInSum.Image")));
            this.tbInSum.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbInSum.Name = "tbInSum";
            this.tbInSum.Size = new System.Drawing.Size(23, 22);
            this.tbInSum.Text = "0";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(47, 22);
            this.toolStripButton6.Text = "출금합";
            // 
            // tbOutSum
            // 
            this.tbOutSum.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tbOutSum.Image = ((System.Drawing.Image)(resources.GetObject("tbOutSum.Image")));
            this.tbOutSum.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbOutSum.Name = "tbOutSum";
            this.tbOutSum.Size = new System.Drawing.Size(23, 22);
            this.tbOutSum.Text = "0";
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton8.Image")));
            this.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.Size = new System.Drawing.Size(35, 22);
            this.toolStripButton8.Text = "잔액";
            // 
            // tbSumSum
            // 
            this.tbSumSum.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tbSumSum.Image = ((System.Drawing.Image)(resources.GetObject("tbSumSum.Image")));
            this.tbSumSum.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbSumSum.Name = "tbSumSum";
            this.tbSumSum.Size = new System.Drawing.Size(23, 22);
            this.tbSumSum.Text = "0";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 25);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(755, 395);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "날짜";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "분류";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "입금";
            this.columnHeader6.Width = 150;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "출금";
            this.columnHeader7.Width = 150;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "비고";
            this.columnHeader8.Width = 200;
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 445);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "가계부";
            this.Load += new System.EventHandler(this.fMain_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ToolStripButton fIN;
        private System.Windows.Forms.ToolStripButton fOUT;
        private System.Windows.Forms.ToolStripButton fEdit;
        private System.Windows.Forms.ToolStripButton fDelete;
        private System.Windows.Forms.ToolStripButton btnLogin;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton tbName;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton tbInSum;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripButton tbOutSum;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.ToolStripButton tbSumSum;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton tbMonth;
        private System.Windows.Forms.ToolStripButton fsave;
        private System.Windows.Forms.ToolStripButton switchMonth;
        private System.Windows.Forms.ToolStripButton endMonth;
    }
}

