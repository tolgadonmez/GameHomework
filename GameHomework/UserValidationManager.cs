using System;
using System.Collections.Generic;
using System.Text;

namespace GameHomework
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 1996 && gamer.FirstName =="TOLGA" && gamer.LastName == "DÖNMEZ" && gamer.IdentityNumber == 12345)
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
