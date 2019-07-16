using System;
using System.Collections.Generic;
using Wow.Domain.Entities;

namespace Wow.Domain.Interfaces
{
    public interface IAccountRepository
    {
        void Add(Account obj);
        IEnumerable<Account> GetAll();
        Account GetByGuid(Guid guid);
        void Remove(Guid guid);
        void Update(Account obj);
    }
}