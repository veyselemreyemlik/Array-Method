using System;

namespace ArrayClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********Sırasız Diziler********");

            int[] sayiDizisi = { 1, 2, 3, 4, 5, 15, 17, 18, 234, 9875 };
                foreach (int i in sayiDizisi)
                Console.WriteLine(i);

            Console.WriteLine("********Sıralı Diziler********");

            int[] sayi = { 1, 2, 3, 234, 456, 334, 523, 23242, 234234, 423423 };
            // Sort Metodunu Kullarak Sayıları Sıralayarak Yazdırıyoruz.
               Array.Sort(sayi);
               foreach (int i in sayi)
               Console.WriteLine(i);

            Console.WriteLine("********Clear Metodu********");
            // Clear Metodu İle Dizideki Sayılarda 2.İndexten Başlayıp 2 Tane Siler.
               Array.Clear(sayi,2,2);  
               foreach (int i in sayi)
               Console.WriteLine(i);

            Console.WriteLine("********Reverse Metodu********");
            // Reverse Metodu İle Diziyi Tersten Yazdırır.
               Array.Reverse(sayi);
               foreach (int i in sayi)
               Console.WriteLine(i);

            Console.WriteLine("********IndexOf Metodu********");
            // IndexOf Metodu İle Dizi İçerisindeki Değerlerin Kaçıncı İndexte Olduğunu Yazdırır.
               Console.WriteLine(Array.IndexOf(sayi,456));

            Console.WriteLine("********Resize Metodu********");
            // Diziyi Yeniden Boyutlandırıyor.
               Array.Resize<int>(ref sayi, 10);
               sayi[9] = 1905;
               foreach (int i in sayi)
               Console.WriteLine(i);
        }
    }
}
