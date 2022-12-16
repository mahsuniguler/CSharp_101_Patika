using System;

namespace Generic_list
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> sayiListesi = new List<int>();

            sayiListesi.Add(24);
            sayiListesi.Add(13);
            sayiListesi.Add(38);
            sayiListesi.Add(41);
            sayiListesi.Add(93);
            sayiListesi.Add(5);

            List<string> renkler = new List<string>();
            renkler.Add("Kırmızı");
            renkler.Add("Yeşil");
            renkler.Add("Turuncu");
            renkler.Add("Mavi");
            renkler.Add("Sarı");
            
            // Eleman Sayıları
            Console.WriteLine(renkler.Count);
            Console.WriteLine(sayiListesi.Count);

            // foreach ile sayiListesi Dizisinin Elemanlarını Tek tek Yazdırma
            foreach (var sayi in sayiListesi)
                Console.WriteLine(sayi);

            // foreach ile renkler Dizisinin Elemanlarını Tek tek Yazdırma
            foreach (var renk in renkler)
                Console.WriteLine(renk);

            // List.foreach ile Elemanları Yazdırma
            sayiListesi.ForEach(sayi=> Console.WriteLine(sayi));
            renkler.ForEach(renk => Console.WriteLine(renk));

            // Listeden Eleman Kaldırma
            sayiListesi.Remove(13);
            renkler.Remove("Turuncu");

            // List.foreach ile Elemanları Yazdırma
            sayiListesi.ForEach(sayi=> Console.WriteLine(sayi));
            renkler.ForEach(renk => Console.WriteLine(renk));
            // Listeden Sıra ile Eleman Kaldırma
            sayiListesi.RemoveAt(2);
            renkler.RemoveAt(1);

            // List.foreach ile Elemanları Yazdırma
            sayiListesi.ForEach(sayi=> Console.WriteLine(sayi));
            renkler.ForEach(renk => Console.WriteLine(renk));

            // Liste içinde arama
            Console.Write("Aradığınız Sayıyı Yazınız: ");
            int a = int.Parse(Console.ReadLine());
            if (sayiListesi.Contains(a))
                Console.WriteLine("10 Liste İçerisinde Bulundu!");
            else
                Console.WriteLine("10 Liste İçerisinde Bulunamadı!");
            
            // Elemanı ile index sırasını Yazdırma
            Console.Write("Aradığınız Rengi Yazınız: ");
            string renkl = Console.ReadLine();
            Console.WriteLine(renkler.BinarySearch(renkl));

            // Diziyi List'e Çevirme
            string[] hayvanlar = {"Ayı","İnek","Keçi"};
            List<string> hayvanListesi = new List<string>(hayvanlar);

            // Listeyi Temizleme
            hayvanListesi.Clear();
            
            // List İçerisinde Nesne Tutmak
            List<Kullanıcılar> kullanıcılistesi = new List<Kullanıcılar>();
            Kullanıcılar kullanıcı1 = new Kullanıcılar();
            kullanıcı1.Name = "Mustafa Mahsuni";
            kullanıcı1.Surname = "Güler";
            kullanıcı1.Age = 20;

            Kullanıcılar kullanıcı2 = new Kullanıcılar();
            kullanıcı2.Name = "Sema Nur";
            kullanıcı2.Surname = "Aydoğan";
            kullanıcı2.Age = 19;

            kullanıcılistesi.Add(kullanıcı1);
            kullanıcılistesi.Add(kullanıcı2);
            
            List<Kullanıcılar> yeniListe = new List<Kullanıcılar>();

            yeniListe.Add(new Kullanıcılar() { Name = "Beyza Nur", Surname = "Taşdelen", Age = 19});
            
            foreach (var kullanıcı in kullanıcılistesi)
            {
                Console.WriteLine("Kullanıcı Adı: "+kullanıcı.Name);
                Console.WriteLine("Kullanıcı Soyadı: "+kullanıcı.Surname);
                Console.WriteLine("Kullanıcı Yaşı: "+kullanıcı.Age);
            }
            yeniListe.Clear();

            Console.ReadKey();
        }
    }
    public class Kullanıcılar
    {
        private string name;
        private string surname;
        private int age;

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public int Age { get => age; set => age = value; }
    }
}