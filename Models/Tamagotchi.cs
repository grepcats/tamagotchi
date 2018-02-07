namespace Tamagotchi.Models
{
  public class Pet
  {
    private string _name;
    private int _food;
    private int _sleep;
    private int _attention;
    private bool _dead;

    public Pet(string name)
    {
      _name = name;
      _food = 10;
      _sleep = 10;
      _attention = 10;
      _dead = false;
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

    //get & set for sleep
    //get & set for attention
    //get & set for dead
  }
}
