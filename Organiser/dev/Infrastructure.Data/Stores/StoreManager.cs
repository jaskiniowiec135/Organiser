using Domain.Interfaces;
using Domain.Interfaces.Stores;
using Domain.Models;
using Domain.Models.Data;

namespace Infrastructure.Data.Stores
{
    public class StoreManager : IStoreManager
    {
        public IUserStore UserStore { get; }
        public StoreManager(IUserStore userStore)
        {
            UserStore = userStore;
        }

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
