//Bài 2: Viết chương trình tính diện tích của hình chữ nhật khi người dùng nhập chiều dài và chiều rộng.


using System;

class Program
{
    static void Main()
    {
        Console.Write("Ban hay nhap chieu dai: ");
        double chieuDai = double.Parse(Console.ReadLine());
        Console.Write("Ban hay nhap chieu rong: ");
        double chieuRong = double.Parse(Console.ReadLine());
        double dienTich = chieuDai * chieuRong;
        Console.WriteLine($"Dien tich hinh chu nhat la: {dienTich}");
    }
}