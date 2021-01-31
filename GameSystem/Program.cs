using GameSystemProject.Abstract;
using GameSystemProject.Concrete;
using GameSystemProject.Entities;
using System;

namespace GameSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            IPlayerService playerManager = new PlayerManager(new PlayerValidationManager());
            Player player = new Player
            {
                PlayerID = 1,
                Name = "Berk",
                Surname = "Şenel",
                Nickname = "DeuxBach",
                DateOfBirth = "09.10.1998",
                CitizenshipNumber = "123456789"
            };
            playerManager.Add(player);
            Console.WriteLine("******");
            IGameService gameManager = new GameManager();

            Game game = new Game();
            game.GameID = 1;
            game.Title = "Arma 3";
            game.Price = 100;

            Game game1 = new Game();
            game1.GameID = 2;
            game1.Title = "XCOM 2";
            game1.Price = 120;
            gameManager.Add(game);
            gameManager.Add(game1);
            Console.WriteLine("******");
            gameManager.Sell(game, player);
            Console.WriteLine("******");
            Game[] games = new Game[] { game, game1 };

            IDiscountService discountManager = new DiscountManager();
            Discount discount = new Discount();
            discount.ID = 1;
            discount.Percentage = 20;
            discount.Name = "Winter Sale";
            discountManager.Add(discount);
            Console.WriteLine("******");

            discountManager.Discount(games, discount);
        }
    }
}
