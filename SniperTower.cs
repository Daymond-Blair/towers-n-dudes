using System;

namespace BlairDefense
{
  class SniperTower : Tower
  {
    protected override int Range{get;} = 4;

    public SniperTower(MapLocation location) : base(location)
    {
      
    }
    
    
    
  }
}