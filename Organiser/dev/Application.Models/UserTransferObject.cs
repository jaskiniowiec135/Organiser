using Domain.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models
{
    public class UserTransferObject
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string FullName { get; set; }
        public UserTransferObject()
        {

        }

        public UserTransferObject(User entity)
        {
            Id = entity.Id;
            Email = entity.Email;
            FullName = entity.FullName;
        }
    }
}
