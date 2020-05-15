using Organiser.Application.Models.Input;
using Organiser.Application.Models.Output;
using Organiser.Application.Models.Transfer;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Organiser.Application.Interfaces.Services
{
	public interface IUserService : IBaseService
	{
		/// <summary>
		/// Creates a new user entity
		/// </summary>
		/// <returns>The created user result</returns>
		/// <param name="model">New user info</param>
		Task<Result<UserTransferObject>> CreateUserAsync(NewUser model);

		/// <summary>
		/// Finds a user by id
		/// </summary>
		/// <returns>The found user result</returns>
		/// <param name="userId">The id of the user</param>
		Task<Result<UserTransferObject>> FindByIdAsync(int userId);

		/// <summary>
		/// Removes a user by their id
		/// </summary>
		/// <returns>The removed user result</returns>
		/// <param name="userId">The id of the user</param>
		Task<Result<UserTransferObject>> RemoveByIdAsync(int userId);

		/// <summary>
		/// Gets all users that have an email
		/// </summary>
		/// <returns></returns>
		Task<Result<IEnumerable<UserTransferObject>>> GetValidUsers();

	}
}
