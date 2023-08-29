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

            if (move.Length > 0)
            { move.Where(movement => movement == 'M' && facing == "N").Select(movement => Y++).ToList(); }
        }
        public string position()
        {
            return X + ":" + Y + ":" + facing;
        }
    }
}