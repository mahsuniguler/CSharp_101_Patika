using System;

namespace console_programlama
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Adınızı Giriniz:");
            string name =Console.ReadLine();
            Console.WriteLine("Soyadınızı Giriniz:");
            string surname =Console.ReadLine();
            
            Console.WriteLine("Hi "+name + " " + surname);
            Console.ReadLine();

        }
    }
}