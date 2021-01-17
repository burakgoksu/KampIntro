using System;
using System.Collections.Generic;
using System.Text;

namespace Matematik
{
    class DortIslem
    {
        public void Topla(int a ,int b)
        {
            int toplam = a + b;
            Console.WriteLine(toplam);
        }
        public void Cıkar(int a, int b)
        {
            int sonuc = a - b;
            Console.WriteLine(sonuc);
        }
        public void Carp(int a, int b)
        {
            int carpım = a * b;
            Console.WriteLine(carpım);
        }
        public void Bol(int a, int b)
        {
            int sonuc = a / b;
            Console.WriteLine(sonuc);
        }
    }
}
