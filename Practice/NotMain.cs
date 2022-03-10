using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Practice
{
    class NotMain
    {
        private const string on = "Y";
        private const string off = "N";

        public void Run()
        {
            //AlmostNear
            //PrintDocument
            bool print = true;


            string printerStatus = PrinterCheck().ToUpper();

            //while printer is off
            if (printerStatus == on)
            {
                Console.Write("Printer is on");
            }
            else if (printerStatus == off)
            {
                Console.Write("Printer is off");
                //return false;
            }
            else
            {
                Console.Write("Huh?");
            }
            //AllowedToParty
            //IsAllowedWithdrawal
            //RollPassGo
        }
        private string PrinterCheck()
        {
            Console.Write("Is the printer on? Y or N: ");
            return Console.ReadLine();
        }
    }
}
