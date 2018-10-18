namespace BlairDefense
{
  class Map
  {
    public readonly int Width;
    public readonly int Height;
    
    public Map(int width, int height)
    {
      Width = width;
      Height = height;
    }
    
    public bool OnMap(Point point)
    {
      bool inBounds = point.X >= 0 && point.X < Width && point.Y >= 0 && point.Y < Height;
      
      bool outOfBounds = point.X < 0 || point.X >= Width || point.Y < 0 || point.Y >= Height;
      
      inBounds = !outOfBounds;
      
      return inBounds;
    }
  }
}