using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            VucutKitleIndeksHesapla();
            var toplam = SayilariTopla(13);
        }

        /// <summary>
        /// 1'den parametre olarak gönderilen sayıya kadar olan sayıların toplamını döndüren fonksiyon.
        /// </summary>
        /// <param name="sonSayi"></param>
        /// <returns></returns>
        public static int SayilariTopla(int sonSayi)
        {
            var toplam = 0;
            for (int i = 1; i <= sonSayi; i++)
            {
                toplam = toplam + i;
                Console.WriteLine(toplam);
            }

            return toplam;

        }

        /// <summary>
        /// Konsolda girilen boy ve kilo bilgilerine göre vücut kitle indeks'ini konsola yazdıran fonksiyon.
        /// </summary>
        public static void VucutKitleIndeksHesapla()
        {
            Console.WriteLine("isminizi girin");
            string isim = Console.ReadLine();

            Console.WriteLine("soyisminizi girin");
            string soyisim = Console.ReadLine();

            Console.WriteLine("kilonuzu girin");
            float kilo = float.Parse(Console.ReadLine());

            Console.WriteLine("boyunuzu girin");
            float boy = float.Parse(Console.ReadLine());

            float indeks = kilo / (boy * boy);

            Console.WriteLine($"sayın {isim} {soyisim} kilo indeksiniz:{indeks} ");
        }
    }
}
