using Organiser.Domain.Interfaces.DataProviders;
using Organiser.Domain.Models.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Organiser.Infrastructure.Data.DataProviders
{
	public class UserDataProvider : GenericDataProvider<User>, IUserDataProvider
	{
		public UserDataProvider()
		{
		}
	}
}
