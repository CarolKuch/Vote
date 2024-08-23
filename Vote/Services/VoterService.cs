using Microsoft.AspNetCore.Mvc;
using Vote.Entities;
using Vote.Interfaces;

namespace Vote.Services
{
    public class VoterService : IVoterService
    {
        private IVoterRepository _candidateRepository;

        public VoterService(IVoterRepository repository)
        {
            _candidateRepository = repository;
        }
        public async Task<ActionResult<Voter>> GetVoter(int id)
        {
            return await _candidateRepository.GetVoter(id);
        }

        public async Task<ActionResult<int>> AddVoter(string name)
        {
            Voter candidate = new Voter()
            {
                Name = name
            };
            return await _candidateRepository.AddVoter(candidate);
        }
    }
}
