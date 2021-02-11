using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 2001 && gamer.FirstName == "ERAY" && gamer.LastName == "SİBİÇ" && gamer.IdentitiyNumber == 12356)
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
