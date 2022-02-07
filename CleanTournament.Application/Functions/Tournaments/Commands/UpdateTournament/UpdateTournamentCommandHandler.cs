using AutoMapper;
using CleanTournament.Application.Contracts.Persistence;
using CleanTournament.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanTournament.Application.Functions.Tournaments.Commands.UpdateTournament
{
    public class UpdateTournamentCommandHandler : IRequestHandler<UpdateTournamentCommand>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<Tournament> _tournamentRepository;
        public UpdateTournamentCommandHandler(IMapper mapper, IAsyncRepository<Tournament> tournamentRepository)
        {
            _mapper = mapper;
            _tournamentRepository = tournamentRepository;
        }
        public async Task<Unit> Handle(UpdateTournamentCommand request, CancellationToken cancellationToken)
        {
            var tournament = _mapper.Map<Tournament>(request);

            await _tournamentRepository.UpdateAsync(tournament);
            
            return Unit.Value;
        }
    }
}
