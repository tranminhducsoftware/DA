using DoAn.Data;
using DoAn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoAn.Modules.Teams
{
    public class TeamService : ITeamService
    {

        private readonly IRepository<Team> _teamRepo;

        public TeamService(IRepository<Team> teamRepo)
        {
            _teamRepo = teamRepo;
        }

        public async Task<Team> Create(Team team)
        {
            return await _teamRepo.Create(team);
        }

        public async Task<List<Team>> Get()
        {
            return await _teamRepo.Get();
        }

        public async Task<Team> Get(int id)
        {
            return await _teamRepo.Get(id);
        }

        public async Task<bool> Remove(int id)
        {
            return await _teamRepo.Remove(id);
        }

        public async Task Update(Team teamToUpdate)
        {
             await _teamRepo.Update(teamToUpdate);
        }
    }
}
