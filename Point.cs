using System;
namespace BlairDefense
{
  class Point
  {
    public readonly int X;
    public readonly int Y;
    
    public Point(int x, int y)
    {
      X = x;
      Y = y;
    }
    
    public override string ToString()
    {
      return X + "," + Y;
    }
    
    public override bool Equals(object obj)
    {
      if(!(obj is Point))
      {
        return false;
      }
      
      Point that = obj as Point;
      
      return this.X == that.X && this.Y == that.Y;
    }
    
    // to make a unuique hash code, instead of adding the two variables together simply, multiply one my a prime number then add the other to it.
    public override int GetHashCode()
    {
      return X.GetHashCode() * 31 + Y.GetHashCode();
    }
    
    public int DistanceTo(int x, int y)
    {
      int xDiff = X - x;
      int yDiff = Y - y;
      /*
      Initial Easy Cartesian Coordinate Calculation
      int xDiffSquared = xDiff * xDiff;
      int yDiffSquared = yDiff * yDiff;
      
      return (int)Math.Sqrt(xDiffSquared + yDiffSquared);
     */
     
     // refactored initial calculation into less verbose return statement
      return (int)Math.Sqrt(Math.Pow(xDiff, 2) + Math.Pow(yDiff, 2));
    }
    
    public int DistanceTo(Point point)
    {
      return DistanceTo(point.X, point.Y);
    }
  }
  

}