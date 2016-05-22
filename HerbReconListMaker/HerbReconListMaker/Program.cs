using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using HerbLib;
using Newtonsoft.Json;

namespace HerbReconListMaker
{
    internal class Program
    {
        [STAThread]
        private static void Main(string[] args)
        {
            while (true)
            {
                Console.Write(">");
                var input = Console.ReadLine();
                if (string.IsNullOrEmpty(input)) continue;
                var split = input.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                if (split.Length == 0) continue;
                var command = split[0].ToLower();
                var parameters = split.Skip(1).ToArray();
                if (command == "exit") break;
                switch (command)
                {
                    case "help":
                        Console.WriteLine("exit - exits the application");
                        Console.WriteLine("fetch - creates the object of herbs, pulled from the file in the parameter");
                        Console.WriteLine("check - opens a GUI which enables you to check the correctness of the data");
                        Console.WriteLine("help - shows this help");
                        break;
                    case "fetch":
                        if (parameters.Length < 1)
                        {
                            Console.WriteLine("You have to pass a file as the parameter");
                            break;
                        }
                        Fetch(parameters[0]);
                        break;
                    case "check":
                        if (parameters.Length < 1) {
                            Console.WriteLine("You have to pass a file as the parameter");
                            break;
                        }
                        Check(parameters[0]);
                        break;
                    default:
                        Console.WriteLine("No command found. Use 'help'");
                        break;
                }
            }
        }

        private static void Fetch(string path)
        {
            if (!File.Exists(path)) {
                Console.WriteLine("File not found.");
                return;
            }
            var sr = new StreamReader(path);
            while (!sr.EndOfStream)
            {
                var wholeName = sr.ReadLine();
            }
        }

        private static void Check(string path)
        {
            if (!File.Exists(path))
            {
                Console.WriteLine("File not found.");
                return;
            }
            Application.EnableVisualStyles();
            Application.Run(new HerbChecker(JsonConvert.DeserializeObject<HerbCollection>(File.ReadAllText(path))));
        }
    }
}