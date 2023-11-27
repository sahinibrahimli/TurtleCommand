using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TurtleCommand
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            MainProgram main = new MainProgram();
            string[] commands = File.ReadAllLines("TurtleCommand.txt");

            foreach (var command in commands)
            {
                Console.WriteLine(command);
            }

            Console.WriteLine("--------------------------------");
            Console.WriteLine(main.MakeAction(commands));
            Console.ReadKey();
        }

        public string MakeAction(string[] commands)
        {
            string message = "";
            Process act = new Process();
            message = act.Start(commands);
            return message;
        }
    }
}
