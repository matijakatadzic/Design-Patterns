using ObserverDesignPattern.DataContract.Models;
using System;

namespace ObserverDesignPattern.Business.Services
{
    public class EmailObserver : IOrderObserver
    {
        public string Update(Order order)
        {
            return $"Order No '{order.OrderNumber}' status is updated to '{order.OrderStatus.ToString()}'. An email sent to customer.";
        }
    }
}
