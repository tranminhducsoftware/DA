using DoAn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoAn.Modules.Teams
{
    public interface ITeamService
    {
        Task<List<Team>> Get();

        Task<Team> Get(int id);

        Task<Team> Create(Team team);

        Task Update(Team teamToUpdate);

        Task<bool> Remove(int id);
    }
}
