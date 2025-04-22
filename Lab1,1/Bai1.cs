//Bài 1: Viết chương trình nhập vào tên và tuổi, sau đó in ra màn hình thông báo "Xin chào [tên], bạn [tuổi] tuổi!".
using System;

class Program
{
    static void Main()
    {
        Console.Write("Ban hay nhap ten cua ban: ");
        string ten = Console.ReadLine();
        Console.Write("Ban hay nhap tuoi cua ban: ");
        int tuoi = int.Parse(Console.ReadLine());
        Console.WriteLine($"Xin chao {ten}, ban {tuoi} tuoi!");
    }
}