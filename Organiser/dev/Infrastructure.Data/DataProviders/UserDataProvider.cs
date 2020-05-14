using Domain.Interfaces.DataProviders;
using Domain.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.DataProviders
{
    public class UserDataProvider : GenericDataProvider<User>, IUserDataProvider
    {
        public UserDataProvider()
        {

        }
    }
}
