using System;
using System.Collections.Generic;
using System.Linq;

namespace MarsRoversAssessment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Max coordinates
            var upperCorner = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();

            DoTheMovement(upperCorner);
            DoTheMovement(upperCorner);

            Console.ReadLine();
        }

        //To apply movement twice, there will be a function 
        //that will request the position and the series of movements
        static void DoTheMovement(List<int> upperCornerCoordinates)
        {
            var positionByUser = Console.ReadLine().Trim().Split(' ');

            //Validating position input
            if (positionByUser.Count() == 3)
            {
                Position position = new Position()
                {
                    X = Convert.ToInt32(positionByUser[0]),
                    Y = Convert.ToInt32(positionByUser[1]),
                    Direction = (Directions)Enum.Parse(typeof(Directions), positionByUser[2])
                };

                var moves = Console.ReadLine().ToUpper();

                try
                {
                    position.DoTheMovement(upperCornerCoordinates, moves);
                    Console.WriteLine($"Current Position: {position.X} {position.Y} {position.Direction.ToString()}");
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
                Console.WriteLine("Input not allowed");
            }
        }
    }
}
