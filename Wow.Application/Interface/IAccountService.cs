using System;
using System.Collections.Generic;
using Wow.Domain.Entities;

namespace Wow.Application.Interface
{
    public interface IAccountService
    {
        void Add(Account obj);
        Account GetByGuid(Guid guid);
        IEnumerable<Account> GetAll();
        void Update(Account obj);
        void Remove(Guid guid);
        void Dispose();
    }
}