using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DoAn.Models;

namespace DoAn.Modules.Accounts
{
    public interface IAccountService
    {
        Task<List<Account>> Get();

        Task<Account> Get(int id);

        Task<Account> Create(Account account);

        Task Update(Account accountToUpdate);

        Task<bool> Remove(int id);
    }
}
