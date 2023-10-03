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
        // GET: api/<TestDataBaseController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<TestDataBaseController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<TestDataBaseController>
        [HttpPost]
        public void Post(string Table, string entity, string Fields, string VALUES)
        {
            
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
