using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TurtleCommand
{
    public class Process
    {
        public Simulator Simulation; 
        public bool Placed;
        public string Message = string.Empty;
        public string ErrorInputs = "The inputs in the file are not correctly formatted.";

        public string Start(string[] commands)
        {
            Simulation = new Simulator();
            foreach (string command in commands)
            {
                ProcessCommand(command);
             
                if (Message == ErrorInputs)
                {
                    break;
                }
                if (Message.Length > 1)
                {
                    Console.WriteLine(Message);
                    Message = "";
                }
            }
            return Message;
        }

        public void ProcessCommand(string command)
        {
       
            if (Regex.IsMatch(command, "^MOVE") || Regex.IsMatch(command, "^RIGHT") || Regex.IsMatch(command, "^LEFT"))
            {
                Simulation.TurtleMoves(command.ToLower());
            }
            else if (Regex.IsMatch(command, "^REPORT"))
            {
                Message = Simulation.Report();
            }
            else if (Regex.IsMatch(command, "^PLACE"))
            {
                string[] coordinates = command.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (coordinates.Length == 4)
                {
                    Simulation.Place(Convert.ToInt32( coordinates[1]), Convert.ToInt32(coordinates[2]), coordinates[3]);
                }
                if (Simulation.Turtle == null)
                {
                    Message = ErrorInputs;
                }
            }
            else
            {
                Message = ErrorInputs;
            }
        }
        public bool IsValidLocation(int east, int north) => east >= 0 && east < 5 && north >= 0 && north < 5;
    }
}
