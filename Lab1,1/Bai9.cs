//Bài 9: Viết chương trình tính giai thừa của một số nguyên dương n.

using System;

class Program
{
    static void Main()
    {
        Console.Write("Ban hay nhap mot so nguyen duong: ");
        int n = int.Parse(Console.ReadLine());
        long giaiThua = 1;
        for (int i = 1; i <= n; i++)
        {
            giaiThua *= i;
        }
        Console.WriteLine($"Giai thua cua {n} la: {giaiThua}");
    }
}