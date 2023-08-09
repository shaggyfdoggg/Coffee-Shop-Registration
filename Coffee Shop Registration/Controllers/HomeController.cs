﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Coffee_Shop_Registration.Models;

namespace Coffee_Shop_Registration.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Form()
    {
        return View();
    }

    public IActionResult Result(Username u)
    {
        return View(u);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

