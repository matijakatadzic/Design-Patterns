using DecoratorDesignPattern.DataContract.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DecoratorDesignPattern.Business.Services
{
    public interface IPlayersService
    {
        IEnumerable<Player> GetPlayersList(); 
    }
}
