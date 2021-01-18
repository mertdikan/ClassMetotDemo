using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteriler)
        {
            Console.WriteLine("{0} {1}, sistemimize eklendi", musteriler.Ad, musteriler.Soyad);

        }

        public void Listele(Musteri[] musteriler)
        {
            Console.WriteLine("\tAdı\t\tSoyadı\t\tEposta\t\t\t\tŞehir");
            for (int i = 0; i < musteriler.Length; i++)
            {
                Console.WriteLine("\t{0}\t\t{1}\t\t{2}\t\t{3}", musteriler[i].Ad, musteriler[i].Soyad, musteriler[i].TcNo, musteriler[i].Sehir);
            }

        }

        public void Sil(Musteri musteriler)
        {
            Console.WriteLine("{0} {1}, adlı müşteri kaydı silindi!", musteriler.Ad, musteriler.Soyad);
            
        }
    }
}
