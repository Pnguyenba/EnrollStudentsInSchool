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
        DataGridView dataGridView = new DataGridView();
        

        public FLopHocPhan()
        {
            InitializeComponent();
            pnlMain.SetDoubleBuffered();
            loaddata();
        }

        private void loaddata()
        {
            myExecuteNonQuery = new MyExecuteNonQuery();
            myExecuteNonQuery.LoadData(dgvLopHocPhan, TableName);

        }

        private void btnTraMa_MonHoc_Click(object sender, EventArgs e)
        {
            if (btnTraMa_MonHoc.Text == "Tra mã")
            {
                if (btnTraMa_GV.Text == "Back")
                {
                    dataGridView.Swap(dgvLopHocPhan, pnlMain, "lophocphan");
                    btnTraMa_GV.Text = "Tra mã";
                }
                dataGridView = new DataGridView();
                dgvLopHocPhan.Swap(dataGridView, this.pnlMain, "chuongtrinhdaotao");
                btnTraMa_MonHoc.Text = "Back";
            }
            else
            {
                dataGridView.Swap(dgvLopHocPhan, this.pnlMain, "sinhvien");
                btnTraMa_MonHoc.Text = "Tra mã";
            }

        }
        private void btnTraMa_GV_Click(object sender, EventArgs e)
        {
            if (btnTraMa_GV.Text == "Tra mã")
            {
                if (btnTraMa_MonHoc.Text == "Back")
                {
                    dataGridView.Swap(dgvLopHocPhan, pnlMain, "lophocphan");
                    btnTraMa_MonHoc.Text = "Tra mã";
                }
                dgvLopHocPhan.Swap(dataGridView, pnlMain, "nhanvien");
                btnTraMa_GV.Text = "Back";
            }
            else
            {
                dataGridView.Swap(dgvLopHocPhan, pnlMain, "lophocphan");
                btnTraMa_GV.Text = "Tra mã";
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            
        }
    }
}
