using Microsoft.AspNetCore.Mvc;
using Vote.Entities;
using Vote.Interfaces;

namespace Vote.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VoterController : ControllerBase
    {
        private IVoterService _voterService;

        public VoterController(IVoterService voterService)
        {
            _voterService = voterService;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Voter>> GetVoter(int id)
        {
            return await _voterService.GetVoter(id);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Voter>>> GetVoters()
        {
            return await _voterService.GetVoters();
        }

        [HttpPost]
        public async Task<ActionResult<int>> AddVoter(string name)
        {
            return await _voterService.AddVoter(name);
        }
    }
}
