//Bài 1: Viết một hàm để tính tổng của tất cả các số chẵn trong một mảng.


using System;

class Program
{
    static void Main()
    {
        int[] mang = { 1, 2, 3, 4, 5, 6 }; // Thay đổi mảng tùy ý
        int tongChan = TongSoChan(mang);
        Console.WriteLine($"Tong cac so chan la: {tongChan}");
    }

    static int TongSoChan(int[] arr)
    {
        int tong = 0;
        foreach (int so in arr)
        {
            if (so % 2 == 0)
                tong += so;
        }
        return tong;
    }
}