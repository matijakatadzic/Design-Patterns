using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StrategyDesignPattern.Business.Services
{
    public interface IShippingStrategy
    {
        decimal CalculateFinalTotal(decimal orderTotal);
    }
}
