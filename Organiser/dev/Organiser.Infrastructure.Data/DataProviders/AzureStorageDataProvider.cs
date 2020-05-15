using Organiser.Domain.Interfaces.DataProviders;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Organiser.Infrastructure.Data.DataProviders
{
	public class AzureStorageDataProvider : ICloudStorageProvider
	{
		public AzureStorageDataProvider()
		{
		}

		public Task<bool> StoreItem(object item)
		{
			throw new NotImplementedException();
		}
	}
}
