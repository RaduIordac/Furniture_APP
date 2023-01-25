using Application;
using Application.Parts.Create;
using Application.Parts.GetAllParts;
using Application.Parts.Delete;
using Application.Parts.Update;
using Application.Parts.GetById;

using Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

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
        public async Task<ActionResult<Part>> GetByID(int id)
        {
            var result = await _mediatr.Send(new GetPartsByIdQuery { Id = id });

            if (result == null)
            {
                return NotFound("Part does not exist or was deleted");
            }

            return Json(result);
        }

        [HttpPut("{id}", Name = "Update Part")]
        public async Task<ActionResult> Update(int id, UpdatePartCommand command)
        {
            command.Id = id;
            return Json(await _mediatr.Send(command));
        }

        [HttpDelete("{id}", Name = "Delete Part")]

        public async Task<ActionResult> Delete(int id, DeletePartCommand command)
        {
            command.Id = id;
            return Json(await _mediatr.Send(command));



            //public IActionresult index()
            //{
            //    return view();
            //}
        }
    }
}

