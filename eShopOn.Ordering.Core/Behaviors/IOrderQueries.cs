namespace eShopOn.Ordering.Core.Behaviors
{
    using eShopOn.Ordering.Models;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IOrderQueries
    {
        Task<Order> GetOrderAsync(int id);

        Task<IEnumerable<OrderSummary>> GetOrdersFromUserAsync(Guid userId);

        Task<IEnumerable<CardType>> GetCardTypesAsync();

        Task<bool> ShipOrderAsync(int orderNumber, string requestId);

        Task<Task> CancelOrderAsync(int orderId, string requestId);
    }
}