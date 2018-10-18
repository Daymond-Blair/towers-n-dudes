namespace BlairDefense
{
  // Inherits from Dude
  class AverageDude : Dude
  {
    public override int Health {get; protected set;} = 1;

    // Constructor takes path parameter and passes it up to base class 
    public AverageDude(Path path): base(path)
    {
      
    }
    public override void DecreaseHealth(int factor)
    {      
      System.Console.WriteLine("Fired on Average Dude!!");
      base.DecreaseHealth(factor);
      System.Console.WriteLine("Landed a hit!!");
    }
  }
}