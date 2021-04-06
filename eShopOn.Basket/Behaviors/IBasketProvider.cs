using eShopOn.Basket.Models;
using System.Threading.Tasks;

namespace eShopOn.Basket.Behaviors
{
    public interface IBasketProvider
    {
        Task<CustomerBasket> GetBasketByIdAsync(string id);

        Task<CustomerBasket> UpdateBasketAsync(CustomerBasket value);

        Task CheckoutAsync(BasketCheckout basketCheckout, string requestId);

        Task DeleteBasketByIdAsync(string id);
    }
}