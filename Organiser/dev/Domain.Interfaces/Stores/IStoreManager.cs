using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Stores
{
    public interface IStoreManager
    {
        IUserStore UserStore { get; }
        IGenericStore<T> Set<T>();
    }
}
