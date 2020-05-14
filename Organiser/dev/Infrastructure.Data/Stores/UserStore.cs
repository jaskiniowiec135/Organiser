using Domain.Interfaces;
using Domain.Interfaces.Stores;
using Domain.Models;
using Domain.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Stores
{
    public class UserStore : GenericStore<User>, IUserStore
    {
    }
}
