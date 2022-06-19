using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EnrollStudentsInSchool_
{
    public partial class FMonHoc : UserControl
    {
        MyExecuteNonQuery myExecuteNonQuery;
        string TableName = "monhoc";
        public FMonHoc()
        {
            InitializeComponent();
            pnlMain.SetDoubleBuffered();
            myExecuteNonQuery = new MyExecuteNonQuery();
            myExecuteNonQuery.LoadData(dgvMonhoc, TableName);
        }

        private void btnTraMaChuongTrinhDaoTao_Click(object sender, EventArgs e)
        {
            FChuongTrinhDaoTao fChuongTrinhDaoTao = new FChuongTrinhDaoTao();
            MainControls.Show(fChuongTrinhDaoTao,pnlMain, fChuongTrinhDaoTao.dgvChuongTrinhDaoTao);
        }
    }
}
