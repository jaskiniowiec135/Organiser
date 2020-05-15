using System;
using System.Threading.Tasks;

namespace Organiser.Domain.Interfaces.DataProviders
{
	public interface ICloudStorageProvider
	{
		Task<bool> StoreItem(object item);
	}
}
