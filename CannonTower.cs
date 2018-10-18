using System;

namespace BlairDefense
{
  class CannonTower : Tower
  {
    protected override int Power{get;} = 3;

    public CannonTower(MapLocation location) : base(location)
    {
      
    }
    
    
    
  }
}