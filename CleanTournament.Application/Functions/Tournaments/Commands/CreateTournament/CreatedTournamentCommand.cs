using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanTournament.Application.Functions.Tournaments.Commands.CreateTournament;

public class CreatedTournamentCommand : IRequest<int>
{
    public int TournamentId { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public DateTime StartDate { get; set; }
    public string Address { get; set; }
    public string Description { get; set; }
    public int NumberOfPeople { get; set; }
    public int DisciplineId { get; set; }
    public string ImageUrl { get; set; }
    public string Url { get; set; }

}

