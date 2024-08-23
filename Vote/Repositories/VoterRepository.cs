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

        public async Task<ActionResult<int>> AddVoter(Voter candidate)
        {
            _context.Voters.Add(candidate);
            var response = await _context.SaveChangesAsync();
            return response;
        }

    }
}
