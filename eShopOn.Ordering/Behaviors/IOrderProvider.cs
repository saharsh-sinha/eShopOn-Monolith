using eShopOn.Ordering.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eShopOn.Ordering.Behaviors
{
    public interface IOrderProvider
    {
        Task CancelOrderAsync(int orderId, string requestId);

        Task<bool> ShipOrderAsync(int orderNumber, string requestId);

        Task<Order> GetOrderAsync(int orderId);

        Task<IEnumerable<OrderSummary>> GetOrdersAsync();

        Task<IEnumerable<CardType>> GetCardTypesAsync();
    }
}