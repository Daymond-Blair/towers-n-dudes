using System;

namespace BlairDefense
{
  class Tower
  {
    protected virtual int Range{get;} = 1;
    protected virtual int Power{get;} = 1;
    protected virtual double Accuracy{get;} = 0.75;
    
    private static readonly Random _random = new Random();
    
    private readonly MapLocation _location;
    
    public Tower(MapLocation location)
    {
      _location = location;
    }
    
    public bool IsSuccessfulShot()
    {
      return _random.NextDouble() < Accuracy;
    }
    public void FireOnDudes(IDude[] dudes)
    {
       foreach(IDude dude in dudes)
       {
          // Do stuff with invader
         if(dude.IsActive && _location.InRangeOf(dude.Location, Range))
         {
             if(IsSuccessfulShot())
            {
             dude.DecreaseHealth(Power);
             
               
             if(dude.IsNeutralized)
             {
              Console.WriteLine("Killshot!!!");
              Console.WriteLine("--Neutralized dude at " + dude.Location + "--");
             }
            }
           else
           {
            Console.WriteLine("--Missed dude at " + dude.Location + "--");
           }
           break;
         }
       }
    }
  }
}
