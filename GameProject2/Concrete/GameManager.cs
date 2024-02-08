using GameProject2.Abstracts;
using GameProject2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject2.Concrete
{
    internal class GameManager : IGameService
    {   
         List<Game> games = new List<Game>();
       
        public void AddGame(Game game)
        {
           games.Add(game);
           Console.WriteLine("Game have been added"+ game.GameName);
        }

        public void RemoveGame(Game game)
        {
           if (games.Contains(game))
            {
                games.Remove(game);
                Console.WriteLine("Game have been removed");
            } 
           else
            {
                throw new Exception("Games do not exist"); 

            }
        }


        public void SellingGame(Game game , User user )
        {  
            Console.WriteLine("this game" + game.GameName    + "have selled to this person " +  user.Name + user.Surname + "the price is : "  + game.Price);
        } 



        public void SellingGame(Game game, Campaign campaign, User user)
        {
            double afterCampaign = game.Price - game.Price / campaign.DiscountPercent;  
            Console.WriteLine("this game" + game.GameName + "have selled to this person " + user.Name + user.Surname + "the price is : " + game.Price + "and after the discount" + afterCampaign);
        }
    }
}
