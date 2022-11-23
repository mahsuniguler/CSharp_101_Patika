using System;

namespace Diziler_Array_Sinifi_Metodlari
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sort
            int[] sayiDizisi = {23,12,5,86,47,2,54,87};

            Console.WriteLine("-------- Sırasız Dizi --------");
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }
            Console.WriteLine("-------- Sıralı Dizi --------");
            Array.Sort(sayiDizisi);
            
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            // Clear
            Console.WriteLine("-------- Array Clear --------");
            // SayiDizisi elemanlarını Kullanarak 2. indexten itibaren 1 tane elemanı 0'lar.
            Array.Clear(sayiDizisi,2,1);
            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);

            // Reverse
            Console.WriteLine("-------- Array Reverse --------");
            Array.Reverse(sayiDizisi);
            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);

            // İndexOf
            Console.WriteLine("-------- Array İndexOf --------");
            Console.WriteLine(Array.IndexOf(sayiDizisi,23));
            
            // Resize 
            Console.WriteLine("-------- Array Resize --------");
            Array.Resize<int>(ref sayiDizisi,9);
            sayiDizisi[8]=99;

            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);


            Console.ReadLine();
        }
    }
}