using DoAn.Data;
using DoAn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoAn.Modules.Icons
{
    public class IconServices : IIconServices
    {
        private readonly IRepository<Icon> _iconRepo;
        public IconServices(IRepository<Icon> iconRepo)
        {
            _iconRepo = iconRepo;
        }

        public async Task<Icon> Create(Icon icon)
        {
            return await _iconRepo.Create(icon);
        }

        public async Task<List<Icon>> Get()
        {
            return await _iconRepo.Get();
        }

        public async Task<Icon> Get(int id)
        {
            return await _iconRepo.Get(id);
        }

        public async Task<bool> Remove(int id)
        {
            return await _iconRepo.Remove(id);
        }

        public async Task Update(Icon iconToUpdate)
        {
             await _iconRepo.Update(iconToUpdate);
        }
    }
}
