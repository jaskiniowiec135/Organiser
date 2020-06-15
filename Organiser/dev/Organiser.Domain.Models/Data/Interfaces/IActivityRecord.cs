using System;
using System.Collections.Generic;
using System.Text;

namespace Organiser.Domain.Models.Data.Interfaces
{
    public interface IActivityRecord
    {
        void AddActivityRecord(string name);
        void EditActivityRecord(string name);
    }
}
