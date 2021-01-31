using GameSystemProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSystemProject.Abstract
{
    public interface IPlayerValidation
    {
        bool Validate(Player player);
    }
}
