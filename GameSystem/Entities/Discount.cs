using GameSystemProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSystemProject.Entities
{
    public class Discount :IEntity
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Percentage { get; set; }
    }
}
