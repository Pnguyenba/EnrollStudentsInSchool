﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EnrollStudentsInSchool_
{
    public partial class FStaff : UserControl
    {
        MyExecuteNonQuery myExecuteNonQuery;
        string TableName = "nhanvien";
        public FStaff()
        {
            InitializeComponent();
            pnlMain.SetDoubleBuffered();
            myExecuteNonQuery = new MyExecuteNonQuery();
            myExecuteNonQuery.LoadData(dgvStaff, TableName);
        }
    }
}
