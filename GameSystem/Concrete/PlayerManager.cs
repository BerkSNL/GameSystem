using GameSystemProject.Abstract;
using GameSystemProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSystemProject.Concrete
{
    public class PlayerManager : IPlayerService
    {
        IPlayerValidation _playerValidation;

        public PlayerManager(IPlayerValidation playerValidation)
        {
            _playerValidation = playerValidation;
        }

        public void Add(Player player)
        {
            if (_playerValidation.Validate(player))
            {
            Console.WriteLine($"{player.Name} {player.Surname} adlı kişi \"{player.Nickname}\" adıyla sisteme eklendi. ");
            }
            else
            {
                Console.WriteLine("Kullanıcı bilgileri hatalı!");
            }
        }

        public void Remove(Player player)
        {
            Console.WriteLine($"\"{player.Nickname}\" adlı kullanıcı sistemden kaldırıldı. ");
        }

        public void Update(Player player)
        {
            Console.WriteLine($"{player.Name} {player.Surname} adlı kişi \"{player.Nickname}\" adıyla sisteme eklendi. ");
        }
    }
}
