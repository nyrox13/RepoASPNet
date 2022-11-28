﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DogSitting.Models;

namespace DogSitting.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
