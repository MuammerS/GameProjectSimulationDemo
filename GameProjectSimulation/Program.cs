using GameProjectSimulation.Classes;
using GameProjectSimulation.Operations;
using System;

namespace GameProjectSimulation
{
    class Program
    {
        static void Main(string[] args)
        {

            //---------------Kullanıcı olayları-----------------//
            Player player1 = new Player();
            player1.FirstName = "Muammer";
            player1.LastName = "Sönmez";
            player1.Id = 1;

            PlayerManager playerManager = new PlayerManager();
            playerManager.Add(player1);
            playerManager.Delete(player1);
            playerManager.Update(player1);

            //------------------OYUN-----------------//

            Game game1 = new Game();
            game1.GameId = 333;
            game1.GameName = "Pen Battle";
            game1.GamePrice = 49.90;


            GameManager gameManager = new GameManager();
            gameManager.Add(game1);
            gameManager.Delete(game1);
            gameManager.Update(game1);

            //----------------Kampanya------------------//

            Campaign campaign1 = new Campaign();
            campaign1.CampaignId = 123;
            campaign1.CampaignName = "2 Al 1 Öde";
            campaign1.CampaignDiscount = 19.99;

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);
            campaignManager.Delete(campaign1);
            campaignManager.Update(campaign1);
        }
    }
}
