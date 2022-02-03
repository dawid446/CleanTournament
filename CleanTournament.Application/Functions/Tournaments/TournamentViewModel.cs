using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanTournament.Application.Functions.Tournaments
{
    public class TournamentViewModel
    {
        public int TournamentId { get;set; }
        public string Title { get; set; }
        public DateTime Data { get; set; }
        public string Author { get; set; }
        public string ImageDiscipline { get; set; }
    }
}
