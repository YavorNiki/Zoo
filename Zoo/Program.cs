namespace Zoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Commands: Exit - exit the program; MostVisited - see most visited attractions; SAN + name - Search Attraction by name "
                                + "FAT + type - filter attraction by type;  Printall - print all created attractions; createattr ; createvisitor; createticket");

            string command = Console.ReadLine();
            command = command.ToLower();

            while (command != "exit")
            {
                if (command == "exit")
                {
                    return;
                }
                else if (command == "mostvisited")
                {
                    CommandParser.PrintMostVisited();
                }
                else if (command == "san")
                {
                    CommandParser.SAN(Console.ReadLine());
                }
                else if (command == "fat")
                {
                    string typ = Console.ReadLine();
                    switch (typ)
                    {
                        case "m":
                            CommandParser.FAT(AttractionType.MAMMALS);
                            break;
                        case "b":
                            CommandParser.FAT(AttractionType.BIRDS);
                            break;
                        case "r":
                            CommandParser.FAT(AttractionType.REPTILES);
                            break;
                        case "a":
                            CommandParser.FAT(AttractionType.AQUATIC);
                            break;
                        case "i":
                            CommandParser.FAT(AttractionType.INSECTS);
                            break;
                    }
                }
                else if (command == "printall")
                {
                    CommandParser.PrintAll();
                }
                else if (command == "createattr")
                {
                    CommandParser.CreateAttraction();
                }
                else if (command == "createvisitor")
                {
                    CommandParser.CreateVisitor();
                }
                else if (command == "createticket")
                {
                    CommandParser.CreateTicket();
                }
                else
                {
                    Console.WriteLine("Invalid Command Please Enter a valid One");
                }
                command = Console.ReadLine();
            }
        }
    }
}
