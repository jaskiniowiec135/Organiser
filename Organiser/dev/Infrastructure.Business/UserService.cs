using Application.Interfaces;
using Application.Models;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Business
{
    class UserService : BaseService, IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task<Result<UserTransferObject>> CreateUserAsync(NewUser model)
        {
            var errors = Validate(model);
            if (errors == null)
            {
                var entity = model.ToUser();
                _userRepository.Add(entity);
                await _userRepository.CommitAsync();

                return new Result<UserTransferObject>(new UserTransferObject(entity));
            }
            return new Result<UserTransferObject>(ResultType.Invalid, errors);
        }

        public async Task<Result<UserTransferObject>> FindByIdAsync(int userId)
        {
            var entity = await _userRepository.FindAsync(user => user.Id == userId);
            if (entity == null)
            {
                return new Result<UserTransferObject>(ResultType.Failed, "Could not find user with this Id");
            }
            return new Result<UserTransferObject>(new UserTransferObject(entity));
        }

        public async Task<Result<UserTransferObject>> RemoveByIdAsync(int userId)
        {
            var entity = await _userRepository.FindAsync(user => user?.Id == userId);
            if (entity == null)
            {
                return new Result<UserTransferObject>(ResultType.Failed, "Could not find user with this Id");
            }
            _userRepository.Remove(entity);
            await _userRepository.CommitAsync();
            return new Result<UserTransferObject>(new UserTransferObject(entity));
        }

        public async Task<Result<IEnumerable<UserTransferObject>>> GetValidUsers()
        {
            var entities = await _userRepository.GetAsync(user => !string.IsNullOrEmpty(user?.Email));
            return new Result<IEnumerable<UserTransferObject>>(entities?.Select(entity => new UserTransferObject(entity)));
        }
    }
}
