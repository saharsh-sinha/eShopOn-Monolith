using eShopOn.Ordering.Behaviors;
using eShopOn.Ordering.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopOn.Ordering.Core.Behaviors
{
    internal class OrderProvider : IOrderProvider
    {
        private readonly IOrderQueries _orderQueries;

        public OrderProvider(IOrderQueries orderQueries)
        {
            _orderQueries = orderQueries;
        }

        public async Task CancelOrderAsync(int orderId, string requestId) =>
            await _orderQueries.CancelOrderAsync(orderId, requestId);

        public Task<IEnumerable<CardType>> GetCardTypesAsync() =>
            _orderQueries.GetCardTypesAsync();

        public Task<Order> GetOrderAsync(int orderId) =>
            _orderQueries.GetOrderAsync(orderId);

        public Task<IEnumerable<OrderSummary>> GetOrdersAsync() =>
            _orderQueries.GetOrdersFromUserAsync(Guid.NewGuid());

        public async Task<bool> ShipOrderAsync(int orderNumber, string requestId) =>
            await _orderQueries.ShipOrderAsync(orderNumber, requestId);
    }
}