using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Practice
{
    class NotMain
    {
        //private const string on = "Y";
        //private const string off = "N";

        public void Run()
        {
            //AlmostNear

            ////PrintDocument
            //string printerStatus = PrinterCheck().ToUpper();
            ////bool isOn = false;

            //if (printerStatus == on)
            //{
            //    Console.Write("Printer is on");
            //    //return true;
            //}
            //else if (printerStatus == off)    //else if
            //{
            //    Console.Write("Printer is off");
            //    //return false;
            //}
            //else
            //{
            //    Console.Write("Huh?");
            //}
            ////bool print = false;

            //AllowedToParty
            //IsAllowedWithdrawal
            //RollPassGo
            int rollNum = GetPositiveInterger("What did you roll? ");
            Console.WriteLine($"You rolled a {rollNum} ");
            if (rollNum > 7 && rollNum < 12)
            {
                Console.WriteLine("return true");       //actually return later, just testing
            }
            else
            {
                Console.WriteLine("return false");
            }

        }
        //private string PrinterCheck()
        //{
        //    Console.Write("Is the printer on? Y or N: ");
        //    return Console.ReadLine();
        //}

        //public static string GetRequiredString(string prompt)
        //{
        //    string input;

        //    do
        //    {
        //        Console.Write(prompt);
        //        input = Console.ReadLine();
        //    } while (string.IsNullOrEmpty(input));

        //    return input;
        //}

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

        //private bool PrinterValid()
        //{
        //    //test
        //}
    }
}
