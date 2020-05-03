﻿using Application.Interfaces;
using CommonServiceLocator;
using Domain.Interfaces;
using GalaSoft.MvvmLight.Ioc;
using Infrastructure.Business;
using Infrastructure.Data;
using Organiser.ViewModel;

namespace Organiser
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
            //SimpleIoc.Default.Register<IUserDataProvider, UserDataProvider>();
            //SimpleIoc.Default.Register<ICloudStorageProvider, AzureStorageDataProvider>(); // this is where you would change the registration to use a different provider
        }

        public void RegisterStores()
        {
            SimpleIoc.Default.Register<IUserStore, UserStore>();
            //SimpleIoc.Default.Register<IStoreManager, StoreManager>();
        }
    }
}
