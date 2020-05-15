using Organiser.Domain.Interfaces.Stores;
using Organiser.Domain.Models.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Organiser.Infrastructure.Data.Stores
{
    public class StoreManager : IStoreManager
    {
        public IUserStore UserStore { get; }

        public StoreManager(IUserStore userStore)
        {
            UserStore = userStore;
        }

        // TODO: Have a way to make getting generic
        public IGenericStore<T> Set<T>()
        {
            if (typeof(T) == typeof(User))
            {
                return UserStore as BaseStore<T>;
            }
            return null;
        }
    }
}
