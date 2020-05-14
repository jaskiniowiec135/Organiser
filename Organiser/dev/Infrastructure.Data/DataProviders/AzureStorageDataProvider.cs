using Domain.Interfaces.DataProviders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.DataProviders
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
