using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Ad = "Ferdi";
            musteri1.Soyad = "Aydoğdu";
            musteri1.TcNo = "12345678901";
            musteri1.HesapNo = 147852;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Ad = "Ali";
            musteri2.Soyad = "Yavuz";
            musteri2.TcNo = "987654321";
            musteri2.HesapNo = 258741;

            Musteri[] musteriler = new Musteri[] {musteri1, musteri2};

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Sil(musteri1);
            Console.WriteLine("--Müşteriler--");
            musteriManager.Listele(musteriler);
        }
    }
}
