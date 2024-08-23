using Microsoft.AspNetCore.Mvc;
using Vote.Entities;
using Vote.Interfaces;

namespace Vote.Services
{
    public class VoterService : IVoterService
    {
        private IVoterRepository _voterRepository;

        public VoterService(IVoterRepository repository)
        {
            _voterRepository = repository;
        }

        public async Task<ActionResult<Voter>> GetVoter(int id)
        {
            return await _voterRepository.GetVoter(id);
        }

        public async Task<ActionResult<IEnumerable<Voter>>> GetVoters()
        {
            return await _voterRepository.GetVoters();
        }

        public async Task<ActionResult<int>> AddVoter(string name)
        {
            Voter candidate = new Voter()
            {
                Name = name
            };
            return await _voterRepository.AddVoter(candidate);
        }
    }
}
