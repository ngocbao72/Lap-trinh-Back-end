//Bài 4: Viết hàm để tìm số lớn thứ hai trong một mảng các số nguyên

using System;

class Program
{
    static void Main()
    {
        Console.Write("Ban hay nhap so phan tu cua mnag la: ");
        int n = int.Parse(Console.ReadLine());
        int[] mang = new int[n];

        Console.WriteLine("Ban hay nhap cac phan tu la:");
        for (int i = 0; i < n; i++)
        {
            mang[i] = int.Parse(Console.ReadLine());
        }

        int soLonThucHai = TimSoLonThucHai(mang);
        Console.WriteLine($"So lon thu hai la: {soLonThucHai}");
    }

    static int TimSoLonThucHai(int[] arr)
    {
        int max1 = int.MinValue, max2 = int.MinValue;
        foreach (int so in arr)
        {
            if (so > max1)
            {
                max2 = max1;
                max1 = so;
            }
            else if (so > max2 && so != max1)
            {
                max2 = so;
            }
        }
        return max2;
    }
}