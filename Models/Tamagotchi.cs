using System;
using System.Collections.Generic;


namespace Tamagotchi.Models
{
  public class Pet
  {
    private string _name;
    private int _food;
    // private int _sleep;
    // private int _attention;
    // private bool _dead;
    private int _id;

    private static List<Pet> _instances = new List<Pet> {};

    public Pet(string name)
    {
      _name = name;
      _food = 10;
      // _sleep = 10;
      // _attention = 10;
      // _dead = false;
      _instances.Add(this);
      _id = _instances.Count;
    }

    public string GetName()
    {
      return _name;
    }

    public void SetName(string name)
    {
      _name = name;
    }

    public int GetFoodLevel()
    {
      return _food;
    }

    public void SetFoodLevel(int num)
    {
      _food += num;
    }
    public static List<Pet> GetAll()
    {
      return _instances;
    }
    public static Pet Find(int searchId)
    {
      return _instances[searchId-1];
    }
    public int GetId()
    {
      return _id;
    }
    //get & set for sleep
    //get & set for attention
    //get & set for dead
  }
}
