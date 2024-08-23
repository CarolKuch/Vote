using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Vote.Data;
using Vote.Entities;
using Vote.Interfaces;

namespace Vote.Repositories
{
    public class CandidateRepository : ICandidateRepository
    {
        private DataContext _context;

        public CandidateRepository(DataContext context)
        {
            _context = context;
        }
        public async Task<ActionResult<Candidate>> GetCandidate(int id)
        {
            return await _context.Candidates.Where(x => x.Id == id).SingleAsync();
        }

        public async Task<ActionResult<int>> AddCandidate(Candidate candidate)
        {
            _context.Candidates.Add(candidate);
            var response = await _context.SaveChangesAsync();
            return response;
        }
    }
}
