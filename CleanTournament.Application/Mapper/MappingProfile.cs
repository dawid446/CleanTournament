using AutoMapper;
using CleanTournament.Application.Functions.Tournaments.Commands.CreateTournament;
using CleanTournament.Application.Functions.Tournaments.Commands.UpdateTournament;
using CleanTournament.Application.Functions.Tournaments.Queries.GetTournament;
using CleanTournament.Application.Functions.Tournaments.Queries.GetTournamentList;
using CleanTournament.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanTournament.Application.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Tournament, TournamentsListViewModel>().ReverseMap();
            CreateMap<Tournament, TournamentViewModel>().ReverseMap();
            CreateMap<Discipline, DisciplineDTO>();
            CreateMap<Match, MatchesDTO>();
            CreateMap<Tournament, CreatedTournamentCommand>().ReverseMap();
            CreateMap<Tournament, UpdateTournamentCommand>().ReverseMap();

        }
    }
}
