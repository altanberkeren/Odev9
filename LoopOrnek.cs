using System;

class Program
{
    static void Main(string[] args)
    {
        int[] sayilar = new int[5];
        int toplam = 0;

        //Kullanıcıdan sayıları al
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Sayi {i + 1}: ");
            sayilar[i] = Convert.ToInt32(Console.ReadLine());
        }

        //Toplamı hesapla
        foreach (int sayi in sayilar)
        {
            toplam += sayi;
        }

        //Ortalama
        double ortalama = toplam / 5.0;

        Console.WriteLine($"Toplam: {toplam}");
        Console.WriteLine($"Ortalama: {ortalama}");
    }
}
