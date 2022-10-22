using System;

namespace if_else_if
{
    internal class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Adınızı Giriniz:");
            string name = Console.ReadLine();
            string or;
            while (true)
            {
                Console.WriteLine("Bay or Bayan");
                or = Console.ReadLine();
                if(or == "Bay")
                    or="Bey";
                else if(or == "Bayan")
                    or="Hanım";
                else
                    {continue;}
                break;
            }
            
            int time = DateTime.Now.Hour;
            if (5<=time && time<=10)
                Console.WriteLine(name + " " + or + " " + "Günaydın");

            else if (time <= 18)
                Console.WriteLine(name + " " + or + " " + "İyi Günler");
            else
                Console.WriteLine(name + " " + or + " " + "İyi Geceler");
            Console.ReadLine();

            string sonuc = (time>=6 && time<=10)?"Günaydın " + name + " " + or 
                : time<=18 ? "İyi Günler " + name + " " + or 
                : "İyi Geceler" + name + " " + or;
            Console.WriteLine(sonuc);

            Console.ReadLine();
        }
    }
}