using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Ad = "Mert";
            musteri1.Soyad = "DİKAN";
            musteri1.TcNo = 1234566197;
            musteri1.Sehir = "Istanbul";

            Musteri musteri2 = new Musteri();
            musteri2.Ad = "Uğurcan";
            musteri2.Soyad = "ÇAKIR";
            musteri2.TcNo = 1234566196;
            musteri2.Sehir = "Trabzon";

            Musteri musteri3 = new Musteri();
            musteri3.Ad = "Vitor";
            musteri3.Soyad = "HUGO";
            musteri3.TcNo = 1234566190;
            musteri3.Sehir = "Trabzon";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);


            Console.WriteLine("\n---------------------------MÜŞTERİ LİSTESİ-----------------------------");
            musteriManager.Listele(musteriler);


            Console.WriteLine("\n -----------------------------------------------------------------------");
            musteriManager.Sil(musteri2);
            Console.ReadLine();




        }
         
    }
}
