using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApiUnityDI.Classes
{
    public class ProductsContext : DbContext
    {
        public ProductsContext()
            : base("name=WebApiUnityDI.Properties.Settings.Setting")
        {
        }
        public DbSet<Product> Products { get; set; }
    }
}