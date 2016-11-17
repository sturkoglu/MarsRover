using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRovers
{
    public class CommandMove : ICommands,  IBorderControls
    {

        public void Execute(CommandParameters commandParameter, Plateau plateau)
        {
            switch (commandParameter.DirectionParameter) 
            {
                case 'N':
                    if (MoveCommandBorderControl(commandParameter, plateau))
                        commandParameter.YCoordinateParameter++;
                    break;
                case 'E':
                    if (MoveCommandBorderControl(commandParameter, plateau))
                        commandParameter.XCoordinateParameter++;
                    break;
                case 'S':
                    if (MoveCommandBorderControl(commandParameter, plateau))
                        commandParameter.YCoordinateParameter--;
                    break;
                case 'W':
                    if (MoveCommandBorderControl(commandParameter, plateau))
                        commandParameter.XCoordinateParameter--;
                    break;
            }
        }

        public bool MoveCommandBorderControl(CommandParameters commandParameter, Plateau plateau) 
        {
            switch (commandParameter.DirectionParameter)
            {
                case 'N':
                    if (commandParameter.YCoordinateParameter >= plateau.YBorder)
                    {
                        Console.WriteLine("Rover had reached to the North border of the plateau, Move command canceled!");
                        return false;
                    }
                    break;
                case 'E':
                    if (commandParameter.XCoordinateParameter >= plateau.XBorder)
                    {
                        Console.WriteLine("Rover had reached to the East border of the plateau, Move command canceled!");
                        return false;
                    }
                    break;
                case 'S':
                    if (commandParameter.YCoordinateParameter <= 0)
                    {
                        Console.WriteLine("Rover had reached to the South border of the plateau, Move command canceled!");
                        return false;
                    }
                    break;
                case 'W':
                    if (commandParameter.XCoordinateParameter <= 0)
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
