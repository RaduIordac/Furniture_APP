using Application.Parts.Create;
using Application;
using Domain;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Application.Categories.Create;

namespace FurnitureWebAPI.Controllers
{
    [Route("api/categories")]
    [ApiController]
    public class CategoriesController : Controller
        {
            private readonly IUnitOfWork _unitOfWork;
            private readonly IMediator _mediatr;

            public CategoriesController(IUnitOfWork unitOfWork, IMediator mediatr)
            {
                _unitOfWork = unitOfWork;
                _mediatr = mediatr;
            }

            [HttpGet(Name = "Get all categories parts")]
            public ActionResult<List<Category>> GetAllCategories()
        {
                return Ok(_unitOfWork.CategoryRepository.GetAllCategories());
            }

            [HttpPost(Name = "Create new category")]
            public async Task<ActionResult> Create(CreateCategoryCommand command)
            {
                var result = await _mediatr.Send(command);
                return Ok(result);
            }
            //[Route("{id}")]
            [HttpGet("{id}", Name = "Get Category by Id")]
            public ActionResult<Category> GetByID(int id)
            {
                var result = _unitOfWork.CategoryRepository.GetById(id);

                if (result == null)
                {
                    return NotFound("Category does not exist or was deleted");
                }

                return Json(result);
            }



            //public IActionresult index()
            //{
            //    return view();
            //}
        }
    }
