using System;
using System.Collections.Generic;
using System.Text;

namespace EnrollStudentsInSchool_
{
    class UpdateData : MyExecuteNonQuery
    {
        public void Update(string Mssv, string hoten, string ngaySinh, string NamNhapHoc, string MaCTDT, string gioitinh, string email, string sdt, string ngayxoa, string diachi, string noisinh,
            string dantoc, string CCCD)
        {
            string query = $"EXEC update_sv {Mssv}, N'{hoten}', '{ngaySinh}', {NamNhapHoc}, '{MaCTDT}', {gioitinh}, '{email}', '{sdt}', '{ngayxoa}', N'{diachi}', N'{noisinh}', N'{dantoc}', '{CCCD}'";
            ExecutenQuery(query);
        }
    }
}
