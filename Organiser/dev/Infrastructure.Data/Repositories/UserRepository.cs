using Domain.Interfaces;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Stores;
using Domain.Models;
using Domain.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class UserRepository : GenericMemoryRepository<User>, IUserRepository
    {
        public UserRepository(IStoreManager manager)
        : base(manager)
        {
        }
    }
}
