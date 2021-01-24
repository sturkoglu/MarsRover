using System.Collections.Generic;
using MarsRovers.Core;
using MarsRovers.Core.Enums;

namespace MarsRovers.Business
{
    public class Rover : IRover
    {
        public short XCoordinate { get; private set; }
        public short YCoordinate { get; private set; }
        public DirectionType Direction { get; private set; }
        public IList<CommandType> Commands { get; private set; }

        public void DeployRover(short xCoordinate, short yCoordinate, DirectionType direction)
        {
            XCoordinate = xCoordinate;
            YCoordinate = yCoordinate;
            Direction = direction;
        }

        public void Send(IList<CommandType> commands)
        {
            Commands = commands;
        }

        public void Move()
        {
            switch (Direction)
            {
                case DirectionType.N:
                    YCoordinate++;
                    break;
                case DirectionType.E:
                    XCoordinate++;
                    break;
                case DirectionType.S:
                    YCoordinate--;
                    break;
                case DirectionType.W:
                    XCoordinate--;
                    break;
            }
        }

        public void TurnLeft()
        {
            switch (Direction)
            {
                case DirectionType.N:
                    Direction = DirectionType.W;
                    break;
                case DirectionType.E:
                    Direction = DirectionType.N;
                    break;
                case DirectionType.S:
                    Direction = DirectionType.E;
                    break;
                case DirectionType.W:
                    Direction = DirectionType.S;
                    break;
            }
        }

        public void TurnRight()
        {
            switch (Direction)
            {
                case DirectionType.N:
                    Direction = DirectionType.E;
                    break;
                case DirectionType.E:
                    Direction = DirectionType.S;
                    break;
                case DirectionType.S:
                    Direction = DirectionType.W;
                    break;
                case DirectionType.W:
                    Direction = DirectionType.N;
                    break;
            }
        }
    }
}
