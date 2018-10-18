namespace BlairDefense
{
  // Inherits from Dude
  class GodDude : Dude
  {
    protected override int StepSize{get;} = 3;
    public override int Health {get; protected set;} = 6;
    // Instantiate random() object to proc the no damage on hit from "shield"
    private static System.Random _random = new System.Random();
    
    // Constructor takes path parameter and passes it up to base class 
    public GodDude (Path path): base(path)
    {
      
    }
    
    public override void DecreaseHealth(int factor)
    {
      if(_random.NextDouble() < .2)
      {
        base.DecreaseHealth(factor);
      }
      else
      {
        System.Console.WriteLine("Fired on God Dude - but he takes no damage!");
      }
    }
  }
}