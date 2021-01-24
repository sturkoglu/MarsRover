using MarsRovers.Core;
using MarsRovers.Core.Enums;
using Microsoft.Extensions.Logging;

namespace MarsRovers.Business
{
    public class RoverOperator : IRoverOperator
    {
        private readonly ILogger<RoverOperator> _logger;

        private Rover _rover;
        private Plateau _plateau;

        public RoverOperator(ILogger<RoverOperator> logger)
        {
            _logger = logger;
        }

        public void Add(IRover rover)
        {
            _rover = rover as Rover;
        }

        public void Add(IPlateau plateau)
        {
            _plateau = plateau as Plateau;
        }

        public (short xCoordinate, short yCoordinate, DirectionType direction) GetRoverPosition() => 
            (_rover.XCoordinate, _rover.YCoordinate, _rover.Direction);

        public void Execute()
        {
            foreach (var command in _rover.Commands)
            {
                switch (command)
                {
                    case CommandType.M:
                        if (CanMove())
                            _rover.Move();
                        break;
                    case CommandType.L:
                        _rover.TurnLeft();
                        break;
                    case CommandType.R:
                        _rover.TurnRight();
                        break;
                    default:
                        _logger.LogError("Invalid command argument");
                        break;
                }

                _logger.LogInformation($"Command {command} executed");
            }
        }

        private bool CanMove()
        {
            switch (_rover.Direction)
            {
                case DirectionType.N:
                    if (_rover.YCoordinate >= _plateau.YBorder)
                    {
                        _logger.LogError("Rover had reached to the North border of the plateau, Move command canceled!");
                        return false;
                    }
                    break;
                case DirectionType.E:
                    if (_rover.XCoordinate >= _plateau.XBorder)
                    {
                        _logger.LogError("Rover had reached to the East border of the plateau, Move command canceled!");
                        return false;
                    }
                    break;
                case DirectionType.S:
                    if (_rover.YCoordinate <= 1)
                    {
                        _logger.LogError("Rover had reached to the South border of the plateau, Move command canceled!");
                        return false;
                    }
                    break;
                case DirectionType.W:
                    if (_rover.XCoordinate <= 1)
                    {
                        _logger.LogError("Rover had reached to the West border of the plateau, Move command canceled!");
                        return false;
                    }
                    break;
                default:
                    _logger.LogError("Invalid direction argument");
                    return false;
            }       
            return true;
        }
    }
}
