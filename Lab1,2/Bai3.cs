//Bài 3: Viết một hàm để đếm số lượng số âm và số dương trong một mảng gồm n phần tử nhập
//từ bàn phím.

using System;

class Program
{
    static void Main()
    {
        Console.Write("Ban hay nhap so phan tu cua mang la: ");
        int n = int.Parse(Console.ReadLine());
        int[] mang = new int[n];

        Console.WriteLine("Ban hay nhap cac phan tu la:");
        for (int i = 0; i < n; i++)
        {
            mang[i] = int.Parse(Console.ReadLine());
        }

        (int soDuong, int soAm) = DemSoDuongVaAm(mang);
        Console.WriteLine($"So duong: {soDuong}, So am: {soAm}");
    }

    static (int, int) DemSoDuongVaAm(int[] arr)
    {
        int soDuong = 0, soAm = 0;
        foreach (int so in arr)
        {
            if (so > 0) soDuong++;
            else if (so < 0) soAm++;
        }
        return (soDuong, soAm);
    }
}