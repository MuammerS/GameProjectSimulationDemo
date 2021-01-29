using GameProjectSimulation.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectSimulation.Interfaces
{
    interface ICampaignServices
    {
        void Add(Campaign campaign);
        void Update(Campaign campaign);
        void Delete(Campaign campaign);
    }
}
