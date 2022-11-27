using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritma_Odevi_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------- Soru 1 --------");
            Console.WriteLine("Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.");
            Console.Write("Dizi Uzunluğunu Giriniz: ");
            int n1 = int.Parse(Console.ReadLine());
            int[] dizi1 = new int[n1];
            for (int i = 0; i < n1; i++)
            {
                Console.Write("{0}. Sayıyı Giriniz: ",i+1);
                dizi1[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("** Çift Sayılar **");
            foreach (var cift in dizi1)
            {
                if (cift%2==0)
                    Console.WriteLine(cift);
            }
            Console.ReadKey();

            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("-------- Soru 2 --------");
            Console.WriteLine("Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.");
            Console.Write("Dizi Uzunluğunu Giriniz: ");
            int n2 = int.Parse(Console.ReadLine());
            int[] dizi2 = new int[n2];
            Console.Write("Karşılaştırılacak Sayıyı Giriniz: ");
            int m = int.Parse(Console.ReadLine());
            for (int i = 0; i < n2; i++)
            {
                Console.Write("{0}. Sayıyı Giriniz: ",i+1);
                dizi2[i] = int.Parse(Console.ReadLine());
            }

            foreach (var sayi in dizi2)
            {
                if (sayi % m == 0 || sayi == m)
                    Console.WriteLine("----> {0}",sayi);
            }
            Console.ReadKey();

            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("-------- Soru 3 --------");
            Console.WriteLine("Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.");
            Console.Write("Dizi Uzunluğunu Giriniz: ");
            int n3 = int.Parse(Console.ReadLine());
            string[] kelimeler = new string[n3];
            for (int i = 0; i < n3; i++)
            {
                Console.Write("{0}. Kelimeyi Giriniz: ",i+1);
                kelimeler[i] = Console.ReadLine();
            }
            Console.WriteLine("Girilen Kelimelerin Tersten Yazdıralım");
            for (int i = kelimeler.Count(); 0 < i; i--)
            {
                System.Console.WriteLine(kelimeler[i-1]);
            }
            Console.ReadKey();
            
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("-------- Soru 4 --------");
            Console.WriteLine("Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.");
            Console.Write("Cümle Yazınız: ");
            int say =  0;
            string karakterler = "0123456789/*<>.:,;!abcçdefgğhıijklmnoöprsştuüvxyz";
            string cumle = Console.ReadLine();
            cumle = cumle.ToLower();
            string[] kelimeler_ = cumle.Split(' ');
            Console.WriteLine("Kelime Sayısı: {0}",kelimeler_.Length);
            for (int i = 0; i < cumle.Length; i++)
            {
                // Harfleri kontrol ediyoruz.
                if(karakterler.Contains(cumle[i]));
                    say++;
            }
            Console.WriteLine("Harf Sayısı: {0}",say);
            Console.ReadKey();

        }
    }
}
