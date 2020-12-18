using Autofac;
using GMall.Product.Application;
using GMall.Product.Infrastructure.Brands;

namespace GMall.WebApi.Extensions
{
    public class AutofacConfig : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<BrandApplicationService>().AsImplementedInterfaces();
            builder.RegisterType<BrandRepository>().AsImplementedInterfaces(); 
            //builder.RegisterType<BrandRepository>().As<IBrandRepository>().SingleInstance();

        }
    }
}
