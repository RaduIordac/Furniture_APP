using Application;
using Domain;
using Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace FurnitureWebAPI.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : Controller
    {
        private readonly IProductRepository _productRepository;

        public ProductsController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet(Name = "Get all products")]
        public ActionResult<List<Product>> GetA()
          {
            return Ok(_productRepository.GetAll());
            }


        //public IActionresult index()
        //{
        //    return view();
        //}
    }
}

