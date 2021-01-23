using System;

namespace Oop2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 2;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "burak";
            musteri1.SoyAdi = "göksu";
            musteri1.TcNo = "124345678910";

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "12345";
            musteri2.SirketAdi = "göksu";
            musteri2.VergiNo = "124345678910";
            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);

        }

        

        

    }

   
}
