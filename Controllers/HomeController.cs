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
      return View("Details", newGuy);
    }
    [HttpGet("/{id}")]
    public ActionResult Details(int id)
    {
      Pet newPet = Pet.Find(id);
      return View(newPet);
    }

    [HttpPost("/wait/{id}")]
    public ActionResult Wait(int id)
    {
      Pet newPet = Pet.Find(id);
      newPet.SetFoodLevel(-1);
      newPet.SetSleepLevel(-1);
      newPet.SetAttentionLevel(-1);
      newPet.IsDead();
      if (newPet.GetIsDead())
      {
        return View("DeadPet", newPet);
      }
      else
      {
      return View("Details", newPet);
      }
    }

    [HttpPost("/feed-pet/{id}")]
    public ActionResult Feed(int id)
    {
      Pet newPet = Pet.Find(id);
      newPet.SetFoodLevel(1);
      return View("Details", newPet);
    }
    [HttpPost("/sleep/{id}")]
    public ActionResult Sleep(int id)
    {
      Pet newPet = Pet.Find(id);
      newPet.SetSleepLevel(1);
      return View("Details", newPet);
    }

    [HttpPost("/attention/{id}")]
    public ActionResult Attention(int id)
    {
      Pet newPet = Pet.Find(id);
      newPet.SetAttentionLevel(1);
      return View("Details", newPet);
    }

  }
}
