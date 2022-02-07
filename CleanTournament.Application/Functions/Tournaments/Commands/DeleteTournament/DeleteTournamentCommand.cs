using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanTournament.Application.Functions.Tournaments.Commands.DeleteTournament
{
    public class DeleteTournamentCommand : IRequest
    {
        public int TournamentId { get; set; }
    }
}
