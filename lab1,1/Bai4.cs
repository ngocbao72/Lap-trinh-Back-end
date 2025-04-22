//Bài 4: Viết chương trình nhập vào một số nguyên và kiểm tra xem số đó có phải là số chẵn hay không.

using System;

class Program
{
    static void Main()
    {
        Console.Write("Ban hay nhap mot so nguyem: ");
        int so = int.Parse(Console.ReadLine());
        if (so % 2 == 0)
            Console.WriteLine($"{so} la so chan.");
        else
            Console.WriteLine($"{so} la so le.");
    }
}