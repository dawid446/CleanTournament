using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanTournament.Application.Functions.Tournaments.Queries.GetTournament
{
    public class TournamentViewModel
    {
        public int TournamentId { get; set; }
        public string DisplayNameTournament { get; set; }
        public ICollection<MatchesDTO> MatchesList { get; set; }
    }
}
