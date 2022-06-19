using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EnrollStudentsInSchool_
{
    public partial class FUserAccount : UserControl
    {
        MyExecuteNonQuery myExecuteNonQuery;
        string TableName = "nguoidung";
        public FUserAccount()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            myExecuteNonQuery = new MyExecuteNonQuery();
            myExecuteNonQuery.LoadData(dgvUserAccount, TableName);
        }
    }
}
