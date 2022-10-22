using System;

namespace deneme
{
    internal class Program
    {
        static void Main(String[] args)
        {
            try
            {
                Console.WriteLine("Bir Sayı Giriniz: ");
                int Sayı = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girmiş Olduğunuz sayı : " + Sayı);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Hata : " + ex.Message.ToString());
            }
            finally
            {
                Console.WriteLine("İşlem Tamamlandı.");
            }
            
            try
            {
                int a = int.Parse(null);
                int b = int.Parse("test");
                int c = int.Parse("20000000000");
            }
            catch (ArgumentNullException ex)
            {
                System.Console.WriteLine("Boş Değer Giriniz.");
                System.Console.WriteLine(ex);
            }
            catch(FormatException ex)
            {
                System.Console.WriteLine("Veri Tipi Uygun Değildir.");
                System.Console.WriteLine(ex);
            }
            catch(OverflowException ex)
            {
                System.Console.WriteLine("Çok küçük veya çok büyük değer girdiniz.");
                System.Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("İşlem Tamamlandı.");
            }

            Console.ReadLine();
        }
    }
}