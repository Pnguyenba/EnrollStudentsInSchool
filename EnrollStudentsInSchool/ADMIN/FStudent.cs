using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace EnrollStudentsInSchool_
{
    public partial class FStudent : UserControl
    {
        DateTime dateTime;
        MyExecuteNonQuery myExecuteNonQuery;
        InsertData insert;
        string TableName = "sinhvien";
        FindData find = new FindData();
        DataGridView dataGridView = new DataGridView();
        public FStudent()
        {
            InitializeComponent();
            insert = new InsertData();
            pnlMain.SetDoubleBuffered();
            dateTime = DateTime.Now;
            lbNamNhapHoc.Text = dateTime.Year.ToString();
            LoadData();
            btnUpdate.Enabled = false;
        }
        private void LoadData()
        {
            myExecuteNonQuery = new MyExecuteNonQuery();
            myExecuteNonQuery.LoadData(dgvStudent, TableName);
        }
        public bool CheckInputInfor()
        {
            if(find.Find("Select * from nguoidung where tenNguoiDung = '" + txtUserName.Text + "'"))
            {
                MessageBox.Show("TÊN NGƯỜI DÙNG ĐÃ TỒN TẠI");
                return false;
            }
            else if(find.Find("Select * from sinhvien where email = '" + txtEmail.Text + "'"))
            {
                MessageBox.Show("EMAIL ĐÃ TỒN TẠI");
                return false;
            }    
            else if(!find.Find("Select * from chuongtrinhdaotao where maChuongTrinhDaoTao = '" + txtChuongTrinhDaoTao.Text + "'"))
            {
                MessageBox.Show("MÃ CHƯƠNG TRÌNH ĐÀO TẠO K TỒN TẠI");
                return false;
            }
            else if (find.Find("Select * from sinhvien where SoCCCD = '" + txtCCCDorCMND.Text + "'"))
            {
                MessageBox.Show("CCCD/CMND ĐÃ TỒN TẠI");
                return false;
            }
            else if(!pnlMain.CheckInforInputIsEmpty())
            {
                MessageBox.Show("VUI LÒNG NHẬP ĐẦY ĐỦ THÔNG TIN");  return false;
            }    
            else if(!txtFullName.CheckStringContainsSpecialCharacters()|| !txtDantoc.CheckStringContainsSpecialCharacters() || !txtNoisinh.CheckStringContainsSpecialCharacters() || !txtDiachi.CheckAddress() || !txtEmail.CheckEmail())
            {
                MessageBox.Show("THÔNG TIN NHẬP KHÔNG HỢP LỆ");  return false;
            }
            else if(!txtCCCDorCMND.CheckStringIsNumber() || (txtCCCDorCMND.Text.Length != 9 && txtCCCDorCMND.Text.Length != 12) || !txtPhoneNumer.CheckStringIsNumber() || txtPhoneNumer.Text.Length!=10 || txtPhoneNumer.Text[0]!='0')
            {
                MessageBox.Show("THÔNG TIN NHẬP KHÔNG HỢP LỆ");  return false;
            }    
            return true;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(CheckInputInfor())
            {
                string gioitinh = "0";
                string Ngaysinh = dTP_Birthdate.Value.Year.ToString() + "-" + dTP_Birthdate.Value.Month.ToString() + "-" + dTP_Birthdate.Value.Day.ToString();
                if(cbGioiTinh.Checked == true)
                {
                    gioitinh = "1";
                }
                insert.Insert(txtFullName.Text, Ngaysinh, lbNamNhapHoc.Text, txtChuongTrinhDaoTao.Text, gioitinh, txtEmail.Text + "@gmail.com", txtPhoneNumer.Text,
                    txtDiachi.Text, txtNoisinh.Text,txtDantoc.Text, txtCCCDorCMND.Text, txtUserName.Text, txtPassWord.Text);
                LoadData();
            }    
        }

        private void btnTraMa_Click(object sender, EventArgs e)
        {
            if (btnTraMa.Text == "Tra mã")
            {
                dataGridView = new DataGridView();
                dataGridView.Location = new Point(dgvStudent.Location.X, dgvStudent.Location.Y);
                dataGridView.Height = 400;
                dataGridView.Dock = DockStyle.Bottom;
                pnlMain.Controls.Remove(dgvStudent);
                pnlMain.Controls.Add(dataGridView);
                myExecuteNonQuery.LoadData(dataGridView, "chuongtrinhdaotao");
                ResizeDatagridview.AutoResize(dataGridView);
                btnTraMa.Text = "Back";
            }    
            else
            {
                pnlMain.Controls.Remove(dataGridView);
                pnlMain.Controls.Add(dgvStudent);
                LoadData();
                btnTraMa.Text = "Tra mã";
                ResizeDatagridview.AutoResize(dgvStudent);
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if(!(new Regex("[^' ']").IsMatch(txtTimKiemSV.Text)))
            {
                MessageBox.Show("VUI LÒNG NHẬP MÃ SINH VIÊN CẦN TÌM KIẾM");
            }
            else if(!txtTimKiemSV.CheckStringIsNumber())
            {
                MessageBox.Show("MSSV KHÔNG CHỨA KÝ TỰ");
            }    
            else if(!find.Find("Select * from sinhvien where maSinhVien = " + txtTimKiemSV.Text + ""))
            {
                if(MessageBox.Show("SINH VIÊN BẠN TÌM KIẾM KHÔNG TỒN TẠI") == DialogResult.OK)
                {
                    txtTimKiemSV.ResetText();
                }       
            }
            else
            {
                LoadData();
                int dgvLenght = dgvStudent.Rows.Count;
                for (int row = 0; row < dgvLenght-1; row++)
                {
                    if(int.Parse(dgvStudent.Rows[row].Cells[0].Value.ToString()) != int.Parse(txtTimKiemSV.Text))
                    {
                        dgvStudent.Rows.RemoveAt(row);
                        dgvLenght--;
                        row--;
                    }
                }
            }
        }

        private void dgvStudentCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                cbGioiTinh.Checked = false;
                btnUpdate.Enabled = true;
                txtChuongTrinhDaoTao.Enabled = false;
                DataGridViewRow row = dgvStudent.Rows[e.RowIndex];
                txtFullName.Text = row.Cells[1].Value.ToString();
                lbNamNhapHoc.Text = row.Cells[3].Value.ToString();
                string[] Ngaysinh = row.Cells[2].Value.ToString().Split("/");
                dTP_Birthdate.Value = new DateTime(int.Parse(Ngaysinh[2].Split(" ")[0]), int.Parse(Ngaysinh[0]), int.Parse(Ngaysinh[1]));
                txtChuongTrinhDaoTao.Text = row.Cells[4].Value.ToString();
                if(row.Cells[5].Value.ToString() == "True")
                {
                    cbGioiTinh.Checked = true;
                }
                txtEmail.Text = row.Cells[6].Value.ToString();
                txtPhoneNumer.Text = row.Cells[7].Value.ToString();
                txtDiachi.Text = row.Cells[9].Value.ToString();
                txtNoisinh.Text = row.Cells[10].Value.ToString();
                txtDantoc.Text = row.Cells[11].Value.ToString();
                txtCCCDorCMND.Text = row.Cells[12].Value.ToString();
            }
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            btnUpdate.Enabled = false;
            txtChuongTrinhDaoTao.Enabled = true;
            foreach (Control txt in pnlMain.Controls)
            {
                if(txt is TextBox)
                {
                    txt.ResetText();
                }
            }    
        }
    }
}
