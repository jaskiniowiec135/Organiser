using System;
using System.Collections.Generic;
using System.Text;

namespace Organiser.Domain.Models.Data.Interfaces
{
    public interface IActivityClass : IActivityParameters, IActivityRecord
    {
        void CreateActivity(string name);
        void GetActivity(string name);
        void UpdateActivity(string name);
        void DeleteActivity(string name);
        void UpgradeToCategory(string name);
        void GetLastActivities(DateTime startFrom, string name);
    }
}
