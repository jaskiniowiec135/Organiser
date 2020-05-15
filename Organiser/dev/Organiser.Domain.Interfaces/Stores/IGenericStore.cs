using System;
using System.Collections.Generic;
using System.Text;

namespace Organiser.Domain.Interfaces.Stores
{
    public interface IGenericStore<T>
    {
        List<T> Data { get; set; }
    }
}
