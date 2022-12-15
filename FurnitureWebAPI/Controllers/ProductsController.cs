using Application;
using Application.Products.Create;
using Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace FurnitureWebAPI.Controllers
{
    
    [Route("api/products")]
    [ApiController]
    public class ProductsController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMediator _mediatr;

        public ProductsController(IUnitOfWork unitOfWork, IMediator mediatr)
        {
            _unitOfWork = unitOfWork;
            _mediatr = mediatr;
        }

        [HttpGet(Name = "Get all products")]
        public ActionResult<List<Product>> GetAll()
          {
            return Ok(_unitOfWork.ProductRepository.GetAll());
            }

        [HttpPost(Name = "Create Product")]
        public async Task<ActionResult> Create(CreateProductCommand command)
          {
           var result =await _mediatr.Send(command);
            return Ok(result);
    }

        [HttpGet("{id}", Name = "Get Product By Id")]
        public async Task<ActionResult> GetById(int id)
        {
           //var result = await _mediatr.Send(command);
            return NoContent();
        }


        //public IActionresult index()
        //{
        //    return view();
        //}
    }
}

