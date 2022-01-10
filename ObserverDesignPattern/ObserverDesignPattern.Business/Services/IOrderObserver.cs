using ObserverDesignPattern.DataContract.Models;

namespace ObserverDesignPattern.Business.Services
{
    public interface IOrderObserver
    {
        string Update(Order order);
    }
}
