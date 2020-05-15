using Organiser.Domain.Models.Data;
using Organiser.Domain.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Organiser.Application.Models.Transfer
{
	public class UserTransferObject
	{
		public int Id { get; set; }
		public string Email { get; set; }
		public string FullName { get; set; }
		public UserRole Role { get; set; }

		public UserTransferObject()
		{

		}
		public UserTransferObject(User entity)
		{
			Id = entity.Id;
			Email = entity.Email;
			FullName = entity.FullName;
			Role = entity.Role;
		}
	}
}
