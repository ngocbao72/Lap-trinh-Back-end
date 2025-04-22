//Bài 7: Viết chương trình kiểm tra xem một năm nhập vào có phải là năm nhuận hay không.
//(Năm nhuận là năm chia hết cho 4, trừ các năm chia hết cho 100 nhưng không chia hết cho 400).


using System;

class Program
{
    static void Main()
    {
        Console.Write("Ban hay nhap nam: ");
        int nam = int.Parse(Console.ReadLine());
        if ((nam % 4 == 0 && nam % 100 != 0) || (nam % 400 == 0))
            Console.WriteLine($"{nam} la nanm nhuan.");
        else
            Console.WriteLine($"{nam} khong phai lam nam nhuan.");
    }
}