using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Stores
{
    public interface IGenericStore<T>
    {
        List<T> Data { get; set; }
    }
}
