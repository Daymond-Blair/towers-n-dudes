namespace BlairDefense
{
  class Path
  {
    // The underscore is a prefix used for private class field/attribute names
    private readonly MapLocation[] _path;
    // Return the length of the path array encapsulated within the Path class
    public int Length => _path.Length;
    
    public Path(MapLocation[] path)
    {
      _path = path;
    }
    
    // Get location of enemy on map
    public MapLocation GetLocationAt(int pathStep) 
    {/*
      if(pathStep < _path.length)
      {
        return _path(pathStep);
      }
      else
      {
        return null;
      }
      */
      
      // Here's another way to write the above if/else statement. Its called a "Ternary If".
      return (pathStep < _path.Length) ? _path[pathStep] : null; 
    }
    
    public bool IsOnPath(MapLocation location)
    {
      foreach(var pathLocation in _path)
      {
        if(location.Equals(pathLocation))
        {
          return true;
        }
      }
      return false;
    }
  }
}