using System;
using System.Collections.Generic;
using System.Text;

namespace EnrollStudentsInSchool_
{
    class InsertData : MyExecuteNonQuery
    {
        public void Insert(string Ten, string NgaySinh, string Namhoc, string maCTDT, string gioitinh, string email, string sdt, string diachi, string noisinh,
            string dantoc, string soCCCD, string UserName, string PassWord)
        {
            string query = $"INSERT INTO sinhvien VALUES(N'{Ten}', '{NgaySinh}', {Namhoc}, '{maCTDT}', {gioitinh}, '{email}', '{sdt}', NULL, N'{diachi}', N'{noisinh}', N'{dantoc}', '{soCCCD}') ";          
            query += $"DECLARE @id int SELECT maSinhVien FROM sinhvien SELECT @id = @@ROWCOUNT INSERT INTO nguoidung VALUES('{UserName}','{PassWord}', N'Sinh Viên',NULL,@id)";
            ExecutenQuery(query);
        }
    }
}
