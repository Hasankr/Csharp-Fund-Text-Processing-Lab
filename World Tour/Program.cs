using System;

namespace World_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            string stops = Console.ReadLine();
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Travel")
                {
                    break;
                }
                string[] tokens = command.Split(':');
                string action = tokens[0];
                switch (action)
                {
                    case "Add Stop":
                        int index = int.Parse(tokens[1]);
                        string newStop = tokens[2];
                        if (index >= 0 && index < stops.Length)
                        {
                            stops = stops.Insert(index, newStop);
                        }
                        Console.WriteLine(stops);
                        break;
                    case "Remove Stop":
                        int startIndex = int.Parse(tokens[1]);
                        int endIndex = int.Parse(tokens[2]);
                        if (startIndex >= 0 && startIndex < stops.Length && endIndex >= 0 && endIndex < stops.Length)
                        {
                            stops = stops.Remove(startIndex, endIndex - startIndex + 1);
                        }
                        Console.WriteLine(stops);
                        break;
                    case "Switch":
                        string oldStop = tokens[1];
                        string newStopp = tokens[2];
                        if (stops.Contains(oldStop))
                        {
                            stops = stops.Replace(oldStop, newStopp);
                        }
                        Console.WriteLine(stops);
                        break;
                }
            }
            Console.WriteLine($"Ready for world tour! Planned stops: {stops}");
        }
    }
}
