using Autofac;
using FikaCoffeeShop.Core.Repositories;
using FikaCoffeeShop.Core.Services;
using FikaCoffeeShop.Core.UnitOfWorks;
using FikaCoffeeShop.Repository;
using FikaCoffeeShop.Repository.Repositories;
using FikaCoffeeShop.Repository.UnitOfWorks;
using FikaCoffeeShop.Service.Mapping;
using FikaCoffeeShop.Service.Services;
using FikaCoffeShop.Caching;
using System.Reflection;
using Module = Autofac.Module;

namespace FikaCoffeeShop.API.Modules
{
    public class RepoServiceModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterGeneric(typeof(GenericRepository<>)).As(typeof(IGenericRepository<>)).InstancePerLifetimeScope();
            builder.RegisterGeneric(typeof(Service<>)).As(typeof(IService<>)).InstancePerLifetimeScope();

            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>();



            var apiAssembly=Assembly.GetExecutingAssembly();

            var repoAssembly = Assembly.GetAssembly(typeof(AppDbContext));

            var serviceAssembly=Assembly.GetAssembly(typeof(MapProfile));


            builder.RegisterAssemblyTypes(apiAssembly, repoAssembly, serviceAssembly).Where(x=>x.Name.EndsWith("Repository")).AsImplementedInterfaces().InstancePerLifetimeScope();

            builder.RegisterAssemblyTypes(apiAssembly, repoAssembly, serviceAssembly).Where(x=>x.Name.EndsWith("Service")).AsImplementedInterfaces().InstancePerLifetimeScope();

            builder.RegisterType<ProductServiceWithCaching>().As<IProductService>();



        }
    }
}
