using System;

namespace DotNet_store
{
    public class Topic19
    {
        public void Entry()
        {
            CommandLineParser.ParseCommandLine(new string[] { "new" });
        }

    }

    // CommandLine is nested within CommandLineParser
    class CommandLineParser
    {
        private readonly string privateFiled = "Private Field";

        // Define a nested class for processing the command line.                        
        private class CommandLine
        {
            public CommandLine(string[] arguments,CommandLineParser commandLineParser)
            {
                //just for demonstration purpose. nested class can access containing class private field
                Console.WriteLine(commandLineParser.privateFiled);

                for (int argumentCounter = 0; argumentCounter < arguments.Length; argumentCounter++)
                {
                    switch (argumentCounter)
                    {
                        case 0:
                            Action = arguments[0].ToLower();
                            break;
                        case 1:
                            Id = arguments[1];
                            break;
                        case 2:
                            FirstName = arguments[2];
                            break;
                        case 3:
                            LastName = arguments[3];
                            break;
                    }
                }
            }
            public string Action;
            public string Id;
            public string FirstName;
            public string LastName;
        }

        public static void ParseCommandLine(string[] args)
        {
            CommandLine commandLine = new CommandLine(args,new CommandLineParser());

            switch (commandLine.Action)
            {
                case "new":
                    // Create a new employee
                    Console.WriteLine("Creating new employee");
                    break;
                case "update":
                    // Update an existing employee's data
                    // ...
                    break;
                case "delete":
                    // Remove an existing employee's file.
                    // ...
                    break;
                default:
                    Console.WriteLine(
                        "Employee.exe " +
                 "new|update|delete <id> [firstname] [lastname]");
                    break;
            }
        }
    }
}
