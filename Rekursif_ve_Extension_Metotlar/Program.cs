using System;

namespace Diziler
{
    class Program
    {
        static void Main(String[] args)
        {
            string[] renkler = new string[5];
            
            string[] hayvanlar = {"Kedi","Köpek","Kuş","Maymun"};
            int[] dizi;
            dizi = new int[5];
            
            //Dizılere Değer Atama ve Erlşım
            renkler[0] = "Mavi";
            dizi[3] = 10;

            Console.WriteLine(hayvanlar[1]); 
            Console.WriteLine(dizi[3]);
            Console.WriteLine(renkler[0]);

            // Döngüler dizi kullanımı
            // Klavyeden girilen n tane sayının ortalamasını Yazdırma
            Console.Write("Lütfen dizinin eleman sayisini giriniz: ");
            int diziUzunlugu = int.Parse(Console.ReadLine());
            int[] sayıDizisi = new int[diziUzunlugu];

            for (int i = 0; i < diziUzunlugu; i++)
            {
                Console.Write("Lültfen {0}. sayısı giriniz: ", i+1);
                sayıDizisi[i] = int.Parse(Console.ReadLine());
            }

            int toplam = 0;
            foreach (var sayi in sayıDizisi)
            {
                toplam += sayi;
            }

            Console.WriteLine("Ortalama :" + toplam/diziUzunlugu);
            Console.ReadLine();
        }
    }
}