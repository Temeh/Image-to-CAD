using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Image_to_CAD
{
    class Settings
    {
        /// <summary>
        /// How big tolerances in the red colour value is accepted for the background
        /// </summary>
        public byte RedTolerance;
        /// <summary>
        /// How big tolerances in the green colour value is accepted for the background
        /// </summary>
        public byte GreenTolerance;
        /// <summary>
        /// How big tolerances in the blue colour value is accepted for the background
        /// </summary>
        public byte BlueTolerance;
        /// <summary>
        /// The minimum size of an object(in pixels)
        /// </summary>
        public int minimumSizeOfObjects;

        /// <summary>
        /// A method that lets you change the settings
        /// </summary>
        public void Set()
        {
            while (true)
            {
                Console.WriteLine("Listing settings:");
                Console.WriteLine("1. : Red Tolerance: " + RedTolerance);
                Console.WriteLine("2. : Green Tolerance: " + GreenTolerance);
                Console.WriteLine("3. : Blue Tolerance: " + BlueTolerance);
                Console.WriteLine("4. : Minimum size of objects: " + minimumSizeOfObjects);

                Console.WriteLine("\nType in the line number you want to change, or \"r\" to return");
                string input = Console.ReadLine();
                if (input == "1") { Console.WriteLine("Type in the new value for RedTolerance..."); RedTolerance = Convert.ToByte(Console.ReadLine()); Console.WriteLine("RedTolerance updated"); }
                else if (input == "2") { Console.WriteLine("Type in the new value for GreenTolerance..."); GreenTolerance = Convert.ToByte(Console.ReadLine()); Console.WriteLine("GreenTolerance updated"); }
                else if (input == "3") { Console.WriteLine("Type in the new value for BlueTolerance..."); BlueTolerance = Convert.ToByte(Console.ReadLine()); Console.WriteLine("BlueTolerance updated"); }
                else if (input == "4") { Console.WriteLine("Type in the new value for MinimumSizeOfObjects..."); GreenTolerance = Convert.ToByte(Console.ReadLine()); Console.WriteLine("Minimum size updated"); }
                else if (input == "r") { return; }
                else
                {
                    Console.WriteLine("\nDidn't recognize the command.");
                    Console.WriteLine("Lets try again...\n");
                    Console.ReadKey();
                }
            }
        }
    }
}
