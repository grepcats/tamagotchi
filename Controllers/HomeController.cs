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
      List<Pet> allPets = Pet.GetAll();
      return View(allPets);
    }

    [HttpPost("/new")]
    public ActionResult CreatePet()
    {
      Pet newGuy = new Pet(Request.Form["name"]);
      return View("PetPage", newGuy);
    }
    [HttpGet("/{id}")]
    public ActionResult Details(int id)
    {
      Pet newPet = Pet.Find(id);
      return View(newPet);
    }
  }
}
