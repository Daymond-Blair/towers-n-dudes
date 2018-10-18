namespace BlairDefense
{
  // Inherits from Dude
  class BuffDude : Dude
  {
    public override int Health {get; protected set;} = 4;

    // Constructor takes path parameter and passes it up to base class 
    public BuffDude(Path path): base(path)
    {
      
    }
    
    
    public override void DecreaseHealth(int factor)
    {      
      System.Console.WriteLine("Fired on Buff Dude!!");
      base.DecreaseHealth(factor);
      System.Console.WriteLine("Landed a hit!!");
    }
  }
}