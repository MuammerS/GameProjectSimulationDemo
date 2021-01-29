using GameProjectSimulation.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectSimulation
{
    interface IUserValidationService
    {
        bool Validate(Player player);
    }
}