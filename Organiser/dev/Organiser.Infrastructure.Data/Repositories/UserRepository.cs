using Organiser.Domain.Interfaces.Repositories;
using Organiser.Domain.Interfaces.Stores;
using Organiser.Domain.Models.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Organiser.Infrastructure.Data.Repositories
{
	public class UserRepository : GenericMemoryRepository<User>, IUserRepository
	{
		public UserRepository(IStoreManager manager)
			: base(manager)
		{
		}
	}
}
