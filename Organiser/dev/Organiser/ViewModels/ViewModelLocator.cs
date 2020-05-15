using CommonServiceLocator;
using Organiser.Startup;

namespace Organiser.ViewModels
{
    public class ViewModelLocator
    {
        /// <summary>
        /// Initializes a new instance of the ViewModelLocator class.
        /// </summary>
        public ViewModelLocator()
        {
            var iocConfig = new IoCConfig();
            iocConfig.RegisterRepositories();
            iocConfig.RegisterProviders();
            iocConfig.RegisterServices();
            iocConfig.RegisterViewModels();
            iocConfig.RegisterStores();
        }

        public MainViewModel Main
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MainViewModel>();
            }
        }

        public static void Cleanup()
        {
            // TODO Clear the ViewModels
        }
    }
}
