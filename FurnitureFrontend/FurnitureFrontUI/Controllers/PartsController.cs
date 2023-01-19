using Application;
using Application.Parts.Create;
using Application.Parts.GetAllParts;
using Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace FurnitureWebAPI.Controllers
{

    [Route("api/parts")]
    [ApiController]
    public class PartsController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMediator _mediatr;

        public PartsController(IUnitOfWork unitOfWork, IMediator mediatr)
        {
            _unitOfWork = unitOfWork;
            _mediatr = mediatr;
        }

        [HttpGet(Name = "Get all available parts")]
        public async Task<ActionResult<List<Part>>> GetAllAsync()
          {
            var result = await _mediatr.Send(new GetAllPartsQuery());
            return Ok(result);
            }

                
        [HttpPost(Name = "Create new part")]
        public async Task<ActionResult> Create(CreatePartCommand command)
          {
           var result = await _mediatr.Send(command);
            return Ok(result);
    }
        //[Route("{id}")]
        [HttpGet("{id}", Name = "Get Part by Id")]
        public ActionResult<Part> GetByID(int id)
        {
            var result = _unitOfWork.PartRepository.GetPart(id);

            if (result == null)
            {
                return NotFound("Part does not exist or was deleted");
            }

            return Json(result);
        }
        


        //public IActionresult index()
        //{
        //    return view();
        //}
    }
}

