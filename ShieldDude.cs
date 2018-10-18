namespace BlairDefense
{
  // Inherits from Dude
  class ShieldDude : Dude
  {
    public override int Health {get; protected set;} = 2;

    // Instantiate random() object to proc the no damage on hit from "shield"
    private static System.Random _random = new System.Random();
    
    // Constructor takes path parameter and passes it up to base class 
    public ShieldDude(Path path): base(path)
    {
      
    }
    
    public override void DecreaseHealth(int factor)
    {
      System.Console.WriteLine("Fired on Shield Dude!!");

      if(_random.NextDouble() < .5)
      {
        base.DecreaseHealth(factor);
      }
      else
      {
        System.Console.WriteLine("Shot at a Shield Dude - it has no effect!!!");
      }
    }
  }
}