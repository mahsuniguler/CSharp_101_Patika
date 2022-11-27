using System;

namespace Rekürsif_ve_Extension_Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Rekürsif - Öz Yineleme
            int result = 1;
            for (int i = 1; i < 5; i++)
                result *= 3;
            Console.WriteLine(result);

            Islemler islemler = new Islemler();
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(islemler.Expo(a,b));

            //Extension Metotlar
            string ifade = "Mustafa Mahsuni Güler";
            bool sonuc = ifade.CheckSpaces();
            Console.WriteLine(sonuc);

            if (sonuc)
                Console.WriteLine(ifade.RemoveWhiteSpaces());
            
            Console.WriteLine(ifade.MakeUpperCase());
            Console.WriteLine(ifade.MakeLowerCase());

            int[] dizi = {5,7,4,8,3,1,9};
            dizi.SortArray();
            dizi.EkranaYaz();

            int sayi = 4;
            
            Console.WriteLine(sayi.IsEvenNumber());

            Console.WriteLine(ifade.GetFirstCharacter());
            Console.ReadKey();
        }
    }

    public class Islemler
    {
        public int Expo(int sayi, int üs)
        {
            if (üs<2)
                return sayi;
            return Expo(sayi,üs-1) * sayi;
        }
    }

    public static class Extension
    {
        public static bool CheckSpaces(this string param)
        {
            return param.Contains(" ");
        }

        public static string RemoveWhiteSpaces(this string param)
        {
            string[] dizi = param.Split(" ");
            return string.Join("",dizi);
        }

        public static string MakeUpperCase(this string param)
        {
            return param.ToUpper();
        }

        public static string MakeLowerCase(this string param)
        {
            return param.ToLower();
        }

        public static int[] SortArray(this int[] param)
        {
            Array.Sort(param);
            return param;
        }

        public static void EkranaYaz(this int[] param)
        {
            foreach (var item in param)
                Console.WriteLine(item);
        }

        public static bool IsEvenNumber(this int param)
        {
            return param % 2 == 0;
        }

        public static string GetFirstCharacter(this string param)
        {
            return param.Substring(0,1);
        }
    }
}