using Database.Application.Model;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using User.Application.CQRS.Command;
using User.Application.CQRS.Command.Add;
using User.Application.CQRS.Command.UsersCreate;
using User.Application.CQRS.Query.GetAllUsersTable;
using User.Application.CQRS.Query.GetUsersId;
using User.Application.Model;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestDataBaseController : ControllerBase
    {
        private readonly IMediator mediator;
        public TestDataBaseController(IMediator mediator)
        {
           this.mediator = mediator;
        }
       
        [HttpPost("Add")]
        public async Task<IActionResult> Add([FromBody] AddModel addModel)
        {
            var content = new AddCommand
            {
                AddModel = addModel
            };
            var answer = await mediator.Send(content);
            return Ok(answer);
        }

        [HttpPost("UsersCreateTable")]
        public async Task<IActionResult> UsersCreateTable([FromBody] UsersCreateModel createModel)
        {
            var content = new UsersCreateCommand
            {
                UsersCreateModel = createModel
            };
            var answer = await mediator.Send(content);
            return Ok(answer);
        }

        [HttpGet("GetAllUsersTable")]
        public async Task<IActionResult> GetAllUsersTable()
        {
            var content = new UsersTableCommand
            {
                
            };
            var answer = await mediator.Send(content);
            return Ok(answer);
        }

        [HttpPost("GetUsersId")]
        public async Task<IActionResult> GetUsersId([FromBody] UsersId id)
        {
            var content = new GetUsersIdCommand
            {
                usersId = id
            };
            var answer = await mediator.Send(content);
            return Ok(answer);
        }
    }
}
