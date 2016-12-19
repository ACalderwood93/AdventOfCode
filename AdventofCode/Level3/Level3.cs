using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventofCode
{
    public class Level3 : ILevel
    {
        public int levelNumber
        {
            get { return 3; }
        }

        public void Run()
        {
            var s_triangles = File.ReadAllLines("lvl3.txt");
            //s_triangles = new string[] { "5 10 25" };
            int invalidTriangles = 0;
            foreach (var triangle in s_triangles)
            {


                var s_pointsArr = triangle.Trim().Split(' ').ToList();
                s_pointsArr.RemoveAll(x => x == " " || x == "");


                    var PointsArr = s_pointsArr.Select(x => int.Parse(x.Trim())).ToArray();

                    PointsArr = PointsArr.OrderBy(x => x).ToArray();

                    if (!_IsTriangleValid(PointsArr))
                        invalidTriangles++;


            }

            int validTriangles = s_triangles.Length - invalidTriangles;
        }

        private bool _IsTriangleValid(int[] points)
        {

            int[] tmpPoints = { };

            tmpPoints = _Clone(points);
            for (int i = 0; i < points.Length; i++)
            {
                int valToCompare = tmpPoints[i];
                tmpPoints[i] = 0;

                if (tmpPoints.Sum(x => x)  <= valToCompare)
                    return false;

                tmpPoints = _Clone(points);
            }
            return true;
        }
        private int[] _Clone(int[] original)
        {
            int[] result = new int[original.Length];

            for (int i = 0; i < original.Length; i++)
                result[i] = original[i];

            return result;
        }
    }
}
