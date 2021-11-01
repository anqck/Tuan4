using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    public class SinhVien
    {
        private int maSV;
        private string tenSV;
        private string khoa;
        private double diemTB;

        public SinhVien(int maSV, string tenSV, string khoa, double diemTB)
        {
            this.maSV = maSV;
            this.tenSV = tenSV;
            this.khoa = khoa;
            this.diemTB = diemTB;
        }

        public int MaSV { get => maSV; set => maSV = value; }
        public string TenSV { get => tenSV; set => tenSV = value; }
        public string Khoa { get => khoa; set => khoa = value; }
        public double DiemTB { get => diemTB; set => diemTB = value; }
    }
}
