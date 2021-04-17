using System;
using System.Collections.Generic;

namespace OPP3
{
    //Polymorphism (Çok Biçimlilik)
    class Program
    {
        static void Main(string[] args)
        {
            //PersonelCreditManager personel = new PersonelCreditManager();
            //personel.Calculate();

            //VehicleCreditManager vehicle = new VehicleCreditManager();
            //vehicle.Calculate();

            //EstateCreditManager estate = new EstateCreditManager();
            //estate.Calculate();

            //Sınıf isimleri yerine interfaceide yazabiliriz aynı göreve yapar

            CreditManager personel = new PersonelCreditManager();
            CreditManager vehicle = new VehicleCreditManager();
            CreditManager estate = new EstateCreditManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            ApplyManager apply = new ApplyManager();
            //apply.Apply(vehicle, new DatabaseLoggerService()); 
            apply.Apply(vehicle,databaseLoggerService);
            //hangi kredi türünü verir isek onu gösterir.

            List<CreditManager> credits = new List<CreditManager>() { personel,estate};
            apply.CreditPreInfo(credits);
        }
    }
}
