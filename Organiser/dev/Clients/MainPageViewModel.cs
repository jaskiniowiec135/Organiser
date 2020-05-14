using Application.Interfaces;
using Application.Models;
using Client.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public class MainPageViewModel : BaseViewModel
    {
        private readonly IUserService _userService;
        private string _bodyTitle;
        private string _bodyText;
        public string BodyTitle
        {
            get
            {
                return _bodyTitle;
            }
            set
            {
                Set(() => BodyTitle, ref _bodyTitle, value);
            }
        }

        public string BodyText
        {
            get
            {
                return _bodyText;
            }
            set
            {
                Set(() => BodyText, ref _bodyText, value);
            }
        }

        private async void Initialize()
        {
            IsLoading = true;
            await Task.Delay(2000); // simulate load time
            var users = await _userService.GetValidUsers();
            if (users?.Data == null || users.Data.Count() == 0)
            {
                var user = await _userService.CreateUserAsync(new NewUser
                {
                    FullName = "Felipe Fancybottom",
                    Email = "feffancy@fancybottoms.com"
                });

                BodyText = user.Data.Email;
                BodyTitle = user.Data.FullName;
            }
            else
            {
                BodyText = users.Data.First().Email;
                BodyTitle = users.Data.First().FullName;
            }
            IsLoading = false;
        }

        public MainPageViewModel(IUserService userService)
        {
            _userService = userService;

            Title = "Onion Template";
            BodyTitle = "Loading Name";
            BodyText = "Loading Email";
            Initialize();
        }
    }
}
