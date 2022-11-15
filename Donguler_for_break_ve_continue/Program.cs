using System;

namespace Donguler_for_break_ve_continue
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ekrana Girilen sayıya Kadar Olan Tek sayıları Yazdır
            Console.Write("Lütfen Bir Sayı Giriniz: ");
            int sayac = int.Parse(Console.ReadLine());
            for (int i = 1; i < sayac; i++)
            {
                if (i%2==1)
                {
                    Console.WriteLine(i);
                }
            }
            
            // 1 ile 1000 arasındaki tek ve çift sayıları Kendi İçlerinde Toplamlarını Ekrana Yazdır.
            int tekToplam=0,ciftToplam=0;
            for (int i = 1; i <= 1000; i++)
            {
                if (i%2==0)
                    ciftToplam+=i;
                else
                    tekToplam+=i;
            }
            Console.WriteLine("Çift Sayıların Toplamı: "+ciftToplam);
            Console.WriteLine("Tek Sayıların Toplamı: "+tekToplam);

            // break, continue

            // break
            for (int i = 1; i <= 10; i++)
            {
                if (i==4)
                    break;
                Console.WriteLine(i);
            }

            // continue
            for (int i = 1; i <= 10; i++)
            {
                if (i==4)
                    continue;
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}