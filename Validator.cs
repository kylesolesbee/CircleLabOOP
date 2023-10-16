using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleLabOOP
{
    internal class Validator
    {
        public static double GetValidRadius()
        {
            double radius;
            do
            {
                Console.Write("Enter radius: ");
            } while (!double.TryParse(Console.ReadLine(), out radius) || radius <= 0);
            return radius;
        }

        public static bool ShouldCircleGrow()
        {
            bool isValidResponse = false;
            bool shouldGrow = false;

            do
            {
                Console.Write("Should the circle grow? (y/n): ");
                string response = Console.ReadLine().Trim().ToLower();

                try
                {
                    shouldGrow = GetYesNoResponse(response);
                    isValidResponse = true;
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Invalid input. Please enter 'y' or 'n'.");
                }
            } while (!isValidResponse);

            return shouldGrow;
        }

        private static bool GetYesNoResponse(string response)
        {
            if ("yes".Contains(response.Trim().ToLower()))
            {
                return true;
            }
            else if ("no".Contains(response.Trim().ToLower()))
            {
                return false;
            }
            else
            {
                throw new ArgumentException("Invalid response");
            }
        }
    }
}
