using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiUnityDI.Classes;
using WebApiUnityDI.Interfaces;

namespace WebApiUnityDI.Controllers
{
    public class ProductsController : ApiController
    {
        private readonly IProductRepository _repository;

        public ProductsController(IProductRepository repository)
        {
            _repository = repository;
        }
        public IEnumerable<Product> Get()
        {
            return _repository.GetAll();
        }

        
    }
}
