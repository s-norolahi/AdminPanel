using Domain.Entities.User;
using InfraStructure.Contracts;
using Microsoft.AspNetCore.Identity;
using Services.Interface;
using Services.Interface.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services.Security;
public class UserService : IUserService,IBaseSevice
{
    private readonly UserManager<User> _userManager;
   // private readonly IRepository<User> _userRepository;
    public UserService(UserManager<User> userManager)
    {
        _userManager = userManager;
     //   _userRepository = userRepository;
    }

    public async Task<User> FindUserByUserName(string userName, string password)
    {
        var user = await _userManager.FindByNameAsync(userName);
        //if (user == null)
        //    throw new BadRequestException(errorUser);
        //if (!user.IsActive)
        //    throw new BadRequestException(errorUser);
        //var isPasswordValid = await _userManager.CheckPasswordAsync(user, password);
        //if (!isPasswordValid)
        //    throw new BadRequestException(errorUser);
        return user;

    }

    public async Task<User> GetByIdAsync(CancellationToken cancellationToken, int id)
    {
        return new User();
    }

    public async Task<IList<string>> GetUserRoles(User user)
    {
        return await _userManager.GetRolesAsync(user);
    }
}

