using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRovers
{
    public class MoveCommand : ICommands
    {

        public void Execute(Rover rover, Plateau plateau)
        {
            switch (rover.Direction) 
            {
                case 'N':
                    if (BorderControl(rover, plateau))
                        rover.YCoordinate++;
                    break;
                case 'E':
                    if (BorderControl(rover, plateau))
                        rover.XCoordinate++;
                    break;
                case 'S':
                    if (BorderControl(rover, plateau))
                        rover.YCoordinate--;
                    break;
                case 'W':
                    if (BorderControl(rover, plateau))
                        rover.XCoordinate--;
                    break;
            }
        }

        public bool BorderControl(Rover rover, Plateau plateau) 
        {
            switch (rover.Direction)
            {
                case 'N':
                    if (rover.YCoordinate >= plateau.YBorder)
                    {
                        Console.WriteLine("Rover had reached to the North border of the plateau, Move command canceled!");
                        return false;
                    }
                    break;
                case 'E':
                    if (rover.XCoordinate >= plateau.XBorder)
                    {
                        Console.WriteLine("Rover had reached to the East border of the plateau, Move command canceled!");
                        return false;
                    }
                    break;
                case 'S':
                    if (rover.YCoordinate <= 0)
                    {
                        Console.WriteLine("Rover had reached to the South border of the plateau, Move command canceled!");
                        return false;
                    }
                    break;
                case 'W':
                    if (rover.XCoordinate <= 0)
                    {
                        Console.WriteLine("Rover had reached to the West border of the plateau, Move command canceled!");
                        return false;
                    }
                    break;
            }
            return true;
        }

    }
}
