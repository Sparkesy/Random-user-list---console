using System;
using System.Collections.Generic;

namespace Usernamelist
{
    class Program
    {
        static void Main(string[] args)
        {
            // welcome the user
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Welcome to the random name chooser!!!");
            Console.WriteLine();
            Console.WriteLine("Press any key to begin");
            Console.ReadKey();
            randomlist();
        }
        private static void randomlist()
        {
            Console.Clear();
            try
            {
                // create a list of students
                List<string> students = new List<string>();

                // ask user to input students
                do
                {
                    Console.Clear();
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("Enter student name: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    // grab input
                    string name = Console.ReadLine();

                    //check see if we already have that name
                    if (students.Contains(name))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("name has already been added.Names must be unique.");
                        //if we don't add to the collection
                    }
                    else students.Add(name);
                    // more students?
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("Add another? Press 'y' or any other key to proceed: ");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                // loop
                while (Console.ReadKey().KeyChar == 'y');

                //clear console
                Console.Clear();
                //create a Random object
                Random rnd = new Random();
                // start rnd loop

                // get the index of the student to choose
                // use list. count to get length of the list
                int chosen = rnd.Next(0, students.Count);
                // display result
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("The lucky person is: ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(students[chosen]);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                again();
            }
            catch (Exception e)
            {
                Console.Clear();
                // output an error nessage
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error! " + e.Message);
                Console.ReadKey();
                again();
            }
        }
        private static void again()
        {
            Console.Clear();
            Console.WriteLine("if you wish to rerun the program press 'y' otherwise press 'n' to exit.");
            string usercommand = Console.ReadLine().ToLower();
            if (usercommand == "y")
            {

                randomlist();

            }
            else if (usercommand == "n")
            {
                exit();
            }
        }

        private static void exit()
        {
            Console.Clear();
            Console.WriteLine("Thank you for using my program");
            Console.WriteLine("Find more interesting projects at my GitHub Repository: bit.ly/2YDCMYQ ");
            Console.WriteLine();
            Console.WriteLine("Program Developed by Jordan W Sparkes");
            Console.WriteLine("Program Developed using Visual Studio 2019 Community Edition");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}