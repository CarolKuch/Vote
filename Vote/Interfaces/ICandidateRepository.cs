using Microsoft.AspNetCore.Mvc;
using Vote.Entities;

namespace Vote.Interfaces
{
    public interface ICandidateRepository
    {
        public Task<ActionResult<Candidate>> GetCandidate(int id);
        public Task<ActionResult<int>> AddCandidate(Candidate candidate);

    }
}
