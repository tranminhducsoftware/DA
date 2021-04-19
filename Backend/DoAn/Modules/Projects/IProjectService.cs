using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DoAn.Models;

namespace DoAn.Modules.Projects
{
    public interface IProjectService
    {
        Task<List<Project>> Get();

        Task<Project> Get(int id);

        Task<Project> Create(Project account);

        Task Update(Project accountToUpdate);

        Task<bool> Remove(int id);
    }
}
