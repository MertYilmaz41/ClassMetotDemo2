using System;

namespace Deneme
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Adi = "Başar";
            musteri1.Id = 31;
            musteri1.Yasi = 19;

            Musteri musteri2 = new Musteri();
            musteri2.Adi = "İlker";
            musteri2.Id = 69;
            musteri2.Yasi = 19;

            Musteri musteri3 = new Musteri();
            musteri3.Adi = "Melih";
            musteri3.Id = 12;
            musteri3.Yasi = 5;

            Musteri musteri4 = new Musteri();
            musteri4.Adi = "Mert";
            musteri4.Id = 10;
            musteri4.Yasi = 20;

            MusteriManager musteriManager = new MusteriManager();

            Console.WriteLine("--------------------------------------Müşteri Ekleme İşlemleri------------------------------------");

            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriEkle(musteri2);
            musteriManager.MusteriEkle(musteri3);
            musteriManager.MusteriEkle(musteri4);

            Console.WriteLine("--------------------------------------Müşteri Silme İşlemleri-------------------------------------");

            musteriManager.MusteriSil(musteri1);
            musteriManager.MusteriSil(musteri2);
            musteriManager.MusteriSil(musteri3);
            musteriManager.MusteriSil(musteri4);

            Console.WriteLine("--------------------------------------Müşteri Listeleme İşlemi------------------------------------");

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3, musteri4};

            musteriManager.MusteriListele(musteriler);
        }
    }
}
