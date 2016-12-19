using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventofCode
{
    interface ILevel
    {
        int levelNumber { get; }
        void Run();
    }
}
