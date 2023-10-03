using MediatR;
using Microsoft.AspNetCore.Mvc;

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
        public async Task<IActionResult> Add()
        {
            var content = new PostAuthorizationCommand
            {
                authorizationModel = authorizationModel
            };
            var answer = await mediator.Send(content);
            return Ok(answer);
        }

        // PUT api/<TestDataBaseController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TestDataBaseController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
