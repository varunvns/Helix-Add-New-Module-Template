using Glass.Mapper.Sc;
using Sitecore.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using _NamespacePrefix_._ModuleType_._Name_.Repositories;
using Starkey.Pro.Foundation.DependencyInjection;
namespace _NamespacePrefix_._ModuleType_._Name_.Services
{
    public class RegisterDependencies: IServicesConfigurator
    {
        public void Configure(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<I_Name_Repository, _Name_Repository>();
        }
    }
}