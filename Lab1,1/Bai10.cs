//Bài 10: Viết chương trình kiểm tra xem một số có phải là số nguyên tố hay không.

using System;

class Program
{
    static void Main()
    {
        Console.Write("Ban hay nhap mot so: ");
        int so = int.Parse(Console.ReadLine());
        bool laSoNguyenTo = true;

        if (so < 2)
            laSoNguyenTo = false;
        else
        {
            for (int i = 2; i <= Math.Sqrt(so); i++)
            {
                if (so % i == 0)
                {
                    laSoNguyenTo = false;
                    break;
                }
            }
        }

        if (laSoNguyenTo)
            Console.WriteLine($"{so} la so nguyen to.");
        else
            Console.WriteLine($"{so} khong phai la so nguyen to.");
    }
}