using System;
using System.Collections.Generic;
using System.Text;

namespace Deneme
{
    class MusteriManager
    {
        public void MusteriEkle (Musteri musteri)
        {
            Console.WriteLine(musteri.Adi + " " + "adlı müşteri başarıyla eklendi.");
        }

        public void MusteriSil (Musteri musteri)
        {
            Console.WriteLine(musteri.Adi + " " + "adlı müşteri başarıyla silindi.");
        }

        public void MusteriListele (Musteri[] musteriler)
        {
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Adi + " " + "adlı müşteri başarıyla listelendi.");
            }
        }
    }
}
