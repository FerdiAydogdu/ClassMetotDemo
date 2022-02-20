using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " isimli müşteri eklendi");
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " isimli müsteri silindi");
        }

        public void Listele(Musteri[] musteriler)
        {
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Ad + " " + musteri.Soyad);
            }
        }
    }
}
