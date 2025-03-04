using System;

class Program
{
    static void Main()
    {
        // 2️ Kullanıcıdan bir sayı alıp tek mi çift mi olduğunu bulan program
        Console.Write("Bir sayı girin: ");
        int sayi1 = Convert.ToInt32(Console.ReadLine());

        if (sayi1 % 2 == 0)
        {
            Console.WriteLine("Sayı çift.");
        }
        else
        {
            Console.WriteLine("Sayı tek.");
        }

        // 3️ Girilen bir sayının pozitif, negatif veya sıfır olup olmadığını belirleyen program
        Console.Write("Bir sayı girin: ");
        int sayi2 = Convert.ToInt32(Console.ReadLine());

        if (sayi2 > 0)
        {
            Console.WriteLine("Sayı pozitif.");
        }
        else if (sayi2 < 0)
        {
            Console.WriteLine("Sayı negatif.");
        }
        else
        {
            Console.WriteLine("Sayı sıfır.");
        }
    }
}
