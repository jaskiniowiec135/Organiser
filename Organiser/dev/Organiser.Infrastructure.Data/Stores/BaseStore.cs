using Organiser.Domain.Interfaces.Stores;
using System;
using System.Collections.Generic;
using System.Text;

namespace Organiser.Infrastructure.Data.Stores
{
    public class BaseStore<T> : IGenericStore<T>
    {
        public List<T> Data { get; set; }
        public BaseStore()
        {
            Data = new List<T>();
        }
    }
}
