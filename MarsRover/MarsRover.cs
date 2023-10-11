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
                if (x >= w)
                {
                    x = 0;
                }
                if (y >= h)
                {
                    y = 0;
                }

                if (moveChar == 'L')
                {
                    facing = gotoleft(facing);
                }

                else if (moveChar == 'R')
                {
                    facing = gotoright(facing);
                }
                else if (moveChar == 'M')
                {
                    gotomovement(facing);
                }
            }


        }
        private char gotoleft(char facing)
        {
            if (facing == 'N')
            {
                return 'W';
            }
            else if (facing == 'W')
            {
                return 'S';
            }
            else if (facing == 'E')
            {
                return 'N';
            }
            else if (facing == 'S')
            {
                return 'E';
            }
            return 'N';
        }
        private char gotoright(char facing)
        {
            if (facing == 'N')
            {
                return 'E';
            }

            else if (facing == 'E')
            {
                return 'S';
            }
            else if (facing == 'S')
            {
                return 'W';
            }
            else if (facing == 'W')
            {
                return 'N';
            }
            return 'N';
        }
        private bool isMyRoverIsOnObstacle()
        {
             bool isOnobstacle = false;
            foreach(var o in obstacle)
            {
               isOnobstacle = isOnobstacle || (x == o.Item1 && y == o.Item2);
            }
            return isOnobstacle;
        }
        private void gotomovement(char facing)
        {
            if (facing == 'W')
            {
                x--;
                if (isMyRoverIsOnObstacle())
                {
                    x++;
                }
            }
            else if (facing == 'N')
            {
                y++;
                if (isMyRoverIsOnObstacle())
                {
                    y--;
                }
            }
            else if (facing == 'E')
            {
                x++;
                if (isMyRoverIsOnObstacle())
                {
                    x--;
                }
            }
            else if (facing == 'S')
            {
                y--;
                if (isMyRoverIsOnObstacle())
                {
                    y++;
                }
            }
        }

        public string position()
        {
            return x + ":" + y + ":" + facing;
        }
    }
}

