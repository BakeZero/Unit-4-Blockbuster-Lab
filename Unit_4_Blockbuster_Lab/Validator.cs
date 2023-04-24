using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_4_Blockbuster_Lab
{
    internal static class Validator
    {
        public static int GetNumberMovie(int lower, int upper)
        {
            try
            {
                Console.Write($"Which movie would you like to watch? ({lower}-{upper}): ");
                int input = int.Parse(Console.ReadLine());
                return input >= lower && input <= upper ? input : GetNumberMovie(lower, upper);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Invalid input.");
                return GetNumberMovie(lower, upper);
            }
        }

        public static int GetNumberScene(int lower, int upper)
        {
            try
            {
                Console.Write($"Which scene would you like to watch? ({lower}-{upper}): ");
                int input = int.Parse(Console.ReadLine());
                return input >= lower && input <= upper ? input : GetNumberScene(lower, upper);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Invalid input.");
                return GetNumberScene(lower, upper);
            }
        }
    }
}
