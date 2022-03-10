using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
    class GetPositiveInteger
    {
        public static int GetPositiveInterger(string prompt)
        {
            bool validPosInt = false;
            int value;

            do
            {
                Console.Write(prompt);
                if (!int.TryParse(Console.ReadLine(), out value))
                {
                    Console.WriteLine("That wasn't a number");
                }
                else
                {
                    if (value > 0)
                    {
                        validPosInt = true;
                    }
                    else
                    {
                        Console.WriteLine("Value must be positive");
                    }
                }
            } while (!validPosInt);
            return value;
        }
    }
}
