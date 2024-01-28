using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Shopiverse.Models;
using Shopiverse.Repositories;

namespace Shopiverse.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IUserRepository _userRepository;

    public HomeController(ILogger<HomeController> logger, IUserRepository userRepository)
    {
        _logger = logger;
        _userRepository = userRepository;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public async Task<IActionResult> UserDetails()
    {
        List<User> userList = new List<User>();
        var response = await _userRepository.Get();
        return View(response);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
