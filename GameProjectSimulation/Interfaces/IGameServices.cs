using GameProjectSimulation.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectSimulation.Interfaces
{
    interface IGameServices
    {
        void Add(Game game);
        void Update(Game game);
        void Delete(Game game);

    }
}
