using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kurslar = new string[] { "java", "python", "c" ,"c++","c#","go"};

            for(int i=0;i<10; i++)
            {
                Console.WriteLine(i);
            }

            for(int i=0;i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("sayfa sonu");

            foreach (string e in kurslar)
            {
                Console.WriteLine(e);
            }
        }
    }
}
