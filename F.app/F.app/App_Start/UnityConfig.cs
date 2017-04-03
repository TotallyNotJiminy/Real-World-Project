using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc5;
using F.app.Core.Interfaces;
using F.app.Core.Entities;
using MongoDB.Bson;
using F.app.Infrastructure;
using F.app.Controllers;

namespace F.app
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType <IRepo<User, ObjectId>,GenericRepository<User>>();
            container.RegisterType<IRepo<Ingredient, ObjectId>, GenericRepository<Ingredient>>();
            container.RegisterType<AccountController>(new InjectionConstructor());
            //container.RegisterType<RolesAdminController>(new InjectionConstructor());
            container.RegisterType<ManageController>(new InjectionConstructor());
            //container.RegisterType<UsersAdminController>(new InjectionConstructor());

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}