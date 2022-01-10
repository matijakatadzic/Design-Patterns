using System.Collections.Generic;
using ObserverDesignPattern.DataContract.Models;

namespace ObserverDesignPattern.Business.Services
{
    public class OrderService : IOrderService 
    { 
        public List<IOrderObserver> Observers = new List<IOrderObserver>();

        public List<string> UpdateOrder(Order order)
        {
            return Notify(order);
        }

        public void Attach(IOrderObserver observer)
        {
            Observers.Add(observer);
        }

        public void Detach(IOrderObserver observer)
        {
            Observers.Remove(observer);
        }

        public List<string> Notify(Order order)
        {
            var list = new List<string>();
            foreach (var observer in Observers)
            {
                list.Add( observer.Update(order));
            }

            return list;
        }
    }
}
