using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    class UserValidationManager : IUserValidationService
    {
        //doğru ya da yanlış sonucu olacağı için void yerine "bool" yapmak daha doğru 
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 1996 && gamer.FirstName == "Arif" && gamer.LastName == "Gündoğdu" &&  gamer.IdentityNumber ==12345)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
