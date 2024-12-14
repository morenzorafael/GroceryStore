using CombinedAPI.Models;
using CombinedAPI.Interfaces;

namespace CombinedAPI.Repositories
{
  public class UserAccessor : IUserAccessor
  {
      private IUserRepository _userRepository;

      public UserAccessor(IUserRepository userRepository)
      {
          _userRepository = userRepository;
      }

      public User GetUserById(int userId)
      {
          return _userRepository.GetUserById(userId);
      }

      public bool CreateUser(User user)
      {
          return _userRepository.CreateUser(user);
      }

      public bool UpdateUser(int id, User user)
      {
          return _userRepository.UpdateUser(id, user);
      }

      public bool DeleteUser(int id)
      {
          return _userRepository.DeleteUser(id);
      }
  }
}