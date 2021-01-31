using GameSystemProject.Abstract;
using GameSystemProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSystemProject.Concrete
{
    class DiscountManager : IDiscountService
    {
        public void Add(Discount discount)
        {
            Console.WriteLine($"{discount.Name} kampanyası sisteme eklendi, ürün başı indirim yüzdesi: %{discount.Percentage}");
        }

        public void Remove(Discount discount)
        {
            Console.WriteLine($"{discount.Name} adlı kampanya sistemden kaldırıldı.");
        }

        public void Update(Discount discount)
        {
            Console.WriteLine($"{discount.Name} adlı kampanya güncellendi.");
        }
        public void Discount(Game[] games, Discount discount)
        {
            foreach (var game in games)
            {
                Console.WriteLine($"{discount.Name} kampanyası {game.Title} oyununa uygulandı yeni fiyatı yüzde {discount.Percentage} daha ucuz!");
            }
        }


    }
}
