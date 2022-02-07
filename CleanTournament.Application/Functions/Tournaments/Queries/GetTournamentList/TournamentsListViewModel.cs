using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanTournament.Application.Functions.Tournaments.Queries.GetTournamentList
{
    public class TournamentsListViewModel
    {
        public int TournamentId { get;set; }
        public string Title { get; set; }
        public DateTime Data { get; set; }
        public string Author { get; set; }
        public DisciplineDTO Discipline { get; set; }

    }
}
