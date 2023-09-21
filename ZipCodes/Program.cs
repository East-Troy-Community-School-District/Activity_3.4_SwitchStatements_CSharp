/*
 * Zip Codes
 * Pawelski
 * 9/21/2023
 * Developing Desktop Applications
 * 
 * Instructions:
 * Before running the program, predict what it will do. Then
 * run the program to check your prediction. Were you correct?
 * 
 * Next, modify the program so that it displays "Eagle" when the
 * zip code 53119 is entered into the program.
 * 
 * Next, modify the program so that it displays "Unrecognized zip
 * code." when any other zip code is entered into the program.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZipCodes
{
    class Program
    {
        static void Main(string[] args)
        {
            int zip;
            Console.Write("Enter the zip code you wish to look up >> ");
            zip = Convert.ToInt32(Console.ReadLine());

            switch(zip)
            {
                case 53120:
                    Console.WriteLine("East Troy");
                    break;
                case 53149:
                    Console.WriteLine("Mukwonago");
                    break;
                case 53190:
                    Console.WriteLine("Whitewater");
                    break;
            }
        }
    }
}
