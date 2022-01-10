using ObserverDesignPattern.DataContract.Models;
using System.Collections.Generic;

namespace ObserverDesignPattern.Business.Services
{
   public interface IOrderService : IOrderNotifier
   {
        List<string> UpdateOrder(Order order);
   }
}
