using System;

namespace OOP2
{
    //Abstraction (Soyutlama)
    class Program
    {
        static void Main(string[] args)
        {
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.ID = 1;
            customer1.CustomerNo = "21313";
            customer1.Name = "Arif";
            customer1.Surname = "Gündoğdu";
            customer1.TcNo = "32131313123";

            CorporateCustomer customer2 = new CorporateCustomer();
            customer2.ID = 2;
            customer2.CustomerNo = "543543";
            customer2.CompanyName = "Kodlama";
            customer2.TaxNo = "213131311";

            Customer customer3 = new IndividualCustomer();
            Customer customer4 = new CorporateCustomer();

            CustomerManager manager = new CustomerManager();
            manager.Add(customer1);
            manager.Add(customer2);
        }
    }
}
