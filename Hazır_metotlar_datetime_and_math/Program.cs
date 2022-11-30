using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now); // Şimdiki tarih
            Console.WriteLine(DateTime.Now.Date); // dd.mm.yyyy
            Console.WriteLine(DateTime.Now.Day); // dd
            Console.WriteLine(DateTime.Now.Month); // mm
            Console.WriteLine(DateTime.Now.Year); // yyyy
            Console.WriteLine(DateTime.Now.Hour); // Saat
            Console.WriteLine(DateTime.Now.Minute); // Dakika
            Console.WriteLine(DateTime.Now.Second); // Saniye

            Console.WriteLine(DateTime.Now.DayOfWeek); // Gün
            Console.WriteLine(DateTime.Now.DayOfYear); // Yılın Kaçıncı Günü Olduğunu Gösterir

            Console.WriteLine(DateTime.Now.ToLongDateString()); // DD MMMM YYYY Gün Böyle
            Console.WriteLine(DateTime.Now.ToShortDateString()); // DD.MM.YYYY
            Console.WriteLine(DateTime.Now.ToLongTimeString()); // H:M:S
            Console.WriteLine(DateTime.Now.ToShortTimeString()); // H:M

            Console.WriteLine(DateTime.Now.AddDays(20)); // 20 Gün Eklenir.
            Console.WriteLine(DateTime.Now.AddHours(36)); // 36 Saat Eklenir.
            Console.WriteLine(DateTime.Now.AddSeconds(120)); // 120 Saniye Eklenir.
            Console.WriteLine(DateTime.Now.AddMonths(8)); // 8 Ay Eklenir.
            Console.WriteLine(DateTime.Now.AddYears(60)); // 60 Yıl Eklenir.
            Console.WriteLine(DateTime.Now.AddMilliseconds(1000)); // 1000 Milisaniye Eklenir.

            // Datetime Format
            Console.WriteLine(DateTime.Now.ToString("dd")); //24 
            Console.WriteLine(DateTime.Now.ToString("ddd")); //Sat 
            Console.WriteLine(DateTime.Now.ToString("dddd")); //Saturday

            Console.WriteLine(DateTime.Now.ToString("M")); //04
            Console.WriteLine(DateTime.Now.ToString("MMM")); //Apr
            Console.WriteLine(DateTime.Now.ToString("MMMM")); //April

            Console.WriteLine(DateTime.Now.ToString("YY")); //21
            Console.WriteLine(DateTime.Now.ToString("YYYY")); //2021

            Console.WriteLine("*********** Math Kütüphanesi ***********");
            //Math Kütüphanesi
            Console.WriteLine(Math.Abs(-35)); // 355; 
            Console.WriteLine(Math.Sin(10)); 
            Console.WriteLine(Math.Cos(10)); 
            Console.WriteLine(Math.Tan(10));

            Console.WriteLine(Math.Ceiling(22.3)); // 23 
            Console.WriteLine(Math.Round(22.3)); // 22 
            Console.WriteLine(Math.Round(22.7)); // 23 
            Console.WriteLine(Math.Floor(22.7)); // 22

            Console.WriteLine(Math.Max(2,6));
            Console.WriteLine(Math.Min(2,6));

            Console.WriteLine(Math.Pow(2,6)); // 2^6 ü verir. 64. 
            Console.WriteLine(Math.Sqrt(36)); // karekök alır. 6
            Console.WriteLine(Math.Log(9)); // 9 un e tabanındaki logoritmık karşılığını getirir.   Console.WriteLıne(Math.Exp(3)); // e üzeri 3 ü verir. 
            Console.WriteLine(Math.Exp(3)); // e üzeri 3 ü verir. 
            Console.WriteLine(Math.Log10(10)); // 10 sayısının logaritma 10 tabanındaki karşılığı.

            Console.ReadKey();
        }
    }
}
