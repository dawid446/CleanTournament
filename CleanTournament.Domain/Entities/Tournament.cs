using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanTournament.Domain.Entities
{
    public class Tournament
    {
        public int TournamentId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime StartDate { get; set; }
        public string Description { get; set; }
        public int NumberOfPeople { get; set; }
        public int DisciplineId { get; set; }
        public Discipline Discipline {get;set;}
        public ICollection <Match> Matches { get; set; }
        public string ImageUrl { get; set; }
        public string Url { get; set; }
        public int Rate { get; set; }
        public bool AlreadyHappend { get; set; }
    }
}
