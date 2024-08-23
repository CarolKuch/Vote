using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;
using Vote.Data;
using Vote.Entities;
using Vote.Interfaces;

namespace Vote.Services
{
    public class CandidateService : ICandidateService
    {
        private ICandidateRepository _candidateRepository;

        public CandidateService(ICandidateRepository repository)
        {
            _candidateRepository = repository;
        }
        public async Task<ActionResult<Candidate>> GetCandidate(int id)
        {
            return await _candidateRepository.GetCandidate(id);
        }

        public async Task<ActionResult<int>> AddCandidate(string name)
        {
            Candidate candidate = new Candidate()
            {
                Name = name
            };
            return await _candidateRepository.AddCandidate(candidate);
        }
        public async Task<ActionResult<IEnumerable<Candidate>>> GetCandidates()
        {
            return await _candidateRepository.GetCandidates();
        }
    }
}
