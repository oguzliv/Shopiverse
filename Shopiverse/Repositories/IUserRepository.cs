using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shopiverse.Models;
using Shopiverse.Models.Dto;

namespace Shopiverse.Repositories;

public interface IUserRepository
{
    public Task<IEnumerable<object>> Get();
    public Task<User> Create(CreateUserDto dto);
}
