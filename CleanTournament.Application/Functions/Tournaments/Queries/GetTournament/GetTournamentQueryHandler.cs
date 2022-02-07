using AutoMapper;
using CleanTournament.Application.Contracts.Persistence;
using CleanTournament.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanTournament.Application.Functions.Tournaments.Queries.GetTournament
{
    public class GetTournamentQueryHandler : IRequestHandler<GetTournamentQuery, TournamentViewModel>
    {
        private readonly IAsyncRepository<Tournament> _tournamentRepository;
        private readonly IAsyncRepository<Match> _matchRepository;
        private readonly IMapper _mapper;
        public GetTournamentQueryHandler(IMapper mapper, IAsyncRepository<Tournament> tournamentRepository, IAsyncRepository<Match> matchRepository)
        {
            _tournamentRepository = tournamentRepository;
            _matchRepository = matchRepository;
            _mapper = mapper;
        }
        public async Task<TournamentViewModel> Handle(GetTournamentQuery request, CancellationToken cancellationToken)
        {
            var tournament = await _tournamentRepository.GetByIdAsync(request.Id);
            var tournamentVm = _mapper.Map<TournamentViewModel>(tournament);

            return tournamentVm;

        }
    }
}
