using System;
using ObserverDesignPattern.DataContract.Models;

namespace ObserverDesignPattern.Business.Services
{
    public class SmsObserver : IOrderObserver
    {
        public string Update(Order order)
        {
            return $"Order No '{order.OrderNumber}' status is updated to '{order.OrderStatus.ToString()}'. SMS message sent to customer.";
        }
    }
}
