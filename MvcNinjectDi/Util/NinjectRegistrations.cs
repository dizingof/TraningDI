using MvcNinjectDi.Entities;
using MvcNinjectDi.Interfaces;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcNinjectDi.Util
{
    public class NinjectRegistrations : NinjectModule
    {
        public override void Load()
        {
            Bind<IRepository>().To<BookRepository>();
        }
    }
}