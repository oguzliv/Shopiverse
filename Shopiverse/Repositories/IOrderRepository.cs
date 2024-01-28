using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shopiverse.Models.Dto;

namespace Shopiverse.Repositories;

public interface IOrderRepository
{
    Task<IEnumerable<object>> GetOrders(GetOrderDto dto);
}
