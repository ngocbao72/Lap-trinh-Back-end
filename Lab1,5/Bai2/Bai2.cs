using System;
using System.Collections.Generic;

namespace Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Hinh> danhSachHinh = new List<Hinh>
            {
                new HinhTron(5),
                new HinhVuong(4),
                new HinhTamGiac(3, 4, 5),
                new HinhChuNhat(6, 3)
            };

            double tongChuVi = 0;
            double tongDienTich = 0;

            foreach (var hinh in danhSachHinh)
            {
                tongChuVi += hinh.TinhChuVi();
                tongDienTich += hinh.TinhDienTich();
            }

            Console.WriteLine($"Tong chu vi cac hinh la: {tongChuVi}");
            Console.WriteLine($"Tong dien tich cac hinh la: {tongDienTich}");
        }
    }
}