namespace BlairDefense
{
  abstract class Dude : IDude
  { 
    // Set private attributes
    private readonly Path _path;
    private int _pathStep = 0;
    
    protected virtual int StepSize{get;} = 1;
    
    // Expression bodied member - public MapLocation Location{return _path.GetLocationAt()_pathStep;}
    public MapLocation Location => _path.GetLocationAt(_pathStep);
    
    // Abstract member (cannot be initialized to a value)
    public abstract int Health {get; protected set;}
    
    
    // ROADBLOCK - trouble visualizing expression bodied members properly
    // True if the invader has reached the end of the path
    public bool HasScored
    {
      get 
      {
        return _pathStep >= _path.Length;
      } 
    }
    
    public bool IsNeutralized => Health <= 0;
    public bool IsActive => !(IsNeutralized || HasScored);
    
    public Dude(Path path)
    {
      _path = path;
    }
    
    public void Move() => _pathStep += StepSize;
    
    // Method to decrease health of invader
    public virtual void DecreaseHealth(int factor)
    {
      Health -= factor;
    }
  }
}