using Organiser.Domain.Interfaces.Stores;
using Organiser.Domain.Models.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Organiser.Infrastructure.Data.Stores
{
    public class UserStore : BaseStore<User>, IUserStore
    {
    }
}
