using DoAn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoAn.Modules.Icons
{
    public interface IIconServices
    {
        Task<List<Icon>> Get();

        Task<Icon> Get(int id);

        Task<Icon> Create(Icon icon);

        Task Update(Icon iconToUpdate);

        Task<bool> Remove(int id);
    }
}
