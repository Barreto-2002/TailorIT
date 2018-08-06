using System.Collections.Generic;
using System.Linq;
using TailorIT.UserTools.Domain.Entities;
using TailorIT.UserTools.Domain.Repositories;
using TailorIT.UserTools.Infra.Data.Contexts;

namespace TailorIT.UserTools.Infra.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly TailorItContext _tailorIt;

        public UserRepository(TailorItContext tailorItContext)
            => _tailorIt = tailorItContext;

        public IList<User> GetAllUsers()
        {
            return _tailorIt.Users.ToList();
        }

        public IList<User> GetUserbyName(string userName, bool active)
        {
            return _tailorIt.Users.Where(c=> c.Active == active && c.Name == userName).ToList();
        }

        public void AddUser(User user)
        {
            _tailorIt.Users.Add(user);
            _tailorIt.SaveChanges();
        }
        public void Dispose() =>
            _tailorIt.Dispose();
    }
}
