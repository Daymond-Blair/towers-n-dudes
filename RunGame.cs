using System;
namespace BlairDefense
{
    class RunGame
    {
        public static void Main()
        {
          Console.WriteLine("Welcome to Towers and Dudes! The best Tower Defense game with absolutely NO graphics (who needs those anyway?)! Since elaborate instructions are for the weak, lets jump in!");

          Map map = new Map(8, 5);
          // Input validation for out of bounds map points
          try
          {
            Path path = new Path(
            new []{
              new MapLocation(0, 2, map),
              new MapLocation(1, 2, map),
              new MapLocation(2, 2, map),
              new MapLocation(3, 2, map),
              new MapLocation(4, 2, map),
              new MapLocation(5, 2, map),
              new MapLocation(6, 2, map),
              new MapLocation(7, 2, map)
            }
            );
            /* Test for IsOnPath();
            MapLocation location = new MapLocation(0, 2, map);
            
            if(path.IsOnPath(location))
            {
              Console.WriteLine(location + " is on the path!");
              return;
            }
            */
            IDude[] dudes =
            {
              new AverageDude(path),
              new BuffDude(path),
              new QuickDude(path),
              new ShieldDude(path),
              new GodDude(path)
            };
            
            // TODO remove test points from towers and use user input instead
            /* Console.Write("Enter the x coordinates (0-7) and the y coordinates (0 - 4) of your towers: ");
            
            var inputXY = Console.ReadLine();
            string [] coordinates = inputXY.Split(',');
            int towerOneX = int.Parse(coordinates[0]);
            int towerOneY = int.Parse(coordinates[1]);
            */
            
            Tower[] towers = 
            {
              new CannonTower (new MapLocation(1, 3, map)),
              new LockOnTower (new MapLocation(3, 3, map)),
              new SniperTower (new MapLocation(5, 3, map)),
            };
            
            Level level1 = new Level(dudes)
            {
              Towers = towers
            };
            
            bool playerWon = level1.Play();
            
            Console.WriteLine("Player " + (playerWon? "Won!!!" : "Lost!!" ));
          }
          catch(IndexOutOfRangeException)
          {
            Console.WriteLine("Those coordinates don't even exist - come back when you're serious!!!");
          }
          catch(FormatException)
          {
            Console.WriteLine("Really? That's not even the right format!!!");
          }
          catch(OutOfBoundsException ex)
          {
            Console.WriteLine(ex.Message);
          }
          catch(BlairDefenseException)
          {
            Console.WriteLine("Unhandled BlairDefenseException");
          }
          catch(Exception ex)
          {
            Console.WriteLine("Unhandled Exception" + ex);
          }
          
        }
    }
}