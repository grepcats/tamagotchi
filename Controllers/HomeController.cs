using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Tamagotchi.Models;

namespace Tamagotchi.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpPost("/new")]
    public ActionResult CreatePet()
    {
      Pet newGuy = new Pet(Request.Form["name"]);
      return View("PetPage", newGuy);
    }
  }
}
