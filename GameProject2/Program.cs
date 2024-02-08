using GameProject2.Abstracts;
using GameProject2.Concrete;
using GameProject2.Entities;

namespace GameProject2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GameManager gameManager = new GameManager();
            Game game1 = new Game
            {
                GameName = "fifa23",
                Price = 50           };
            Game game2 = new Game
            {
                GameName = "pes2021",
                Price = 45
            }; 
            gameManager.AddGame(game1); 
            gameManager.AddGame(game2);
            User user1 = new User
            {
                DateOfBirth = new DateTime(2003, 2, 1),
                Name = "Emre",
                Surname = "Can",
                NationalityId = 123,

            };
            User user2 = new User
            {
                DateOfBirth = new DateTime(2004, 6, 3),
                Name = "Enes",
                Surname = "Öztürk",
                NationalityId = 456,

            }; 
            UserManager userManager = new UserManager();
            userManager.SignIn(user1, new UserCheckManager());
            Campaign campaign1 = new Campaign()
            {
                CampaignName = "Steam Kış indirimi",
                DiscountPercent = 5,
            };
            gameManager.SellingGame(game2, campaign1, user2);

        }
    }
}