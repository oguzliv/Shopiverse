using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Shopiverse.Models.Dto;
using Shopiverse.Repositories;

namespace Shopiverse.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{
    private readonly IUserRepository _userRepository;

    public UserController(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromForm] CreateUserDto dto)
    {
        var result = await _userRepository.Create(dto);
        return RedirectToAction("UserDetails", "Home");
    }
}
