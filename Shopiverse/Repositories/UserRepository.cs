using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Shopiverse.DbContexts;
using Shopiverse.Models;
using Shopiverse.Models.Dto;

namespace Shopiverse.Repositories;

public class UserRepository : IUserRepository
{
    private readonly ApplicationDbContext _db;

    public UserRepository(ApplicationDbContext dbContext)
    {
        _db = dbContext;
    }
    public async Task<User> Create(CreateUserDto dto)
    {
        var user = new User()
        {
            id = dto.Id,
            FirstName = dto.FirstName,
            LastName = dto.LastName,
            Province = dto.Province,
            District = dto.District,
            Address = dto.Address
        };

        _db.Users.Add(user);
        await _db.SaveChangesAsync();

        return user;
    }

    public async Task<IEnumerable<object>> Get()
    {
        return await _db.Users.ToListAsync();
    }
}
