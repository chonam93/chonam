
namespace AccountBook
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnIN = new System.Windows.Forms.ToolStripButton();
            this.btnOUT = new System.Windows.Forms.ToolStripButton();
            this.btnLogin = new System.Windows.Forms.ToolStripButton();
            this.btnEdit = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.switch_month = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnSave = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.btnConfirm = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.sbUserName = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tbMonth = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.sbSumIn = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.sbSumOut = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.lv1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.편집ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.삭제ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sbAmt = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnIN,
            this.btnOUT,
            this.btnLogin,
            this.btnEdit,
            this.btnDelete,
            this.switch_month,
            this.toolStripDropDownButton1,
            this.btnConfirm});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(758, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnIN
            // 
            this.btnIN.Image = ((System.Drawing.Image)(resources.GetObject("btnIN.Image")));
            this.btnIN.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnIN.Name = "btnIN";
            this.btnIN.Size = new System.Drawing.Size(51, 22);
            this.btnIN.Text = "입금";
            this.btnIN.Click += new System.EventHandler(this.btnIN_Click);
            // 
            // btnOUT
            // 
            this.btnOUT.Image = ((System.Drawing.Image)(resources.GetObject("btnOUT.Image")));
            this.btnOUT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOUT.Name = "btnOUT";
            this.btnOUT.Size = new System.Drawing.Size(51, 22);
            this.btnOUT.Text = "출금";
            this.btnOUT.Click += new System.EventHandler(this.btnOUT_Click);
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
            // btnEdit
            // 
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(51, 22);
            this.btnEdit.Text = "편집";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(51, 22);
            this.btnDelete.Text = "삭제";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // switch_month
            // 
            this.switch_month.Image = ((System.Drawing.Image)(resources.GetObject("switch_month.Image")));
            this.switch_month.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.switch_month.Name = "switch_month";
            this.switch_month.Size = new System.Drawing.Size(63, 22);
            this.switch_month.Text = "월변경";
            this.switch_month.Click += new System.EventHandler(this.switch_month_Click);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSave,
            this.btnLoad});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(91, 22);
            this.toolStripDropDownButton1.Text = "test_Menu";
            this.toolStripDropDownButton1.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(122, 22);
            this.btnSave.Text = "저장하기";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(122, 22);
            this.btnLoad.Text = "불러오기";
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirm.Image")));
            this.btnConfirm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(63, 22);
            this.btnConfirm.Text = "월마감";
            this.btnConfirm.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2,
            this.sbUserName,
            this.toolStripStatusLabel6,
            this.tbMonth,
            this.toolStripStatusLabel5,
            this.sbSumIn,
            this.toolStripStatusLabel3,
            this.sbSumOut,
            this.toolStripStatusLabel4,
            this.sbAmt});
            this.statusStrip1.Location = new System.Drawing.Point(0, 441);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(758, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(43, 17);
            this.toolStripStatusLabel2.Text = "사용자";
            // 
            // sbUserName
            // 
            this.sbUserName.Name = "sbUserName";
            this.sbUserName.Size = new System.Drawing.Size(16, 17);
            this.sbUserName.Text = "...";
            // 
            // toolStripStatusLabel6
            // 
            this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            this.toolStripStatusLabel6.Size = new System.Drawing.Size(43, 17);
            this.toolStripStatusLabel6.Text = "선택월";
            // 
            // tbMonth
            // 
            this.tbMonth.Name = "tbMonth";
            this.tbMonth.Size = new System.Drawing.Size(17, 17);
            this.tbMonth.Text = "__";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(43, 17);
            this.toolStripStatusLabel5.Text = "입금합";
            // 
            // sbSumIn
            // 
            this.sbSumIn.Name = "sbSumIn";
            this.sbSumIn.Size = new System.Drawing.Size(14, 17);
            this.sbSumIn.Text = "0";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(43, 17);
            this.toolStripStatusLabel3.Text = "출금합";
            // 
            // sbSumOut
            // 
            this.sbSumOut.Name = "sbSumOut";
            this.sbSumOut.Size = new System.Drawing.Size(14, 17);
            this.sbSumOut.Text = "0";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(31, 17);
            this.toolStripStatusLabel4.Text = "잔액";
            // 
            // lv1
            // 
            this.lv1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lv1.ContextMenuStrip = this.contextMenuStrip1;
            this.lv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv1.FullRowSelect = true;
            this.lv1.GridLines = true;
            this.lv1.HideSelection = false;
            this.lv1.Location = new System.Drawing.Point(0, 25);
            this.lv1.MultiSelect = false;
            this.lv1.Name = "lv1";
            this.lv1.Size = new System.Drawing.Size(758, 416);
            this.lv1.TabIndex = 2;
            this.lv1.UseCompatibleStateImageBehavior = false;
            this.lv1.View = System.Windows.Forms.View.Details;
            this.lv1.DoubleClick += new System.EventHandler(this.lv1_DoubleClick);
            this.lv1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lv1_KeyDown);
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
            // columnHeader3
            // 
            this.columnHeader3.Text = "입금";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "출금";
            this.columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "비고";
            this.columnHeader5.Width = 200;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.편집ToolStripMenuItem,
            this.삭제ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(99, 48);
            // 
            // 편집ToolStripMenuItem
            // 
            this.편집ToolStripMenuItem.Name = "편집ToolStripMenuItem";
            this.편집ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.편집ToolStripMenuItem.Text = "편집";
            this.편집ToolStripMenuItem.Click += new System.EventHandler(this.편집ToolStripMenuItem_Click);
            // 
            // 삭제ToolStripMenuItem
            // 
            this.삭제ToolStripMenuItem.Name = "삭제ToolStripMenuItem";
            this.삭제ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.삭제ToolStripMenuItem.Text = "삭제";
            this.삭제ToolStripMenuItem.Click += new System.EventHandler(this.삭제ToolStripMenuItem_Click);
            // 
            // sbAmt
            // 
            this.sbAmt.Name = "sbAmt";
            this.sbAmt.Size = new System.Drawing.Size(14, 17);
            this.sbAmt.Text = "0";
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 463);
            this.Controls.Add(this.lv1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "가계부";
            this.Load += new System.EventHandler(this.fMain_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnIN;
        private System.Windows.Forms.ToolStripButton btnOUT;
        private System.Windows.Forms.ToolStripButton btnLogin;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel sbSumOut;
        private System.Windows.Forms.ToolStripStatusLabel sbUserName;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ListView lv1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ToolStripButton btnEdit;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem btnSave;
        private System.Windows.Forms.ToolStripMenuItem btnLoad;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 편집ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 삭제ToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel sbSumIn;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripButton switch_month;
        private System.Windows.Forms.ToolStripButton btnConfirm;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel6;
        private System.Windows.Forms.ToolStripStatusLabel tbMonth;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel sbAmt;
    }
}

