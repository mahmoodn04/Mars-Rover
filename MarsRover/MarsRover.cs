// Program.cs
using System;
using System.Collections.Generic;
using System.Linq;

namespace MarsRover
{
    public class MarsRover
    {
        private int h; //The hight of the grid 
        private int w; //The width of the grid 
        private int X;
        private int Y;

        public MarsRover(int x, int y, int H, int W)
        {
            X = x;
            Y = y;
            h = H;
            w = W;

        }


        private char facing = 'N';
        private int x_obstacle = 0;
        private int y_obstacle = 3;

        public void move(string move)
        {



            foreach (char moveChar in move)
            {
                if (X >= w)
                {
                    X = 0;
                }
                if (Y >= h)
                {
                    Y = 0;
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
        private void gotomovement(char facing)
        {
            if (facing == 'W')
            {
                X--;
                if (X == x_obstacle && Y == y_obstacle)
                {
                    X++;
                }
            }
            else if (facing == 'N')
            {
                Y++;
                if (X == x_obstacle && Y == y_obstacle)
                {
                    Y--;
                }
            }
            else if (facing == 'E')
            {
                X++;
                if (X == x_obstacle && Y == y_obstacle)
                {
                    X--;
                }
            }
            else if (facing == 'S')
            {
                Y--;
                if (X == x_obstacle && Y == y_obstacle)
                {
                    Y++;
                }
            }
        }

        public string position()
        {
            return X + ":" + Y + ":" + facing;
        }
    }
}

