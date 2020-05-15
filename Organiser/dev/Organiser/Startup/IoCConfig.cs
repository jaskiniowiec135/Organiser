using CommonServiceLocator;
using GalaSoft.MvvmLight.Ioc;
using Organiser.Application.Interfaces.Services;
using Organiser.Domain.Interfaces.DataProviders;
using Organiser.Domain.Interfaces.Repositories;
using Organiser.Domain.Interfaces.Stores;
using Organiser.Infrastructure.Business.Services;
using Organiser.Infrastructure.Data.DataProviders;
using Organiser.Infrastructure.Data.Repositories;
using Organiser.Infrastructure.Data.Stores;
using Organiser.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Organiser.Startup
{
	public class IoCConfig
	{
		public IoCConfig()
		{
			ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);
		}

		public void RegisterViewModels()
		{
			SimpleIoc.Default.Register<MainViewModel>();
		}

		public void RegisterRepositories()
		{
			SimpleIoc.Default.Register<IUserRepository, UserRepository>(); // this is where you would change the registration to use a different repository
		}

		public void RegisterServices()
		{
			SimpleIoc.Default.Register<IUserService, UserService>();
		}

		public void RegisterProviders()
		{
			SimpleIoc.Default.Register<IUserDataProvider, UserDataProvider>();
			SimpleIoc.Default.Register<ICloudStorageProvider, AzureStorageDataProvider>(); // this is where you would change the registration to use a different provider
		}

		public void RegisterStores()
		{
			SimpleIoc.Default.Register<IUserStore, UserStore>();
			SimpleIoc.Default.Register<IStoreManager, StoreManager>();
		}
	}
}
