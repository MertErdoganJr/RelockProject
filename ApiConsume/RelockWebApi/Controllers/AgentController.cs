using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RelockProject.BusinessLayer.Abstract;
using RelockProject.EntityLayer.Concrete;
using System.Security.AccessControl;

namespace RelockWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgentController : ControllerBase
    {
        private readonly IAgentService _agentService;

        public AgentController(IAgentService agentService)
        {
            _agentService = agentService;
        }

        [HttpGet]
        public IActionResult AgentList()
        {
            var values = _agentService.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddAgent(Agent agent)
        {
            _agentService.TInsert(agent);
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteAgent(int id)
        {
            var values = _agentService.TGetById(id);
            _agentService.TDelete(values);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateAgent(Agent agent)
        {
            _agentService.TUpdate(agent);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetAgent(int id)
        {
            var values = _agentService.TGetById(id);
            return Ok(values);
        }
    }
}
