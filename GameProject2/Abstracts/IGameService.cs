using GameProject2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject2.Abstracts
{
    internal interface IGameService
    {
        void AddGame(Game game); 
        void RemoveGame (Game game); 
        void SellingGame (Game game , User user );
        void SellingGame(Game game, Campaign campaign , User user );
        

        
    }
}
