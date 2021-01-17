using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            String kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemGiriş = true;
            Console.WriteLine(kategoriEtiketi);
            double dolarDun = 7.45;
            double dolarBugun = 7.55;
            
            if(dolarDun > dolarBugun)
            {
                Console.WriteLine("azalış");
            }
            else if(dolarDun < dolarBugun)
            {
                Console.WriteLine("artış");
            }
            else
            {
                Console.WriteLine("sabit");
            }

            if (sistemGiriş){
                Console.WriteLine("kullanıcı ayarları butonu");

            }
            else
            {
                Console.WriteLine("giriş yap butonu");
            }
        }
    }
}

 