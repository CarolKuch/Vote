using Microsoft.AspNetCore.Mvc;
using Vote.Entities;

namespace Vote.Interfaces
{
    public interface IVoterRepository
    {
        public Task<ActionResult<Voter>> GetVoter(int id);
        public Task<ActionResult<IEnumerable<Voter>>> GetVoters();
        public Task<ActionResult<int>> AddVoter(Voter voter);
    }
}
