using CleanTournament.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanTournament.Application.Contracts.Persistence
{
    public interface IDiscipline : IAsyncRepository<Discipline>
    {
    }
}
