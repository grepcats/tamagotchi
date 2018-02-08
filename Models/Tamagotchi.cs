using System;
using System.Collections.Generic;


namespace Tamagotchi.Models
{
  public class Pet
  {
    private string _name;
    private int _food;
    private int _sleep;
    private int _attention;
    private bool _dead;
    private int _id;

    private static List<Pet> _instances = new List<Pet> {};

    public Pet(string name)
    {
      _name = name;
      _food = 15;
      _sleep = 15;
      _attention = 15;
      _dead = false;
      _instances.Add(this);
      _id = _instances.Count;
    }

    public static void Remove(int id)
    {
      _instances.RemoveAt(id-1);
      for (int i = 0; i < _instances.Count; i++) {
        _instances[i]._id = i+1;
      }
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

    public int GetSleepLevel()
    {
      return _sleep;
    }

    public void SetSleepLevel(int num)
    {
      _sleep += num;
    }

    public int GetAttentionLevel()
    {
      return _attention;
    }

    public void SetAttentionLevel(int num)
    {
      _attention += num;
    }

    public void IsDead()
    {
      if (_food <= 0 || _sleep <= 0 || _attention <= 0)
      {
        _dead = true;
      }
      else
      {
        _dead = false;
      }
    }

    public bool GetIsDead()
    {
      return _dead;
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
  }
}
