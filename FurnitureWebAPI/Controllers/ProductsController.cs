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
        //[Route("{id}")]
        [HttpGet("{id}", Name = "Get Product By Id")]
        public ActionResult<Product> GetByID(int id)
        {
            var result = _unitOfWork.ProductRepository.GetById(id);

            if (result == null)
            {
                return NotFound("Product does not exist or was deleted");
            }

            return Json(result);
        }
        //[Route("{name}")]
        [HttpGet("/{name}", Name = "Get Product By Name")]
        public ActionResult<Product> GetByName( string name)
        {
            var result = _unitOfWork.ProductRepository.GetByName(name);
            return Json(result);
        }


        //public IActionresult index()
        //{
        //    return view();
        //}
    }
}

