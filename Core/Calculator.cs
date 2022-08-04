using System;
using System.Collections.Generic;

namespace Core
{
    public abstract class Shape
    {
        public abstract Tuple<double, string> CalcSq();
    }

    public class Circle : Shape
    {
        private int rad { get; set; }
        public Circle(int rad)
        {
            this.rad = rad;
        }

        public override Tuple<double, string> CalcSq()
        {
            double res = Math.Pow(rad, 2) * Math.PI;
            return Tuple.Create(res, "Circle");
        }

    }
    public class Triangle : Shape
    {
        private int[] param { get; set; }

        public Triangle(int[] param)
        {
            this.param = param;
        }

        public override Tuple<double, string> CalcSq()
        {
            bool str = false;
            double p = (param[0] + param[1] + param[2]) / 2;
            double res = Math.Sqrt(p * (p - param[0]) * (p - param[1]) * (p - param[2]));
            double sum, sumTriangleExists;

            foreach (int item in param)
            {
                sum = 0;
                sumTriangleExists = 0;

                List<int> pmsCopy = new List<int>(param);
                pmsCopy.Remove(item);

                foreach (int otherItem in pmsCopy)
                {
                    sum += Math.Pow(otherItem, 2);
                    sumTriangleExists += otherItem;
                }

                if (sumTriangleExists < item)
                {
                    return Tuple.Create(0.0, "N/A");
                }

                if (sum == Math.Pow(item, 2))
                {
                    str = true;
                    break;
                }

            }

            if (str)
            {
                return Tuple.Create(res, "Rectangular Triangle");
            }
            else
            {
                return Tuple.Create(res, "Triangle");
            }

        }

    }
    public class Quadri : Shape
    {
        private int sideA { get; set; }
        private int sideB { get; set; }
        private int sideC { get; set; }
        private int sideD { get; set; }
        public Quadri(int sideA, int sideB, int sideC, int sideD)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
            this.sideD = sideD;
        }

        public override Tuple<double, string> CalcSq()
        {
            double p = (sideA + sideB + sideC + sideD) / 2;
            double res = Math.Sqrt((p - sideA) * (p - sideB) * (p - sideC) * (p - sideD));
            return Tuple.Create(res, "Quadrilateral");
        }
    }
}
