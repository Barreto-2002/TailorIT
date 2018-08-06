using System;
using System.Collections.Generic;
using TailorIT.UserTools.Domain.Entities;

namespace TailorIT.UserTools.Domain.Repositories
{
   public interface IUserRepository :IDisposable
    {
        IList<User> GetAllUsers();
        IList<User> GetUserbyName(string userName, bool active);
        void AddUser(User user);
    }
}
