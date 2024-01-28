using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Shopiverse.Models.Dto;
using Shopiverse.Repositories;

namespace Shopiverse.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        public readonly IOrderRepository _orderRepository;
        public OrderController(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetOrders(GetOrderDto dto)
        {
            var result = await _orderRepository.GetOrders(dto);
            return Ok(result);
        }
    }
}