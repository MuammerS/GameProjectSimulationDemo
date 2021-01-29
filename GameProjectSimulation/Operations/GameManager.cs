using GameProjectSimulation.Classes;
using GameProjectSimulation.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectSimulation.Operations
{
    class GameManager:IGameServices
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.GameName + "Oyunu" + game.GamePrice + " Fiyarla Sisteme Eklendi.");
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.GameName + "oyunu silindi.");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.GameName + "oyunu güncellendi");
        }
    }
}
