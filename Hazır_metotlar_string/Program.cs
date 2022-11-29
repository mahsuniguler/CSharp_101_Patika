using System;

namespace Hazır_metotlar_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string degişken = "Dersimiz CSharp, Hoşgeldiniz";
            string degişken2 = "Dersimiz CSharp";
            string degişken3 = "dersimiz CSharp, Hoşgeldiniz";
            string degişken4 = "CSharp";
            
            // Length
            Console.WriteLine(degişken.Length);

            // ToUpper, ToLower
            Console.WriteLine(degişken.ToUpper());
            Console.WriteLine(degişken.ToLower());

            // Concat
            Console.WriteLine(string.Concat(degişken," Merhaba!"));            

            // Compare, CompareTo
            Console.WriteLine(degişken.CompareTo(degişken2));//0,1,-1
            Console.WriteLine(string.Compare(degişken,degişken3,true));
            Console.WriteLine(string.Compare(degişken,degişken3,false));

            // Contains
            Console.WriteLine(degişken.Contains(degişken4));
            Console.WriteLine(degişken.EndsWith("Hoşgeldiniz"));
            Console.WriteLine(degişken.StartsWith("Merhaba!"));

            // İndexOf
            Console.WriteLine(degişken.IndexOf("CS"));
            Console.WriteLine(degişken.IndexOf("Mahsuni"));

            // Insert
            Console.WriteLine(degişken.Insert(0,"Merhaba! "));
            Console.WriteLine(degişken.LastIndexOf("i"));

            // PadLeft, PadRight
            Console.WriteLine(degişken4 + degişken.PadLeft(30));
            Console.WriteLine(degişken4 + degişken.PadLeft(30,'*'));
            Console.WriteLine(degişken.PadRight(40) + degişken4);
            Console.WriteLine(degişken.PadRight(40, '-') + degişken4);

            // Remove
            Console.WriteLine(degişken.Remove(10));
            Console.WriteLine(degişken.Remove(4,6));
            Console.WriteLine(degişken.Remove(0,1));

            // Replace
            Console.WriteLine(degişken.Replace("CSharp","C#"));
            Console.WriteLine(degişken.Replace(" ","*"));

            // Split
            Console.WriteLine(degişken.Split(' ')[0]);
            Console.WriteLine(degişken.Split(' ')[1]);
            Console.WriteLine(degişken.Split(' ')[2]);

            // Substring
            Console.WriteLine(degişken.Substring(4));
            Console.WriteLine(degişken.Substring(4,6));
            Console.ReadKey();
        }
    }
}
