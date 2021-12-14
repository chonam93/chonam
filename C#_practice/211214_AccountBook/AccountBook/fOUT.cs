﻿using System;
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
    public partial class fOUT : Form
    {
        public fOUT()
        {
            InitializeComponent();
        }
        public fOUT(string 날짜, string 분류, string 금액, string 비고)
        {
            InitializeComponent();
            dtDate.Value = DateTime.Parse(날짜);
            tbType.Text = 분류;
            tbAmt.Text = 금액;
            tbMemo.Text = 비고;
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
