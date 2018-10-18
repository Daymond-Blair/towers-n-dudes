namespace BlairDefense
{
  class BlairDefenseException : System.Exception
  {
    // Default Constructor - remember this will be empty unless we use it to initialize class attributes/fields/variables (not something thats done with exceptions I believe)
    public BlairDefenseException()
    {
      
    }
    // More specific constructor - accepts a string for the exception message
    public BlairDefenseException(string message) : base(message)
    {
      
    }
  }
  
  class OutOfBoundsException : BlairDefenseException
  {
    // Default Constructor
    public OutOfBoundsException()
    {
      
    }
    // More specific constructor
    public OutOfBoundsException(string message) : base(message)
    {
      
    }
  }
}