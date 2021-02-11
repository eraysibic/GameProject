using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GameOwnerManager : IGameOwnerService
    {
        public void Owner(Game game)
        {
            Console.WriteLine("Satın alım başarılı");
        }
    }
}
