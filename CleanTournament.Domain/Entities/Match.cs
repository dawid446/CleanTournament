using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanTournament.Domain.Entities
{
    public class Match
    {
        public int MatchId { get; set; }
        public string Title { get; set; }
        public string Team { get; set; }
        public string Oponnent { get; set; }
        public string Date { get; set; }
        public int Score { get; set; }
        public int ScoreOpponent { get; set; }
        public string PictureTeam { get; set; }
        public string PictureOpponent { get; set; }
        public int TournamentId { get; set; }
        public Tournament Tournament { get; set; }
    }
}
