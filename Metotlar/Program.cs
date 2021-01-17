using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi ="elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "amasya elması";
            urun1.StokAdedi = 20;

            Urun urun2 = new Urun();
            urun2.Adi = "karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";
            urun2.StokAdedi = 25;


            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine(urun.StokAdedi);
                Console.WriteLine("---------------");
            }

            Console.WriteLine("-----------Metotlar-----------");

            //insrance- örnek

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            Console.WriteLine();
            sepetManager.Ekle2(urun1.Adi, urun1.Aciklama, urun1.Fiyati);

        }


    }
}
