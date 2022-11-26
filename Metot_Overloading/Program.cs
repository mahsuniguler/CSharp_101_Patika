using System;

namespace Metot_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            // out parametre
            BaşaDön:
            string sayi = Console.ReadLine();
            int outsayi;
            bool sonuc= int.TryParse(sayi, out outsayi);
            if (sonuc)
            {
                System.Console.WriteLine("Başarılı!");
                System.Console.WriteLine(outsayi);
            }
            else
            {
                System.Console.WriteLine("Başarısız!");
                goto BaşaDön;
            }

            Metotlar2 metotlar = new Metotlar2();
            metotlar.Topla(7, 9, out int toplamSonucu);
            System.Console.WriteLine(toplamSonucu);
            
            // Metot Aşırı Yükleme - Overloading

            int ifade = 1453;
            int ifade1 = 10;
            int ifade2 = 50;

            metotlar.EkranaYazdır(ifade.ToString());
            metotlar.EkranaYazdır(ifade);
            metotlar.EkranaYazdır("Mustafa Mahsuni "+"Güler");
            metotlar.EkranaYazdır(ifade1,ifade2);

            Console.ReadKey();
        }
    }

    class Metotlar2
    {
        public void Topla(int a, int b, out int toplam)
        {
            toplam = a + b;
            
        }

        public void EkranaYazdır(string veri)
        {
            Console.WriteLine(veri);
        }

        public void EkranaYazdır(int veri)
        {
            Console.WriteLine(veri);
        }

        public void EkranaYazdır(string veri1,string veri2)
        {
            Console.WriteLine(veri1+veri2);
        }

        public void EkranaYazdır(int veri1,int veri2)
        {
            Console.WriteLine(veri1+veri2);
        }
    }
}
