using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();  --- bu şekilde de yapılabilirdi.
            IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            TasitKrediManager tasitKrediManager = new TasitKrediManager();
            KonutKrediManager konutKrediManager = new KonutKrediManager();

            //loglama alternatifleri.
            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();


            List<ILoggerService> loggers = new List<ILoggerService> { new SmsLoggerService(), new FileLoggerService() };

            BasvuruManager basvuruManager = new BasvuruManager();
            // basvuruManager.BasvuruYap(tasitKrediManager, FileLoggerService());//böyle de olur aşağıdaki gibi de.
            // basvuruManager.BasvuruYap(tasitKrediManager, fileLoggerService);
            //basvuruManager.BasvuruYap(new EsnafKredisiManager(), fileLoggerService);
            //basvuruManager.BasvuruYap(new EsnafKredisiManager(), new List<ILoggerService> {new DatabaseLoggerService(),new SmsLoggerService() });
            basvuruManager.BasvuruYap(new EsnafKredisiManager(),loggers);

            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager, tasitKrediManager};

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
