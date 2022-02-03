using CleanTournament.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanTournament.Domain.Entities
{
    public class Discipline : AuditableEntity 
    {
        public int DisciplineId { get; set; }
        public string Name { get; set; }
        public string DisciplineName { get; set; }
        public ICollection<Tournament> Tournaments { get; set; }
    }
}
