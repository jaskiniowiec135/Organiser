using Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IUserService : IBaseService
    {
        Task<Result<UserTransferObject>> CreateUserAsync(NewUser model);
        Task<Result<UserTransferObject>> FindByIdAsync(int userId);
        Task<Result<UserTransferObject>> RemoveByIdAsync(int userId);
        Task<Result<IEnumerable<UserTransferObject>>> GetValidUsers();
    }
}
