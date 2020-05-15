using Organiser.Application.Models.Input;
using Organiser.Domain.Models.Data;

namespace Organiser.Application.Models.Extensions
{
	public static class UserExtensions
	{
		public static User ToUser(this NewUser model)
		{
			return new User
			{
				Email = model.Email,
				FullName = model.FullName
			};
		}
	}
}
