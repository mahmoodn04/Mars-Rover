// Program.cs
using System;
using System.Collections.Generic;
using System.Linq;

namespace MarsRover
{
    public class MarsRover
    {
        public int h; //The hight of the grid 
        public int w; //The width of the grid 
        public int x;
        public int y;
        List<Tuple<int, int>> obstacle;
        public MarsRover(Grid grid)
        {
            x = grid.x;
            y = grid.y;
            h = grid.h;
            w = grid.w;
            obstacle = new List<Tuple<int, int>>();
            foreach (var xy in grid.obstacle)
            {
                obstacle.Add(xy);
            }
        }
        private char facing = 'N';


        public void move(string move)
        {
            foreach (char moveChar in move)
            {
                x = (x >= w) ? x = 0 : x;
                y = (y >= h) ? y = 0 : y;

                switch (moveChar)
                {
                    case 'L':
                        facing = gotoleft(facing);
                        break;
                    case 'R':
                        facing = gotoright(facing);
                        break;
                    default:
                        gotomovement(facing);
                        break;
                }
            }
        }
        private char gotoleft(char facing)
        {
            switch (facing)
            {
                case 'N':
                    return 'W';
                    break;
                case 'W':
                    return 'S';
                    break;
                case 'E':
                    return 'N';
                    break;
                case 'S':
                    return 'E';
                    break;
                default:
                    return 'N';
                    break;
            }
        }
        private char gotoright(char facing)
        {
            switch (facing)
            {
                case 'N':
                    return 'E';
                    break;
                case 'W':
                    return 'N';
                    break;
                case 'E':
                    return 'S';
                    break;
                case 'S':
                    return 'W';
                    break;
                default:
                    return 'N';
                    break;
            }
        }
        private bool isMyRoverIsOnObstacle()
        {
            bool isOnobstacle = false;
            foreach (var o in obstacle)
            {
                isOnobstacle = isOnobstacle || (x == o.Item1 && y == o.Item2);
            }
            return isOnobstacle;
        }
        private void gotomovement(char facing)
        {
            if (facing == 'W') x = isMyRoverIsOnObstacle() ? x : x - 1;
            // if (facing == 'N') y = isMyRoverIsOnObstacle() ? y : y + 1;
            if (facing == 'E') x = isMyRoverIsOnObstacle() ? x : x + 1;
            if (facing == 'S') y = isMyRoverIsOnObstacle() ? y : y - 1;

            if (facing == 'N')
            {
                y++;
                if (isMyRoverIsOnObstacle())
                {
                    y--;
                }
            }
        }

        public string position()
        {
            return x + ":" + y + ":" + facing;
        }
    }
}

