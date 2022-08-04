using System;
using Core;
using System.Collections.Generic;

namespace SQCalc
{
    class Program
    {
        static void Main(string[] args)
        {

            string input;
            int counter;
            bool cont = true, enter;
            List<int> parameters = new List<int>();

            Console.WriteLine((5 + 5 + 1) / 2);

            while(cont)
            {

                counter = 1;
                parameters.Clear();

                Console.WriteLine("Enter known values (enter '0' to finish entry, enter q to quit): ");

                enter = true;

                while (enter)
                {
                    Console.WriteLine("Value " + counter + ":");
                    input = Console.ReadLine();

                    if(Int32.Parse(input) == 0)
                    {
                        enter = false;
                        break;
                    }
                    parameters.Add(Int32.Parse(input));
                    counter++;
                }



                Console.WriteLine(CollectAnswer(parameters.ToArray()));

            }
        }

        static string CollectAnswer(int[] parameters)
        {
            string phrase = "";
            Tuple<double, string> result;

            switch (parameters.Length)
            {
                case 0:
                    phrase = "Nothing entered.";
                    break;
                case 1:
                    result = new Circle(parameters[0]).CalcSq();
                    phrase = "Square of " + result.Item2 + " : " + result.Item1;
                    break;
                case 3:
                    result = new Triangle(parameters).CalcSq();

                    if (result.Item2 == "NE")
                    {
                        phrase = "Triangle with specified values cannot exist";
                    }
                    else
                    {
                        phrase = "Square of " + result.Item2 + " : " + result.Item1;
                    }

                    break;
                default:
                    phrase = "Enter known values (enter '0' to finish entry): ";
                    break;
            }
            return phrase;
        }

    }
}
