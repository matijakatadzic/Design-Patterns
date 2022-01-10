using ObserverDesignPattern.DataContract.Models;
using System.Collections.Generic;

namespace ObserverDesignPattern.Business.Services
{
    public interface IOrderNotifier
    {
        // Attach an order observer to the subject.
        void Attach(IOrderObserver observer);

        // Detach an order observer from the subject.
        void Detach(IOrderObserver observer);

        // Notify all order observers about an event.
        List<string> Notify(Order order);
    }
}
