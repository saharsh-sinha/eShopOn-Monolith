using eShopOn.Basket.Behaviors;
using eShopOn.Basket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopOn.Basket.Core.Behaviors
{
    internal class BasketProvider : IBasketProvider
    {
        private readonly IBasketRepository _repository;

        public BasketProvider(
            IBasketRepository repository)
        {
            _repository = repository;
        }

        public async Task CheckoutAsync(BasketCheckout basketCheckout, string requestId) =>
            await _repository.CheckoutAsync(basketCheckout, requestId);

        public async Task DeleteBasketByIdAsync(string id) =>
            await _repository.DeleteBasketAsync(id);

        public async Task<CustomerBasket> GetBasketByIdAsync(string id) =>
            await _repository.GetBasketAsync(id);

        public async Task<CustomerBasket> UpdateBasketAsync(CustomerBasket basket) =>
            await _repository.UpdateBasketAsync(basket);
    }
}