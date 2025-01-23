using Zoo;

internal class Program
{
    static void Main(string[] args)
    {
        CommandParser.PrintMenu();

        string command = Console.ReadLine()?.ToLower();

        while (command != "exit")
        {
            switch (command)
            {
                case "mostvisited":
                    CommandParser.PrintMostVisited();
                    break;
                case "san":
                    Console.Write("Enter attraction name: ");
                    string name = Console.ReadLine();
                    CommandParser.SearchByName(name);
                    break;
                case "fat":
                    Console.WriteLine("Enter type (m, b, r, a, i): ");
                    string typeInput = Console.ReadLine().ToLower();
                    AttractionType type = typeInput switch
                    {
                        "m" => AttractionType.MAMMALS,
                        "b" => AttractionType.BIRDS,
                        "r" => AttractionType.REPTILES,
                        "a" => AttractionType.AQUATIC,
                        "i" => AttractionType.INSECTS,
                        _ => throw new InvalidOperationException("Invalid type.")
                    };
                    CommandParser.FilterByType(type);
                    break;
                case "printallattr":
                    CommandParser.PrintAllAttr();
                    break;
                case "printallvisitors":
                    CommandParser.PrintAllVisitors();
                    break;
                case "printalltickets":
                    CommandParser.PrintAllTickets();
                    break;
                case "createattr":
                    CommandParser.CreateAttraction();
                    break;
                case "createvisitor":
                    CommandParser.CreateVisitor();
                    break;
                case "createticket":
                    CommandParser.CreateTicket();
                    break;
                case "visitattr":
                    CommandParser.VisitAttraction();
                    break;
                case "randomfact":
                    CommandParser.GetAnimalFact();
                    break;
                case "feed":
                    CommandParser.FeedAnAnimal();
                    break;
                case "fun":
                    CommandParser.RussianRoulette();
                    break;
                case "attrbyid":
                    CommandParser.SearchAttrByID();
                    break;
                case "visitorbyid":
                    CommandParser.SearchVisitorByID();
                    break;
                case "ticketbyid":
                    CommandParser.SearchTicketByID();
                    break;
                default:
                    Console.WriteLine("Invalid command. NOW you have to play a little game before you go on \n");
                    CommandParser.FunGame();
                    break;
            }

            CommandParser.PrintMenu();
            command = Console.ReadLine().ToLower();
        }

        Console.WriteLine("Goodbye!");
        Console.ReadKey();
    }
}

