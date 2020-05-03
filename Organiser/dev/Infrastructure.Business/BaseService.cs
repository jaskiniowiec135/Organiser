using Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Business
{
    public class BaseService : IBaseService
    {
        public BaseService()
        {
        }

        public IEnumerable<string> Validate(object model)
        {
            if (model == null)
                return new List<string> { "Empty model received" };
            return null;
        }
    }
}
