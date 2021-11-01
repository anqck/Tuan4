using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5
{
    public partial class Form1 : Form
    {
        List<SinhVien> sinhViens;
        public Form1()
        {
            InitializeComponent();
            DataProvider.InitializeConnection();

            sinhViens = SinhVienDA.GetAllSinhViens();
            DisplayAllSinhVienToGridView();

            SinhVien tmp = new SinhVien(21521243, "Nguyen Van C", "KTMT", 10);
            SinhVienDA.ThemSinhVien(tmp);
        }


        private void DisplayAllSinhVienToGridView()
        {
            dataGridView1.Rows.Clear();

            int STT = 1;
            foreach(SinhVien sinhVien in sinhViens)
            {
                dataGridView1.Rows.Add(STT++, sinhVien.MaSV.ToString(), sinhVien.TenSV, sinhVien.Khoa, sinhVien.DiemTB.ToString());
            }    
        }
    }
}
