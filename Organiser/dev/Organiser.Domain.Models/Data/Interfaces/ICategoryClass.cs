using System;
using System.Collections.Generic;
using System.Text;

namespace Organiser.Domain.Models.Data.Interfaces
{
    public interface ICategoryClass : IBase
    {
        void CreateCategory(string name);
        void GetCategory(string name);
        void EditCategory(string name);
        void DeleteCategory(string name);
        void GetLastActivities(string name);
    }
}
