using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using School.Core.Features.Students.Queries.Models;

namespace School.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        #region fields
        private readonly IMediator mediato;

        #endregion
       #region constructor
        public StudentController(IMediator _mediato)
        {
            mediato = _mediato;
        }
        #endregion 
        [HttpGet("/Student/All")]
        public async Task<IActionResult> GetStudentList()
        {


            var response= await mediato.Send(new GetStudentListQuery());
            return Ok(response);

        }
        [HttpGet("/Student/single")]
        //[HttpGet("{id:int}")]
        public async Task<IActionResult> GetStudentById([FromHeader] int id)
        {


            var response = await mediato.Send(new GetStudentByIDQuery(id));
            return Ok(response);

        }

    }
}
