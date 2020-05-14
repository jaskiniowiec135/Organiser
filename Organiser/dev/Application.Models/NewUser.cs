using Domain.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models
{
    public class NewUser
    {
        public string Email { get; set; }
        public string FullName { get; set; }
        public string NewPassword { get; set; }

        public User ToUser()
        {
            User user = new User();
            user.Email = this.Email;
            user.FullName = this.FullName;
            user.PasswordHash = this.NewPassword;

            return user;
        }
    }
}
