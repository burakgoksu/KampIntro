﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class IhtıyacKrediManager : IKrediManager
    {
        public void BiSeyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("Ihtiyaç kredisi ödeme planı hesaplandı");
        }
    }
}
