using Microsoft.AspNetCore.Mvc;
using Vote.Entities;
using Vote.Interfaces;
using Vote.Repositories;

namespace Vote.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CandidateController : ControllerBase
    {
        private ICandidateService _candidateService;

        public CandidateController(ICandidateService candidateService)
        {
            _candidateService = candidateService;
        }

        [HttpGet]
        public async Task<ActionResult<Candidate>> GetCandidate(int id)
        {
            return await _candidateService.GetCandidate(id);
        }

        [HttpPost]
        public async Task<ActionResult<int>> AddCandidate(string name)
        {
            return await _candidateService.AddCandidate(name);
        }
    }
}
