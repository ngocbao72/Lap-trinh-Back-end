//Bài 3: Viết chương trình chuyển đổi nhiệt độ từ độ C sang độ F
//Công thức: F = (C * 9/5) + 32


using System;

class Program
{
    static void Main()
    {
        Console.Write("Ban hay nhap nhiet do (do C): ");
        double doC = double.Parse(Console.ReadLine());
        double doF = (doC * 9 / 5) + 32;
        Console.WriteLine($"Nhiet do tuong ung (do F): {doF}");
    }
}