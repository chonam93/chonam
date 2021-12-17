using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gridview_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            DataTable table = new DataTable();

            //column 추가
            table.Columns.Add("ID", typeof(string));
            table.Columns.Add("제목", typeof(string));
            table.Columns.Add("구분", typeof(string));
            table.Columns.Add("생성일", typeof(string));
            table.Columns.Add("수정일", typeof(string));

            table.Rows.Add("ID 1", "제목 1번", "사용중", "2019/03/11", "2019/03/18");
            table.Rows.Add("ID 2", "제목 2번", "미사용", "2019/03/12", "2019/03/18");
            table.Rows.Add("ID 3", "제목 3번", "미사용", "2019/03/13", "2019/03/18");
            table.Rows.Add("ID 4", "제목 4번", "사용중", "2019/03/14", "2019/03/18");
            // 값들이 입력된 테이블을 DataGridView에 입력합니다.
            dataGridView1.DataSource = table;
        }

        

    }
}
