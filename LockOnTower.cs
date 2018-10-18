using System;

namespace BlairDefense
{
  class LockOnTower : Tower
  {
    protected override double Accuracy{get;} = 0.97;

    public LockOnTower(MapLocation location) : base(location)
    {
      
    }
    
    
    
  }
}