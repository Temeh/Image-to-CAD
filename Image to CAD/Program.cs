using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Image_to_CAD
{
    class Program
    {
        static void Main(string[] args)
        {
            Settings settings = new Settings();
            Console.WriteLine("Hello. Starting program.");
            Console.WriteLine(".");
            while (true)
            {
                Console.WriteLine("type \"s\" key for settings, or \"1\" to convert image.");
                string c = Console.ReadLine();
                if (c == "s") settings.Set(); //opens the settings to view/change them
                else if (c == "1")
                {
                    Console.WriteLine("type in path to folder with images");
                    string path = Console.ReadLine();
                    Console.WriteLine("Starting job...");
                    Worker worker = new Worker(path, settings); // starts working on the images in the spesified path

                    Console.WriteLine("Job completed?");
                    Console.ReadLine();
                }
                else if (c == "exit") ; //exit application
            }
        }
    }
}
