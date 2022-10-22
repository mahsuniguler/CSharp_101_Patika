using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deneme2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Implicit Conversion (Bilinçsiz Dönüşüm)
            Console.WriteLine("***** Implicit Conversion *****");

            byte a = 5;
            sbyte b = 30;
            short c = 10;

            int d = a+b+c;
            Console.WriteLine("d: " + d);
            
            long h = d;
            Console.WriteLine("h: " + h);

            float ı = h;
            Console.WriteLine("ı: " + ı);

            string e = "Mahsuni";
            char f = 'G';
            object g = e+f+d;
            Console.WriteLine("g: " + g);
            Console.ReadLine();

            // Explicit Conversion (Bilinçli Dönüşüm)
            Console.WriteLine("***** Explicit Conversion *****");

            int x = 4;
            byte y = (byte)x;
            Console.WriteLine("y: " + y);

            int z = 100;
            byte t = (byte)z;
            Console.WriteLine("t: " + t);

            float w = 10.3f;
            byte v = (byte)w;
            Console.WriteLine("v: " + v);
            Console.ReadLine();

            // ToString Metodu
            Console.WriteLine("***** ToString Metodu *****");

            int xx = 6;
            string yy = xx.ToString();
            Console.WriteLine("yy: " + yy);

            string zz = 12.4f.ToString();
            Console.WriteLine("zz: " + zz);
            Console.ReadLine();

            // System.Convert
            Console.WriteLine("***** System.Convert *****");

            string s1 = "10",s2="20";
            int sayı1, sayı2;
            int Toplam;

            sayı1 = Convert.ToInt32(s1);
            sayı2 = Convert.ToInt32(s2);
            Toplam = sayı1 + sayı2;
            Console.WriteLine(Toplam);
            Console.ReadLine();

            // Parse
            Console.WriteLine("***** Parse Methodu *****");
            
            ParseMethod();

            Console.ReadLine();
        }
        public static void ParseMethod()
        {
            string metin1 = "10";
            string metin2 = "10.25";
            int rakam1;
            double double1;

            rakam1 = Int32.Parse(metin1);
            Console.WriteLine("rakam1: " + rakam1);
            double1 = Double.Parse(metin2);
            Console.WriteLine("doble1: " + double1);

        }
    }
}