using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_tap_ve_nha_buoi_2.NET
{
    class Program
    {
        static void Main(string[] args)
        {
            SinhVien sv = new SinhVien(2001215959, "Banh Mi Bo Sua", 8.5, 9.0);
            //Console.WriteLine("Diem trung binh cua sinh vien: {0}", sv.AverageCal());
            SinhVienb svb = new SinhVienb(2001215959, "Phan The Minh", 9.5, 9.0);
            SinhVienb svb1 = new SinhVienb(2001211234, "Arata Imai", 10.0, 9.0);
            SinhVienb svb2 = new SinhVienb();

            Console.Write("Ma so sinh vien 3: ");
            svb2.MaSinhVien = int.Parse(Console.ReadLine());
            Console.Write("Ho ten sinh vien 3: ");
            svb2.HoTen = Console.ReadLine();
            Console.Write("Diem ly thuyet cua sinh vien 3: ");
            svb2.DiemLyThuyet = double.Parse(Console.ReadLine());
            Console.Write("Diem thuc hanh cua sinh vien 3: ");
            svb2.DiemThucHanh = double.Parse(Console.ReadLine());

            //output
            Console.WriteLine("Ma sv \t   Ho ten \t\t\t\t Diem ly thuyet \t Diem thuc hanh \t Trung binh");
            Console.WriteLine("{0} {1} \t\t\t\t    {2} \t\t      {3} \t\t      {4}", svb.MaSinhVien, svb.HoTen, svb.DiemLyThuyet, svb.DiemThucHanh, svb.AverageCal());
            Console.WriteLine("{0} {1} \t\t\t\t\t     {2} \t\t      {3} \t\t       {4}", svb1.MaSinhVien, svb1.HoTen, svb1.DiemLyThuyet, svb1.DiemThucHanh, svb1.AverageCal());
            Console.WriteLine("{0} {1} \t\t\t\t    {2} \t\t      {3} \t\t       {4}", svb2.MaSinhVien, svb2.HoTen, svb2.DiemLyThuyet, svb2.DiemThucHanh, svb2.AverageCal());
            Console.ReadKey();
        }
    }
}
