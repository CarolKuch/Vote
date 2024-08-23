using Microsoft.AspNetCore.Mvc;
using Vote.Entities;
using Vote.Repositories;

namespace Vote.Interfaces
{
    public interface ICandidateService
    {
        public Task<ActionResult<Candidate>> GetCandidate(int id);
        public Task<ActionResult<int>> AddCandidate(string name);

    }
}
