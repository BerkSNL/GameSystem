using GameSystemProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSystemProject.Entities
{
    public class Game : IEntity
    {
        public int GameID { get; set; }
        public string Title { get; set; }
        public int Price { get; set; }
    }
}
