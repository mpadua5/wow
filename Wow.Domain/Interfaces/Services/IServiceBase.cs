using System;
using System.Collections.Generic;

namespace Wow.Domain.Interfaces.Services
{
    public interface IServiceBase<T> where T : class
    {
        void Add(T obj);
        T GetByGuid(Guid guid);
        IEnumerable<T> GetAll();
        void Update(T obj);
        void Remove(Guid guid);
        void Dispose();
    }
}