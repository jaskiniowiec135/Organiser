using System;
using System.Collections.Generic;
using System.Text;

namespace Organiser.Domain.Interfaces.Stores
{
    public interface IStoreManager
    {
        IUserStore UserStore { get; }
        IGenericStore<T> Set<T>();
    }
}
