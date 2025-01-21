using System.Data;

namespace Zoo
{
    public class CommandParser
    {
        static List<CommandType> history = new();

        public static void PrintMostVisited()
        {
            AnimalAttraction.MostVisitedAtt();
        }

        public static void SAN(string name)
        {
            AnimalAttraction.SearchByName(name);
        }
        public static void FAT(AttractionType type)
        {
            AnimalAttraction.FilterByType(type);
        }
        public static void PrintAll()
        {
            foreach (AnimalAttraction attr in AnimalAttraction.AllAttractions)
            {
                Console.WriteLine(attr.ToString());
            }
        }
        public static void CreateAttraction()
        {
            int id = int.Parse(Console.ReadLine());
            string name = Console.ReadLine();
            string location = Console.ReadLine();
            string description = Console.ReadLine();
            AttractionType type;

            string type1 = Console.ReadLine().ToLower();
            switch (type1)
            {
                case "m":
                    type = AttractionType.MAMMALS;
                    break;
                case "r":
                    type = AttractionType.REPTILES;
                    break;
                case "b":
                    type = AttractionType.BIRDS;
                    break;
                case "a":
                    type = AttractionType.AQUATIC;
                    break;
                case "i":
                    type = AttractionType.INSECTS;
                    break;
                default:
                    type = AttractionType.MAMMALS;
                    break;
            }
            AnimalAttraction a = new AnimalAttraction(id, name, location, description, type);
        }
        public static void CreateVisitor()
        {
            int id = int.Parse(Console.ReadLine());
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            VisitorType type;

            string type1 = Console.ReadLine().ToLower();
            switch (type1)
            {
                case "s":
                    type = VisitorType.STUDENT;
                    break;
                case "c":
                    type = VisitorType.CHILD;
                    break;
                default:
                    type = VisitorType.ADULT;
                    break;
            }
            Visitor a = new Visitor(id, name, age, type);
        }
        public static void CreateTicket()
        {
            string attraction = Console.ReadLine();
            int id = int.Parse(Console.ReadLine());
            TicketType type;
            string type1 = Console.ReadLine().ToLower();
            switch (type1)
            {
                case "s":
                    type = TicketType.STUDENT_TICKET;
                    break;
                case "c":
                    type = TicketType.CHILD_TICKET;
                    break;
                default:
                    type = TicketType.ADULT_TICKET;
                    break;
            }
            Ticket t = new Ticket(attraction, id, type);
        }
    }
}
