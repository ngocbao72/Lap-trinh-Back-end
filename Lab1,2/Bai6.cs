//Bài 6: Viết hàm sắp xếp mảng số thực n phần tử nhập từ bàn phím theo chiều tăng dần.

using System;

class Program
{
    static void Main()
    {
        Console.Write("Ban hay nhap so phan tu cua mang la: ");
        int n = int.Parse(Console.ReadLine());
        double[] mang = new double[n];

        Console.WriteLine("Ban hay nhap cac phan tu la:");
        for (int i = 0; i < n; i++)
        {
            mang[i] = double.Parse(Console.ReadLine());
        }

        SapXepTangDan(mang);
        Console.WriteLine("Mang sau khi sap xep la:");
        foreach (double so in mang)
        {
            Console.WriteLine(so);
        }
    }

    static void SapXepTangDan(double[] arr)
    {
        Array.Sort(arr);
    }
}