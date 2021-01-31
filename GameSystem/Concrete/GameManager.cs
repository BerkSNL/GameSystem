using GameSystemProject.Abstract;
using GameSystemProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSystemProject.Concrete
{
    public class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.Title + " adlı oyun sisteme eklendi. " + game.Price + "$ fiyatından satışa sunuldu.");
        }

        public void Remove(Game game)
        {
            Console.WriteLine(game.Title + " adlı oyun sistemden kaldırıldı.");
        }

        public void Sell(Game game,Player player)
        {
            Console.WriteLine(game.Title + " adlı oyun " + player.Nickname + " adlı oyuncuya satıldı.");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.Title + " adlı oyun güncellendi.");
        }
    }
}
