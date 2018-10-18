using System;

namespace BlairDefense
{
  class GodTower : Tower
  {
    protected override int Power{get;} = 4;
    protected override int Range{get;} = 5;
    protected override double Accuracy{get;} = 1.5;
    
    //private static System.Random _random = new System.Random();



    public GodTower(MapLocation location) : base(location)
    {
      
    }
    
    
  }
}