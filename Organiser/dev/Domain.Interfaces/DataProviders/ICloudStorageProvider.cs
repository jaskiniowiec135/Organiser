using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.DataProviders
{
	public interface ICloudStorageProvider
	{
		Task<bool> StoreItem(object item);
	}
}
