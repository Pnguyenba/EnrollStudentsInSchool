using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EnrollStudentsInSchool_
{
    public partial class FLopHocPhan : UserControl
    {
        MyExecuteNonQuery myExecuteNonQuery;
        string TableName = "lophocphan";
        public FLopHocPhan()
        {
            InitializeComponent();
            pnlMain.SetDoubleBuffered();
            myExecuteNonQuery = new MyExecuteNonQuery();
            myExecuteNonQuery.LoadData(dgvLopHocPhan, TableName);
        }
    }
}
