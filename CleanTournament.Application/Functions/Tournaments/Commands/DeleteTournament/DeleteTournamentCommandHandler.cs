using AutoMapper;
using CleanTournament.Application.Contracts.Persistence;
using CleanTournament.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanTournament.Application.Functions.Tournaments.Commands.DeleteTournament
{
    public class DeleteTournamentCommandHandler : IRequestHandler<DeleteTournamentCommand>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<Tournament> _tournamentRepository;
        public DeleteTournamentCommandHandler(IMapper mapper, IAsyncRepository<Tournament> tournamentRepository)
        {
            _mapper = mapper;
            _tournamentRepository = tournamentRepository;
        }
        public async Task<Unit> Handle(DeleteTournamentCommand request, CancellationToken cancellationToken)
        {

           var tournamentDelete = await _tournamentRepository.GetByIdAsync(request.TournamentId);

            await _tournamentRepository.DeleteAsync(tournamentDelete.TournamentId);

            return Unit.Value;

        }
    }
}
