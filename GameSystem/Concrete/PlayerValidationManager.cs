using GameSystemProject.Abstract;
using GameSystemProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSystemProject.Concrete
{
    public class PlayerValidationManager : IPlayerValidation
    {
        public bool Validate(Player player)
        {
            if (player.Name == "Berk" && player.Surname == "Şenel" && player.Nickname == "DeuxBach" && player.DateOfBirth == "09.10.1998"  && player.CitizenshipNumber == "123456789")
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
