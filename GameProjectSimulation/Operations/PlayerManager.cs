using GameProjectSimulation.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectSimulation.Operations
{
    class PlayerManager
    {

        public void Add(Player player) //Bir Nevi Kayıt Olmak
        {
            Console.WriteLine("Başarıyla Kayıt Oldunuz:"+player.FirstName + player.LastName);
        }

        public void Delete(Player player)
        {
            Console.WriteLine("Başarıyla hesap silindi:"+player.FirstName + player.LastName);
        }

        public void Update(Player player)
        {
            Console.WriteLine("Başarıyla güncellendi:"+ player.FirstName + player.LastName);
        }




    }
}
