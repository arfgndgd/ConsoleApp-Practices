using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();

            Customer customer2 = new Customer() { ID=1, FirstName= "Ahmet", LastName= "Gündoğdu"};
            Console.WriteLine(customer2.FirstName);

            //hata almamak için constructora parametre vermemiz lazım çünkü constructorlar method mantığında çalışır 

            Customer customer1 = new Customer(2,"Arif","Gündoğdu");
            Console.WriteLine(customer1.FirstName);

            //iki farklı durumda yani hem parametreli hem parametresiz çalıştırmak istediğimizde iki tane constructor açar isek sorun çözülür
        }
    }
    class Customer
    {
        public Customer()
        {

        }
        //default constructor ; aslında burada proje çalıştığında default constructor vardır. Instance alındığında zaten new Customer() dediği için aynı görevi yapar.


        public Customer(int id, string firstName, string lastName)
        {
            ID = id;
            FirstName = firstName;
            LastName = lastName;

        }
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}
