using Domain.Entities.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interface.Security;
public interface IUserService
{
    Task<User> FindUserByUserName(string userName, string password);
    Task<IList<string>> GetUserRoles(User user);
    //Task<User> GetByUserAndPass(string username, string password, CancellationToken cancellationToken);
  //  Task AddAsync(User user, string password, CancellationToken cancellationToken);
    //Task UpdateSecurityStampAsync(User user, CancellationToken cancellationToken);
   // Task UpdateLastLoginDateAsync(User user, CancellationToken cancellationToken);
    Task<User> GetByIdAsync(CancellationToken cancellationToken, int id);
}

