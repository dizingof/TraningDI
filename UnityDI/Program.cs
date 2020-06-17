using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Unity.Lifetime;

namespace UnityDI
{
    class Program
    {
        static void Main(string[] args)
        {
            IUnityContainer container = new UnityContainer();
            container.RegisterType<ILogger, Logger>(new ContainerControlledLifetimeManager());
            var logger = container.Resolve<ILogger>();
            logger.Write("My message");
            Console.ReadKey();
        }
    }
}
