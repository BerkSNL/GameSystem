using GameSystemProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSystemProject.Entities
{
    public class Player : IEntity
    {
        public int PlayerID { get; set; }
        public string Name { get; set; }
        public string Nickname { get; set; }
        public string Surname { get; set; }
        public string DateOfBirth { get; set; }
        public string CitizenshipNumber { get; set; }
    }
}
