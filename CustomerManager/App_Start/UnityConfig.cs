using CustomerManager.Controllers;
using System.Web.Mvc;
using Unity;
using Unity.Injection;
using Unity.Mvc5;

namespace CustomerManager
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}