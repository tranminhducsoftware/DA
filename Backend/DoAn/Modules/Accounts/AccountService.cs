using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DoAn.Data;
using DoAn.Models;

namespace DoAn.Modules.Accounts
{
    public class AccountService : IAccountService
    {
        private readonly IRepository<Account> _accountRepo;

        public AccountService(IRepository<Account> accountRepo )
        {
            _accountRepo = accountRepo;
        }

        public async Task<Account> Create(Account account)
        {
            return await _accountRepo.Create(account);
        }

        public async Task<bool> Remove(int id)
        {
            return await _accountRepo.Remove(id);
        }

        public async Task<List<Account>> Get()
        {
            return await _accountRepo.Get();
        }

        public async Task<Account> Get(int id)
        {
            return await _accountRepo.Get(id);
        }

        public async Task Update(Account account)
        {
             await _accountRepo.Update(account);
        }
    }
}
