using Microsoft.AspNetCore.Mvc;
using Vote.Entities;
using Vote.Interfaces;

namespace Vote.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VoterController : ControllerBase
    {
        private IVoterService _candidateService;

        public VoterController(IVoterService candidateService)
        {
            _candidateService = candidateService;
        }

        [HttpGet]
        public async Task<ActionResult<Voter>> GetVoter(int id)
        {
            return await _candidateService.GetVoter(id);
        }

        [HttpPost]
        public async Task<ActionResult<int>> AddVoter(string name)
        {
            return await _candidateService.AddVoter(name);
        }
    }
}
