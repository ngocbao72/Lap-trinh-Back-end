//Bài 5: Viết hàm hoán vị 2 số nguyên a và b nhập từ bàn phím

using System;

class Program
{
    static void Main()
    {
        Console.Write("Ban hay nhap so nguyen a la: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Ban hay nhap so nguyen b la: ");
        int b = int.Parse(Console.ReadLine());

        HoanVi(ref a, ref b);
        Console.WriteLine($"Sau hoan vi: a = {a}, b = {b}");
    }

    static void HoanVi(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }
}