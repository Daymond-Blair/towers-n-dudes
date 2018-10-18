namespace BlairDefense
{
  // Inherits from Dude
  class QuickDude : Dude
  {
    protected override int StepSize{get;} = 2;
    public override int Health {get; protected set;} = 2;
    // Constructor takes path parameter and passes it up to base class 
    public QuickDude(Path path): base(path)
    {
      
    }

    public override void DecreaseHealth(int factor)
    {      
      System.Console.WriteLine("Fired on Quick Dude!!");
      base.DecreaseHealth(factor);
      System.Console.WriteLine("Landed a hit!!");
    }
  }
}