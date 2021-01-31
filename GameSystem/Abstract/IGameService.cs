using GameSystemProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSystemProject.Abstract
{
    public interface IGameService
    {
        void Add(Game game);
        void Sell(Game game,Player player);
        void Remove(Game game);
        void Update(Game game);
    }
}
