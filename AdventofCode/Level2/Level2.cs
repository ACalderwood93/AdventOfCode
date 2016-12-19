using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventofCode
{
    public class Level2 : ILevel
    {
        public int levelNumber
        {
            get
            {
                return 2;
            }

        }

        public void Run()
        {
            var s_directions = File.ReadAllLines("lvl2.txt");
            List<int> combination = new List<int>();
            int[,] keyPad = new int[3, 3] {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 } };
            int xPos = 1;
            int yPos = 1;
            int LineNumber = 1;
            foreach (var directionLine in s_directions)
            {

                var startValue = keyPad[yPos, xPos];
                foreach (var direction in directionLine)
                {
                    string s_direction = direction.ToString();

                    _Move(s_direction, ref xPos, ref yPos);

                }

                int value = keyPad[yPos, xPos];
                combination.Add(value);
                LineNumber++;
            }
        }

        private void _Move(string dir, ref int x, ref int y)
        {
            switch (dir)
            {
                case "U":
                    y--;
                    break;
                case "R":
                    x++;
                    break;
                case "D":
                    y++;
                    break;
                case "L":
                    x--;
                    break;
            }

            if (x > 2)
                x = 2;

            if (x < 0)
                x = 0;

            if (y > 2)
                y = 2;

            if (y < 0)
                y = 0;
        }
    }
}
