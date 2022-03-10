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
            int rollNum = GetPositiveInteger.GetPositiveInterger("What did you roll? ");
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

        //private bool PrinterValid()
        //{
        //    //test
        //}
    }
}
