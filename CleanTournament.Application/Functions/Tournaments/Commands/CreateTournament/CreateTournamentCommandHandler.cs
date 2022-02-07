using AutoMapper;
using CleanTournament.Application.Contracts.Persistence;
using CleanTournament.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanTournament.Application.Functions.Tournaments.Commands.CreateTournament
{
    public class CreateTournamentCommandHandler : IRequestHandler<CreatedTournamentCommand, int>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<Tournament> _tournamentRepository;
        public CreateTournamentCommandHandler(IMapper mapper, IAsyncRepository<Tournament> tournamentRepository)
        {
            _mapper = mapper;
            _tournamentRepository = tournamentRepository;
        }
        public async Task<int> Handle(CreatedTournamentCommand request, CancellationToken cancellationToken)
        {
            var tournamnet = _mapper.Map<Tournament>(request);

            tournamnet = await _tournamentRepository.AddAsync(tournamnet);

            return tournamnet.TournamentId;
        }
    }
}
