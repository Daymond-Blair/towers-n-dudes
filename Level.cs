namespace BlairDefense
{
  class Level
  {
    private readonly IDude[] _dudes;
    
    public Tower[] Towers{get; set;}
  
    public Level (IDude[] dudes)
    {
      _dudes = dudes;
    }
    
    // Returns true if player wins - false if player loses.
    public bool Play()
    {
      // Keep track of how many dudes remain.
      int remainingDudes = _dudes.Length;
      
      // Run until all dudes are neutralized or an invader reaches the end of the path.
      // Each tower has opportunity to fire on dudes.
      while(remainingDudes > 0)
      {
        // Loop through each tower to fire on dudes.
        foreach(Tower tower in Towers)
        {
          tower.FireOnDudes(_dudes);
        }
        
        // Count and save the dudes that are still active.
        
        // Reset remaining dudes to zero.
        remainingDudes = 0;
        
        // Loop through dudes
        foreach(IDude invader in _dudes)
        {
          if(invader.IsActive)
            {
              // Invader turn - move down the path.
              invader.Move();
              
              // Check if invader reached end of path (scored).
              if(invader.HasScored)
                {
                  // Player loses.
                  return false;
                }
              
              // Increment dudes for each active invader in the array.
              remainingDudes++;
            }
         }
      }
      // Player wins
      return true;
    
    }
  }
}