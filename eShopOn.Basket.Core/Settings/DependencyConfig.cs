using Autofac;
using eShopOn.Basket.Behaviors;
using eShopOn.Basket.Core.Behaviors;

namespace eShopOn.Basket.Core.Settings
{
    public class DependencyConfig : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<BasketProvider>().As<IBasketProvider>();
            builder.RegisterType<RedisBasketRepository>().As<IBasketRepository>();
        }
    }
}