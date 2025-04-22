//Bài 8: Viết chương trình in ra bảng cửu chương từ 1 đến 10.

using System;

class Program
{
    static void Main()
    {
        for (int i = 1; i <= 10; i++)
        {
            for (int j = 1; j <= 10; j++)
            {
                Console.Write($"{i} x {j} = {i * j}\t");
            }
            Console.WriteLine();
        }
    }
}