using AdventofCode.Level_1;
using AdventofCode.utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventofCode
{
    public class level1 : ILevel
    {

        public void Run()
        {

            List<string> directions = new List<string>();

            var t_directions = File.ReadAllText(@"D:\Projects\AdventofCode\AdventofCode\bin\Debug\directions.txt");
            //   var t_directions = "R5,L5,R5,R3";
            directions = t_directions.Split(',').ToList();
            var gameObject = new GameObject();

            foreach (var direction in directions)
            {
                gameObject.Move(direction);
            }

            var total = Math.Abs(gameObject.pos.x) + Math.Abs(gameObject.pos.y);

        }

        public int levelNumber
        {
            get
            {
                return 1;
            }

        }
    }
}
