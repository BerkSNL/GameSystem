using GameSystemProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSystemProject.Abstract
{
    public interface IDiscountService
    {
        void Add(Discount discount); 
        void Remove(Discount discount); 
        void Update(Discount discount);
        void Discount(Game[] games, Discount discount);
    }
}
