using Business.Abstract;
using Entities.Concrate;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgentsController : ControllerBase
    {
        IAgentService _agentService;

        public AgentsController(IAgentService agentService)
        {
            _agentService = agentService;
        }

        [HttpPost("add")]
        public IActionResult Add(Agent agent)
        {
            _agentService.Add(agent);
            return Ok();
        }

        [HttpPost("delete")]
        public IActionResult Delete(Agent agent)
        {
            _agentService.Delete(agent);
            return Ok();
        }
        [HttpPost("update")]
        public IActionResult Update(Agent agent)
        {
            _agentService.Update(agent);
            return Ok();
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _agentService.GetAll();
            return Ok(result);
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _agentService.GetById(id);
            return Ok(result);
        }
    }
}
