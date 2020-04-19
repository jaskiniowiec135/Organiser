using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class GenericStore<T> : IGenericStore<T>
    {
        public List<T> Data { get; set; }
        public GenericStore()
        {
            Data = new List<T>();
        }
    }
}
