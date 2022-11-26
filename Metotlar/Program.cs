using System;

namespace Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a =int.Parse(Console.ReadLine());
            int b =int.Parse(Console.ReadLine());

            
            int sonuc1 = Topla(a, b);
            Console.WriteLine(sonuc1);

            Metotlar orneksınıf = new Metotlar();
            orneksınıf.EkranaYazdır(sonuc1.ToString());

            int sonuc2 = orneksınıf.ArttırVeTopla(ref a,ref b);
            orneksınıf.EkranaYazdır((sonuc2).ToString());
            orneksınıf.EkranaYazdır((a+b).ToString());
            
        }
        static int Topla(int sayi1,int sayi2)
        {
            return (sayi1+sayi2);
        }
    }

    class Metotlar
    {
        public void EkranaYazdır(string veri)
        {
            System.Console.WriteLine(veri);
        }

        public int ArttırVeTopla(ref int num1, ref int num2)
        {
            num1+=1;
            num2+=1;
            return (num1+num2);
        }
    }
}
