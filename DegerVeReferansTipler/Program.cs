using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 20;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1 ? !! cevap 20 !!

            //sayi1 = sayi2 olduğunda sayi1'e atanan değer artık 20'dir. 


            //değer tipler = int, decimal, float, doublei bool (sayisal değer alabilen)
            //referans tipler = array, class, interface


            //ancak referans tiplerde bu şekilde gerçekleşmez. array değişkenlerini belleğin stack kısmında tutar. array değerlerini ise belleğin heap kısmında tutar. bellekte her iki kısımda da değer ve değişkene aynı referans değerini verir. (101: sayilar1, {1,2,3}; 102: sayilar2, {10,20,30})
            //yani sayilar1 = sayilar2 eşitliği durumunda bellekteki referans değerleri eşitlenir.
            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //sayilar1[0] ??  !! cevap 999 !!


            /**/
            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Engin";
            person2 = person1;
            person1.FirstName = "Arif";

            Console.WriteLine(person2.FirstName);
            //Bellekteki adresler eşitlenmiş oldu, eşitliğin sağ tarafı baz alındığı için bundan dolayı person1'in değeri neyse person2'nin değeri de o olur. Cevap: Arif.

            
            
            Employee employee = new Employee();
            employee.FirstName = "Ali";


            Customer customer = new Customer();
            customer.FirstName = "Salih";
            customer.CustomerNumber =012331;

            //bunu yapabildik çünkü inheritance(miras) aldık
            Person person3 = customer;
            customer.FirstName = "Ahmet";

            Console.WriteLine(((Customer)person3).CustomerNumber);

            PersonManager personManager = new PersonManager();
            personManager.Add(employee);
        }

        class Person
        {
            public int ID { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

        }

        class Employee : Person
        {
            public int EmployeeNumber { get; set; }
        }

        class Customer : Person
        {
            public int CustomerNumber { get; set; }
        }

        class PersonManager
        {
            public void Add(Person person)
            {
                Console.WriteLine(person.FirstName);
                //Yukarıda employee gönderdiğimiz için çıkan cevap employeenin ismi olacaktır.
            }
        }
    }
}
