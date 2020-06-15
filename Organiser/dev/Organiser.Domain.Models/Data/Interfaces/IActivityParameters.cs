using System;
using System.Collections.Generic;
using System.Text;

namespace Organiser.Domain.Models.Data.Interfaces
{
    public interface IActivityParameters
    {
        void AddParameter(string activityName, string name, string value, string unit);
        void GetParameter(string name);
        void GetParameterList();
        void EditParameter(string name, string value, string unit);
        void RemoveParameter(string name);
    }
}
