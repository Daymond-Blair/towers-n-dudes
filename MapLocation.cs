namespace BlairDefense
{
  // MapLocation is a subclass of Point class (inherits from Point) as indicated by the colon - MapLocation : Point = subclass{} : superclass{} - Point class takes x and y coordinates so MapLocation must as well

  class MapLocation : Point
  {
    // MapLocation constructor (remember this defines what parameters the class will take and should be empty unless we're setting default values
    public MapLocation(int x, int y, Map map) : base(x, y) // Add instance of Map class to constructor - Map map  aka add Map object to constructor
    {
      if(!map.OnMap(this)) // Adding instance of Map class allows us to use map to validate input
      {
        throw new OutOfBoundsException(x + "," + y + " is outside of the Map.");
      }
    }
    
    public bool InRangeOf(MapLocation location, int range)
    {
      return DistanceTo(location) <= range;
    }
  }
}