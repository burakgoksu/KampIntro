using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "engin";
            int yas = 36;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "java";
            kurs1.KursunEgitmeni = "kerem";
            kurs1.IzlenmeOrani = 64;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Python";
            kurs2.KursunEgitmeni = "berkay";
            kurs2.IzlenmeOrani = 80;

            // Console.WriteLine(kurs1.KursAdi + " " + kurs1.KursunEgitmeni)   ;

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2 };

            foreach(var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.KursunEgitmeni);
            }
        } 
        

    }

    class Kurs
    {
        public string KursAdi { get; set; }

        public string KursunEgitmeni { get; set; }

        public int IzlenmeOrani { get; set; }
    }

}
