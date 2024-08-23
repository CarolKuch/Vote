using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Vote.Data;
using Vote.Entities;
using Vote.Interfaces;

namespace Vote.Repositories
{
    public class VoterRepository: IVoterRepository
    {
        private DataContext _context;

        public VoterRepository(DataContext context)
        {
            _context = context;
        }
        public async Task<ActionResult<Voter>> GetVoter(int id)
        {
            return await _context.Voters.Where(x => x.Id == id).SingleAsync();
        }

        public async Task<ActionResult<IEnumerable<Voter>>> GetVoters()
        {
            return await _context.Voters.ToListAsync();
        }

        public async Task<ActionResult<int>> AddVoter(Voter voter)
        {
            _context.Voters.Add(voter);
            var response = await _context.SaveChangesAsync();
            return response;
        }

    }
}
