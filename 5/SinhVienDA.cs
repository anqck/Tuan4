using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    public class SinhVienDA
    {
        //public static DataTable GetAllSinhViens()
        //{
        //    return DataProvider.ExecuseQuery("SELECT * FROM sinhvien;");
        //}

        public static List<SinhVien> GetAllSinhViens()
        {

            DataTable dt =  DataProvider.ExecuseQuery("SELECT * FROM sinhvien;");

            List<SinhVien> result = new List<SinhVien>();

            foreach(DataRow row in dt.Rows)
            {
                result.Add(new SinhVien(Convert.ToInt32(row["MaSV"]), row["TenSV"].ToString(), row["Khoa"].ToString(), Convert.ToDouble(row["DiemTB"])));
            }   
            
            return result;
        }

        public static void ThemSinhVien(SinhVien sinhVien)
        {
            string queryStr = "INSERT INTO `sinhvien` (`MaSV`, `TenSV`, `Khoa`, `DiemTB`) VALUES ('"+ sinhVien.MaSV.ToString() +"', '"+sinhVien.TenSV+"', '"+sinhVien.Khoa+"', '"+sinhVien.DiemTB.ToString()+"');";
            DataProvider.ExecuseNonQuery(queryStr);
        }
    }
}
