using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRovers
{
    public class CommandMove : ICommand,  IBorderControls
    {

        public CommandParameter Execute(CommandParameter inputParameters, Plateau plateau)
        {
            switch (inputParameters.DirectionParameter) 
            {
                case 'N':
                    if (MoveCommandBorderControl(inputParameters, plateau))
                        inputParameters.YCoordinateParameter++;
                    break;
                case 'E':
                    if (MoveCommandBorderControl(inputParameters, plateau))
                        inputParameters.XCoordinateParameter++;
                    break;
                case 'S':
                    if (MoveCommandBorderControl(inputParameters, plateau))
                        inputParameters.YCoordinateParameter--;
                    break;
                case 'W':
                    if (MoveCommandBorderControl(inputParameters, plateau))
                        inputParameters.XCoordinateParameter--;
                    break;
            }

            return inputParameters;
        }

        public bool MoveCommandBorderControl(CommandParameter inputParameters, Plateau plateau) 
        {
            switch (inputParameters.DirectionParameter)
            {
                case 'N':
                    if (inputParameters.YCoordinateParameter >= plateau.YBorder)
                    {
                        Console.WriteLine("Rover had reached to the North border of the plateau, Move command canceled!");
                        return false;
                    }
                    break;
                case 'E':
                    if (inputParameters.XCoordinateParameter >= plateau.XBorder)
                    {
                        Console.WriteLine("Rover had reached to the East border of the plateau, Move command canceled!");
                        return false;
                    }
                    break;
                case 'S':
                    if (inputParameters.YCoordinateParameter <= 0)
                    {
                        Console.WriteLine("Rover had reached to the South border of the plateau, Move command canceled!");
                        return false;
                    }
                    break;
                case 'W':
                    if (inputParameters.XCoordinateParameter <= 0)
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
