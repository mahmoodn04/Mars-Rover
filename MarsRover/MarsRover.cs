// Program.cs
using System;
using System.Collections.Generic;
using System.Linq;

namespace MarsRover
{
    public class MarsRover
    {
        private int X = 0;
        private int Y = 0;
        private string facing = "N";
        public void move(string move)
        {



            foreach (char moveChar in move)
            {
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
        private string gotoleft(string facing)
        {
            if (facing == "N")
                {
                    return "W";
                }
                else if (facing == "W")
                {
                    return "S";
                }
                else if (facing == "E")
                {
                    return "N";
                }
                else if (facing == "S")
                {
                    return "E";
                }
                return "N";
        }
        private string gotoright(string facing)
        {
            if (facing == "N")
            {
                return  "E";
            }

            else if (facing == "E")
            {
                return "S";
            }
            else if (facing == "S")
            {
                return "W";
            }
            else if (facing == "W")
            {
                return "N";
            }
            return "N";
        }
        private void gotomovement(string facing)
        {
            if (facing == "W")
            {
                X--;
            }
            else if (facing == "N")
            {
                Y++;
            }
            else if (facing == "E")
            {
                X++;
            }
            else if (facing == "S")
            {
                Y--;
            }
        }

        public string position()
        {
            return X + ":" + Y + ":" + facing;
        }
    }
}