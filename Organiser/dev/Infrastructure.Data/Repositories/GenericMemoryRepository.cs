﻿using Domain.Interfaces;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class GenericMemoryRepository<T> : IGenericRepository<T>
    {
        private readonly IStoreManager _storeManager;
        public GenericMemoryRepository(IStoreManager storeManager)
        {
            _storeManager = storeManager;
        }
        public void Add(T entity)
        {
            _storeManager.Set<T>().Data.Add(entity);
        }

        public void AddRange(IEnumerable<T> entities)
        {
            _storeManager.Set<T>().Data.AddRange(entities);
        }

        public Task CommitAsync()
        {
            return Task.FromResult(false); // we don't need to explicitly save changes
        }

        public Task<T> FindAsync(Func<T, bool> predicate)
        {
            var entity = _storeManager.Set<T>().Data.Where(predicate).FirstOrDefault();
            return Task.FromResult(entity);
        }

        public Task<IEnumerable<T>> GetAsync(Func<T, bool> predicate)
        {
            var entities = _storeManager.Set<T>()?.Data?.Where(predicate);
            return Task.FromResult(entities);
        }

        public void Remove(T entity)
        {
            _storeManager.Set<T>().Data.Remove(entity);
        }

        public void RemoveRange(T entities)
        {

        }
    }
}
