using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Shopiverse.DbContexts;
using Shopiverse.Models.Dto;

namespace Shopiverse.Repositories;

public class OrderRepository : IOrderRepository
{
    private readonly ApplicationDbContext _db;

    public OrderRepository(ApplicationDbContext dbContext)
    {
        _db = dbContext;
    }
    public async Task<IEnumerable<object>> GetOrders(GetOrderDto dto)
    {

        var resultQuery = _db.Users
                            .Join(_db.Orders, u => u.id, o => o.UserId, (user, order) => new { User = user, Order = order });

        if (!string.IsNullOrEmpty(dto.FirstName))
        {
            resultQuery = resultQuery.Where(result => result.User.FirstName == dto.FirstName);
        }

        if (!string.IsNullOrEmpty(dto.LastName))
        {
            resultQuery = resultQuery.Where(result => result.User.LastName == dto.LastName);
        }

        if (dto.StartDate.HasValue && dto.EndDate.HasValue)
        {
            resultQuery = resultQuery.Where(result => result.Order.CreatedAt >= dto.StartDate && result.Order.CreatedAt <= dto.EndDate);
        }

        var result = await resultQuery
            .Select(result => new
            {
                User = result.User,
                Order = result.Order
            })
            .ToListAsync();

        return result;
    }
}
