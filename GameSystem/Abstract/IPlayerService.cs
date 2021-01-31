using GameSystemProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSystemProject.Abstract
{
    public interface IPlayerService
    {
        void Add(Player player);
        void Update(Player player);
        void Remove(Player player);

    }
}
