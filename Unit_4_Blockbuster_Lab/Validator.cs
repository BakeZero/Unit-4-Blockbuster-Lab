using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_4_Blockbuster_Lab
{
    internal static class Validator
    {

        public static int GetNumber(int lower, int upper, string arg)
        {
            try
            {
                Console.Write($"{arg} ({lower}-{upper}): ");
                int input = int.Parse(Console.ReadLine());
                return input >= lower && input <= upper ? input : GetNumber(lower, upper, arg);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Invalid input.");
                return GetNumber(lower, upper, arg);
            }
        }
    }
}
