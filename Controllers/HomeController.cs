﻿using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication5.Models;

namespace WebApplication5.Controllers
{
  public class HomeController : Controller
  {

    public IActionResult Index()
    {
      return View();
    }

    public IActionResult Mobilitetsstatistik()
    {
      return View();
    }
    
    public IActionResult Partnerskap()
    {
      return View();
    }

    public IActionResult Programstatistik()
    {
      return View();
    }

    public IActionResult Praktik()
    {
      return View();
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
}