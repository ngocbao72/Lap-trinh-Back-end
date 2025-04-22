//Bài 6: Viết chương trình kiểm tra xem một số nhập vào có phải là số dương, số âm hay số không.


using System;

class Program
{
    static void Main()
    {
        Console.Write("Ban hay nhap mot so: ");
        int so = int.Parse(Console.ReadLine());
        if (so > 0)
            Console.WriteLine($"{so} la so duong.");
        else if (so < 0)
            Console.WriteLine($"{so} la so am.");
        else
            Console.WriteLine("Day la so khong.");
    }
}