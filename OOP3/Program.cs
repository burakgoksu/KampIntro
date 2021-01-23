using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtıyacKrediManager();
            IKrediManager tasitKrediManager = new TasıtKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService dataBaseLoggerService = new DataBaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService> { new DataBaseLoggerService(), new SmsLoggerService() };

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(new EsnafKredisiManager(),loggers );
            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager , tasitKrediManager, konutKrediManager };
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
            
        }
    }
}
