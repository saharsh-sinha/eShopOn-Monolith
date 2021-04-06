using Autofac;
using Autofac.Configuration;
using Microsoft.Extensions.Configuration;

namespace eShopOn.Catalog.Settings
{
    public class DependencyConfig : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            var config = new ConfigurationBuilder();
            config.AddJsonFile($"{ThisAssembly.GetName().Name}.Config.Dependency.json");
            var module = new ConfigurationModule(config.Build());
            builder.RegisterModule(module);
        }
    }
}