using System;
using System.Collections.Generic;

namespace Core
{
    public static class Calculator
    {
        public static Tuple<double, string>  CalcSq(int rad)
        {
            double res = Math.Pow(rad,2) * Math.PI;
            return Tuple.Create(res, "Circle");
        }
        public static Tuple<double, string> CalcSq(int[] param)
        {
            bool str = false;
            bool triangleDoesNotExist = false;
            double p = (param[0] + param[1] + param[2]) / 2;
            double res = Math.Sqrt(p * (p - param[0]) * (p - param[1]) * (p - param[2]));
            double sum, sumTriangleExists;

            foreach(int item in param)
            {
                sum = 0;
                sumTriangleExists = 0;

                List<int> pmsCopy = new List<int>(param);
                pmsCopy.Remove(item);

                foreach(int otherItem in pmsCopy)
                {
                    sum += Math.Pow(otherItem, 2);
                    sumTriangleExists += otherItem;
                }

                if(sumTriangleExists < item)
                {
                    return Tuple.Create(0.0, "NE"); ;
                }

                if (sum == Math.Pow(item, 2))
                {
                    str = true;
                    break;
                }

            }

            if(str)
            {
                return Tuple.Create(res, "Rectangular Triangle");
            }
            else
            {
                return Tuple.Create(res, "Triangle");
            }
            
        }
        // Exanple - adding a new figure (one more overload)
        public static Tuple<double, string> CalcSq(int sideA, int sideB, int sideC, int sideD)
        {
            double p = (sideA + sideB + sideC + sideD) / 2;
            double res = Math.Sqrt((p - sideA)*(p - sideB)*(p - sideC)*(p - sideD));
            return Tuple.Create(res, "Quadrilateral");
        }
    }
}
