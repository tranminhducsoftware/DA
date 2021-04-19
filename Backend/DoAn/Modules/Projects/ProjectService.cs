using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DoAn.Data;
using DoAn.Models;

namespace DoAn.Modules.Projects
{
    public class ProjectService : IProjectService
    {
        private readonly IRepository<Project> _projectRepo;

        public ProjectService(IRepository<Project> projectRepo)
        {
            _projectRepo = projectRepo;
        }
        public async Task<Project> Create(Project project)
        {
            return await _projectRepo.Create(project);
        }

        public async Task<bool> Remove(int id)
        {
            return await _projectRepo.Remove(id);
        }

        public async Task<List<Project>> Get()
        {
            return await _projectRepo.Get();
        }

        public async Task<Project> Get(int id)
        {
            return await _projectRepo.Get(id);
        }

        public async Task Update(Project project)
        {
            await _projectRepo.Update(project);
        }
    }
}
