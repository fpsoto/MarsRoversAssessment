using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRoversAssessment
{
   
    public class Position : IPosition
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Directions Direction { get; set; }

        public Position()
        {
            X = Y = 0;
            Direction = Directions.N;
        }

        public void DoTheMovement(List<int> maxCoordinates, string moves)
        {
            foreach (var move in moves)
            {
                switch (move)
                {
                    case 'L':
                        this.RotateLeft();
                        break;
                    case 'R':
                        this.RotateRight();
                        break;
                    case 'M':
                        this.MoveFoward();
                        break;
                    default:
                        Console.WriteLine($"Invalid input {move}");
                        break;
                }

                //it is necessary to validate if the movement is within 
                //the limits set at the beginning of the execution
                if (IsMoveOutOfBounds(maxCoordinates))
                {
                    throw new Exception($"Movement out of bounds (0 , 0) and ({maxCoordinates[0]} , {maxCoordinates[1]})");
                }
            }
        }


        private void RotateLeft()
        {
            switch (this.Direction)
            {
                case Directions.N:
                    this.Direction = Directions.W;
                    break;
                case Directions.S:
                    this.Direction = Directions.E;
                    break;
                case Directions.E:
                    this.Direction = Directions.N;
                    break;
                case Directions.W:
                    this.Direction = Directions.S;
                    break;
                default:
                    break;
            }
        }

        private void RotateRight()
        {
            switch (this.Direction)
            {
                case Directions.N:
                    this.Direction = Directions.E;
                    break;
                case Directions.S:
                    this.Direction = Directions.W;
                    break;
                case Directions.E:
                    this.Direction = Directions.S;
                    break;
                case Directions.W:
                    this.Direction = Directions.N;
                    break;
                default:
                    break;
            }
        }

        private void MoveFoward()
        {
            switch (this.Direction)
            {
                case Directions.N:
                    this.Y += 1;
                    break;
                case Directions.S:
                    this.Y -= 1;
                    break;
                case Directions.E:
                    this.X += 1;
                    break;
                case Directions.W:
                    this.X -= 1;
                    break;
                default:
                    break;
            }
        }

        private bool IsMoveOutOfBounds(List<int> maxCoordinates) => (this.X < 0 || this.X > maxCoordinates[0] || this.Y < 0 || this.Y > maxCoordinates[1]);

    }
}
