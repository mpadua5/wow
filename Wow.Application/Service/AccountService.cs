using System;
using System.Collections.Generic;
using Wow.Application.Interface;
using Wow.Domain.Entities;
using Wow.Domain.Interfaces;

namespace Wow.Application.Service
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountService;
        public AccountService(IAccountRepository accountService)
        {
            _accountService = accountService;
        }

        public void Add(Account obj)
        {
            obj.Guid = new Guid();
            _accountService.Add(obj);
        }

        public Account GetByGuid(Guid guid)
        {
            return _accountService.GetByGuid(guid);
        }

        public IEnumerable<Account> GetAll()
        {
            return _accountService.GetAll();
        }

        public void Update(Account obj)
        {
            _accountService.Update(obj);
        }

        public void Remove(Guid guid)
        {
            _accountService.Remove(guid);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}