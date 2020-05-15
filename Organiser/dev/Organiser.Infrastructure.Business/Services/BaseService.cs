using Organiser.Application.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Organiser.Infrastructure.Business.Services
{
	public class BaseService : IBaseService
	{
		public BaseService()
		{
		}

		public IEnumerable<string> Validate(object model)
		{
			// TODO: do some validation against data annotations
			return null;
		}
	}
}
