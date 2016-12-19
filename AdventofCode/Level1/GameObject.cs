using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdventofCode.utils;
using System.Text.RegularExpressions;
using System.Linq;
namespace AdventofCode.Level_1
{
    class GameObject
    {
        public Vector2 pos { get; set; }
        public Vector2 oldPos { get; set; }
        public int dir { get; set; } // 0 north // 1 east // 2 south // 3 west
        public int distance { get; set; }
        public List<Vector2> positionHistory { get; set; }
        public Vector2 firstRepeat { get; set; }

        public GameObject()
        {
            pos = new Vector2(0, 0);
            oldPos = new Vector2();
            dir = 0;
            this.positionHistory = new List<Vector2>();
            this.positionHistory.Add(new Vector2(0, 0));
        }
        public void Move(string s_movement)
        {
            this.oldPos = new Vector2(pos);
            s_movement = s_movement.Trim();
            string direction = s_movement[0].ToString();
            bool isRight = direction == "R";
            string s_distance = Regex.Replace(s_movement, "[^0-9.]", "");
            var distance = int.Parse(s_distance);
            _rotate(isRight);


            for (int i = 0; i < distance; i++)
            {
                switch (this.dir)
                {
                    case 0: // north
                        pos.y++;
                        break;
                    case 1: // east
                        pos.x++;
                        break;
                    case 2: // south
                        pos.y--;
                        break;
                    case 3: // west
                        pos.x--;
                        break;
                }
                var existing = this.positionHistory.FirstOrDefault(x => x.x == pos.x && x.y == pos.y);
                this.firstRepeat = this.firstRepeat ?? existing;
                positionHistory.Add(new Vector2(pos.x, pos.y));
            }

            //  _updateHistory(distance);
            Console.WriteLine("New Position is " + this.pos.x + ":" + this.pos.y);

        }
        private void _rotate(bool isRight)
        {
            if (isRight)
            {
                switch (this.dir)
                {
                    case 0:
                        this.dir = 1;
                        break;
                    case 1:
                        this.dir = 2;
                        break;
                    case 2:
                        this.dir = 3;
                        break;
                    case 3:
                        this.dir = 0;
                        break;
                }
            }
            else
            {
                switch (this.dir)
                {
                    case 0:
                        this.dir = 3;
                        break;
                    case 1:
                        this.dir = 0;
                        break;
                    case 2:
                        this.dir = 1;
                        break;
                    case 3:
                        this.dir = 2;
                        break;
                }
            }
        }



    }
}
