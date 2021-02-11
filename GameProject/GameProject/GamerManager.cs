using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    //MicroService
    class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer)==true)
            {
                Console.WriteLine("Registered");
            }
            else
            {
                Console.WriteLine("Registration Failed");
            }     
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Deleted");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Updated");
        }
    }
}
