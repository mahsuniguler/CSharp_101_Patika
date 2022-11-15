using System;

namespace donguler_while_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            // While
            // 1 den başlayarak girilen sayıya kadar Sayıların Ortalamasını Yazdırmak
            Console.Write("Bir Sayı Giriniz:");
            int sayi = int.Parse(Console.ReadLine());
            int sayac=1,toplam=0;
            while (sayac<=sayi)
            {
                toplam+=sayac;
                sayac++;
            }
            int ortalama = toplam/sayi;
            Console.WriteLine(ortalama);

            // a dan z ye kadar tüm harfleri yazdır
            char character ='a';
            while (character<='z')
            {
                Console.Write(character);
                character++;
            }
            Console.ReadLine();
            Console.WriteLine("****** Foreach ******");
            string[] arabalar = {"BMW","Mercedes","Toyota","Nissan"};
            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }
            Console.ReadLine();
            
        }
    }
}