using CleanTournament.Application.Contracts.Persistence;
using MediatR;
using CleanTournament.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace CleanTournament.Application.Functions.Tournaments.Queries
{
    public class GetTournamentsListQueryHandler : IRequestHandler<GetTournamentsListQuery, List<TournamentViewModel>>
    {
        private readonly IAsyncRepository<Tournament> _tournamentRepository;
        private readonly IAsyncRepository<Discipline> _disciplineRepository;
        private readonly IMapper _mapper;

        public GetTournamentsListQueryHandler(IMapper mapper, IAsyncRepository<Tournament> tournamentRepository, IAsyncRepository<Discipline> disciplineRepository)
        {
            _tournamentRepository = tournamentRepository;
            _disciplineRepository = disciplineRepository;
            _mapper = mapper;
        }
        public async Task<List<TournamentViewModel>> Handle(GetTournamentsListQuery request, CancellationToken cancellationToken)
        {
            var all = await _tournamentRepository.GetAllAsync();
            var allOrdered = all.OrderBy(x => x.StartDate);

            return _mapper.Map<List<TournamentViewModel>>(allOrdered);
            
        }
    }
}
