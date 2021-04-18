using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new NewEStateValidationManager());
            gamerManager.Add(new Gamer 
            { 
                ID = 1,
                BirthYear = 1996, 
                FirstName = "Arif",
                LastName = "Gündoğdu",
                IdentityNumber = 12345 
            });
        }
    }
}
