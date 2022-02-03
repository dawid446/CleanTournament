using AutoMapper;
using CleanTournament.Application.Functions.Tournaments;
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
            CreateMap<Tournament, TournamentViewModel>().ReverseMap();
        }
    }
}
