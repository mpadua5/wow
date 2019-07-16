using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Wow.Domain.Entities;
using Wow.Domain.Interfaces;
using Wow.Infra.Data.Context;

namespace Wow.Infra.Data.Repositories
{
    public class AccoutRepository : IAccountRepository
    {
        
        private readonly TesteWowContext _contexto;

        public AccoutRepository(TesteWowContext contexto)
        {
            _contexto = contexto;
        }
        
        public void Add(Account obj)
        {
            _contexto.Set<Account>().Add(obj);
            _contexto.SaveChanges();
        }

        public IEnumerable<Account> GetAll()
        {
            return _contexto.Set<Account>().ToList();
        }

        public Account GetByGuid(Guid guid)
        {
            return _contexto.Set<Account>().Find(guid);
        }

        public void Remove(Guid guid)
        {
            var account = GetByGuid(guid);

            _contexto.Set<Account>().Remove(account);
            _contexto.SaveChanges();
        }

        public void Update(Account obj)
        {
            _contexto.Entry(obj).State = EntityState.Modified;
            _contexto.SaveChanges();
        }
    }
}