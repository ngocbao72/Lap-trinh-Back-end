//Bài 2: Viết chương trình nhập vào mảng gồm n phần tử nhập từ bàn phím. Viết hàm để kiểm
//tra xem một số có phải là số nguyên tố hay không, hiển thị chỉ số và giá trị của những phần tử
//là số nguyên tố trong mảng.

using System;

class Program
{
    static void Main()
    {
        Console.Write("Ban hay nhap so phan tu cua mang: ");
        int n = int.Parse(Console.ReadLine());
        int[] mang = new int[n];

        Console.WriteLine("Ban hay nhap cac gia tri:");
        for (int i = 0; i < n; i++)
        {
            mang[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Cac so nguyen to trong mang la:");
        for (int i = 0; i < n; i++)
        {
            if (KiemTraSoNguyenTo(mang[i]))
                Console.WriteLine($"Chi so: {i}, Gia tri: {mang[i]}");
        }
    }

    static bool KiemTraSoNguyenTo(int so)
    {
        if (so < 2) return false;
        for (int i = 2; i <= Math.Sqrt(so); i++)
        {
            if (so % i == 0) return false;
        }
        return true;
    }
}