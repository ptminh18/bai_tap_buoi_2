using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_tap_ve_nha_buoi_2.NET
{
    class SinhVienb
    {
        private int maSinhVien;
        private string hoTen;
        private double diemLyThuyet;
        private double diemThucHanh;

        public int MaSinhVien { get => maSinhVien; set => maSinhVien = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public double DiemLyThuyet { get => diemLyThuyet; set => diemLyThuyet = value; }
        public double DiemThucHanh { get => diemThucHanh; set => diemThucHanh = value; }

        public SinhVienb()
        {
            maSinhVien = 0;
            hoTen = "";
            diemLyThuyet = 0.0;
            diemThucHanh = 0.0;
        }
        public SinhVienb(int msv, string ten, double diemLT, double diemTH)
        {
            maSinhVien = msv;
            hoTen = ten;
            diemLyThuyet = diemLT;
            diemThucHanh = diemTH;
        }
        public double AverageCal()
        {
            return (diemLyThuyet + diemThucHanh) / 2;
        }
    }
}
