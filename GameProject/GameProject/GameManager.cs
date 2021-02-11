using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GameManager : IGameService
    {
        public void AddGame(Game game)
        {
            Console.WriteLine("Game added");
        }

        public void DeleteGame(Game game)
        {
            Console.WriteLine("Game delted");
        }

        public void UpdateGame(Game game)
        {
            Console.WriteLine("Game updated");
        }
    }
}
