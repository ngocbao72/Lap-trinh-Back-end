//Bài 5: Viết chương trình tính tổng và tích của hai số nhập từ bàn phím.

using System;

class Program
{
    static void Main()
    {
        Console.Write("Ban hhay nhap so thu nhat: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Ban hay nhap so thu hai: ");
        int b = int.Parse(Console.ReadLine());
        int tong = a + b;
        int tich = a * b;
        Console.WriteLine($"Tong: {tong}, Tich: {tich}");
    }
}