using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventofCode.utils
{
    public class Vector2
    {
        public float x { get; set; }
        public float y { get; set; }

        public Vector2()
        {
            x = 0;
            y = 0;
        }
        public Vector2(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public Vector2(Vector2 v)
        {
            this.x = v.x;
            this.y = v.y;
        }
    }


}
