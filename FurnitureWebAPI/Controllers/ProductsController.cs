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
        private readonly IUnitOfWork _unitOfWork;

        public ProductsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet(Name = "Get all products")]
        public ActionResult<List<Product>> GetA()
          {
            return Ok(_unitOfWork.ProductRepository.GetAll());
            }


        //public IActionresult index()
        //{
        //    return view();
        //}
    }
}

