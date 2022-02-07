using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanTournament.Application.Functions.Tournaments.Queries.GetTournament
{
    public class GetTournamentQuery : IRequest<TournamentViewModel> 
    {
        public int Id { get; set; }
    }
}
