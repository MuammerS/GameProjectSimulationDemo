using GameProjectSimulation.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectSimulation
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Player player)
        {
            if ( player.FirstName == "Muammer" && player.LastName == "Sönmez" && player.Id == 1)
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