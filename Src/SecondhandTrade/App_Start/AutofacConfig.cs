using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using Secondhand.BusinessLogic.Items;
using Secondhand.BusinessLogic.Users;
using Secondhand.Domain.Model;
using Secondhand.Domain.Services;

namespace SecondhandTrade
{
    public class AutofacConfig
    {
        public static void Configure()
        {
            var builder = new ContainerBuilder();

            // Register your MVC controllers. (MvcApplication is the name of
            // the class in Global.asax.)
            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            //Items
            builder.RegisterType<ItemService>().As<IItemService>();
            builder.RegisterType<ItemRepository>().As<IItemRepository>();

            //Users
            builder.RegisterType<UserService>().As<IUserService>();
            builder.RegisterType<UserRepository>().As<IUserRepository>();
            builder.RegisterType<SecondhandModelContainer>().As<ISecondhandContext>().InstancePerRequest();

            // Set the dependency resolver to be Autofac.
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}