﻿namespace Zoo
{
    public class CommandParser
    {
        public static void PrintMenu()
        {
            Console.WriteLine("\n================ Zoo Attraction Management =================");
            Console.WriteLine("Commands:");
            Console.WriteLine("  mostvisited      - See the most visited attractions");
            Console.WriteLine("  visitattr        - a visitor visits an attraction");
            Console.WriteLine("  san <name>       - Search Attraction by name");
            Console.WriteLine("  fat <type>       - Filter attractions by type");
            Console.WriteLine("  printallattr     - Print all created attractions");
            Console.WriteLine("  printallvisitors - Print all created visitors");
            Console.WriteLine("  printalltickets  - Print all created tickets");
            Console.WriteLine("  createattr       - Create a new attraction");
            Console.WriteLine("  createvisitor    - Create a new visitor");
            Console.WriteLine("  createticket     - Create a new ticket");
            Console.WriteLine("  attrbyID         - search a attraction by id");
            Console.WriteLine("  visitorbyID      - search a visitor by id");
            Console.WriteLine("  ticketbyID       - search a visitor by id");
            Console.WriteLine("  feed             - feed a little cute animal");
            Console.WriteLine("  buyIC            - By some tasty ice cream:)");
            Console.WriteLine("  randomfact       - Gives a random animal fact");
            Console.WriteLine("  fun              - Play a fun little game:)");
            Console.WriteLine("  exit             - Exit the program");
            Console.WriteLine("==========================================================\n");
        }
        public static void PrintMostVisited()
        {
            AnimalAttraction.MostVisitedAtt();
        }

        public static void SearchByName(string name)
        {
            var attraction = AnimalAttraction.SearchByName(name);
            if (attraction != null)
            {
                Console.WriteLine(attraction);
            }
            else
            {
                Console.WriteLine($"No attraction found with the name \"{name}\".");
            }
        }

        public static void FilterByType(AttractionType type)
        {
            Console.WriteLine($"The attractions of type {type} are:");
            AnimalAttraction.FilterByType(type);
        }

        public static void PrintAllAttr()
        {
            Console.WriteLine("\nAll Attractions:");
            foreach (AnimalAttraction attr in AnimalAttraction.AllAttractions)
            {
                Console.WriteLine(attr);
            }
        }
        public static void PrintAllVisitors()
        {
            Console.WriteLine("\nAll Visitors:");
            foreach (Visitor vis in Visitor.AllVisitors)
            {
                Console.WriteLine(vis);
            }
        }
        public static void PrintAllTickets()
        {
            Console.WriteLine("\nAll Tickets:");
            foreach (Ticket ticket in Ticket.AllTickets)
            {
                Console.WriteLine(ticket);
            }
        }

        public static void CreateAttraction()
        {
            Console.WriteLine("\nCreating a new attraction. Please provide the following details:");


            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Location: ");
            string location = Console.ReadLine();

            Console.Write("Description: ");
            string description = Console.ReadLine();

            Console.WriteLine("Type (m - Mammals, r - Reptiles, b - Birds, a - Aquatic, i - Insects): ");
            string typeInput = Console.ReadLine().ToLower();

            AttractionType type;
            switch (typeInput)
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
                    Console.WriteLine("Invalid type. Attraction not created.");
                    return;
            }

            AnimalAttraction newAttraction = new AnimalAttraction(name, location, description, type);
            Console.WriteLine("Attraction created successfully!\n" + newAttraction);
        }

        public static void CreateVisitor()
        {
            Console.WriteLine("\nCreating a new visitor. Please provide the following details:");

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Age: ");
            if (!int.TryParse(Console.ReadLine(), out int age))
            {
                Console.WriteLine("Invalid input. Age must be a number.");
                return;
            }

            Console.WriteLine("Type (s - Student, c - Child, a - Adult): ");
            string typeInput = Console.ReadLine().ToLower();

            VisitorType type;
            switch (typeInput)
            {
                case "s":
                    type = VisitorType.STUDENT;
                    break;
                case "c":
                    type = VisitorType.CHILD;
                    break;
                case "a":
                    type = VisitorType.ADULT;
                    break;
                default:
                    Console.WriteLine("Invalid type. Visitor not created.");
                    return;
            }

            Visitor newVisitor = new Visitor(name, age, type);
            Console.WriteLine("Visitor created successfully!\n" + newVisitor);
        }

        public static void CreateTicket()
        {
            Console.WriteLine("\nCreating a new ticket. Please provide the following details:");

            Console.Write("Ticket Name: ");
            string attraction = Console.ReadLine();


            Console.WriteLine("Type (s - Student Ticket, c - Child Ticket, a - Adult Ticket): ");
            string typeInput = Console.ReadLine().ToLower();

            TicketType type;
            switch (typeInput)
            {
                case "s":
                    type = TicketType.STUDENT_TICKET;
                    break;
                case "c":
                    type = TicketType.CHILD_TICKET;
                    break;
                case "a":
                    type = TicketType.ADULT_TICKET;
                    break;
                default:
                    Console.WriteLine("Invalid type. Ticket not created.");
                    return;
            }

            Ticket newTicket = new Ticket(attraction, type);
            Console.WriteLine("Ticket created successfully!\n" + newTicket);
        }

        public static void SearchAttrByID()
        {
            Console.WriteLine("Enter attraction's ID: ");

            try
            {
                int id = int.Parse(Console.ReadLine());
                var attraction = AnimalAttraction.SearchByID(id);

                if (attraction != null)
                {
                    Console.WriteLine(attraction.ToString());
                }
                else
                {
                    Console.WriteLine("No attraction found with this ID.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid ID entered. Please enter a valid number.");
            }
            catch (Exception)
            {
                Console.WriteLine("An error occurred while searching for the attraction.");
            }

        }
        public static void SearchVisitorByID()
        {
            Console.WriteLine("Enter visitor's ID: ");

            try
            {
                int id = int.Parse(Console.ReadLine());
                var vis = Visitor.SearchByID(id);

                if (vis != null)
                {
                    Console.WriteLine(vis.ToString());
                }
                else
                {
                    Console.WriteLine("No visitor found with this ID.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid ID entered. Please enter a valid number.");
            }
            catch (Exception)
            {
                Console.WriteLine("An error occurred while searching for the visitor.");
            }

        }
        public static void SearchTicketByID()
        {
            Console.WriteLine("Enter ticket's ID: ");

            try
            {
                int id = int.Parse(Console.ReadLine());
                var tic = Ticket.SearchByID(id);

                if (tic != null)
                {
                    Console.WriteLine(tic.ToString());
                }
                else
                {
                    Console.WriteLine("No ticket found with this ID.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid ID entered. Please enter a valid number.");
            }
            catch (Exception)
            {
                Console.WriteLine("An error occurred while searching for the ticket.");
            }

        }
        public static void VisitAttraction()
        {
            Console.Write("Enter visitor ID:");
            int visID = int.Parse(Console.ReadLine());

            Console.Write("Enter attraction ID:");
            int attrID = int.Parse(Console.ReadLine());

            Visitor.VisitAttraction(Visitor.SearchByID(visID), AnimalAttraction.SearchByID(attrID));

            Console.WriteLine($"Visitor {Visitor.SearchByID(visID).Name} visited attraction {AnimalAttraction.SearchByID(attrID).Name}");
        }
        public static void BuyIceCream()
        {
            Console.Write("Enter the ID of the visitor that you want to buy Ice Cream for: ");
            int id = int.Parse(Console.ReadLine());
            if (Visitor.SearchByID(id) == null)
            {
                Console.WriteLine("No visitor found with this ID, try again!");
                return;
            }


            Console.Write("Do you want Strawberry, Chocolate or Vanilla Ice Cream?: ");
            string type = Console.ReadLine().ToLower();
            IceCreamType ictype;

            switch (type)
            {
                case "strawberry":
                    ictype = IceCreamType.strawberry; break;
                case "chocolate":
                    ictype = IceCreamType.chocolate; break;
                case "vanilla":
                    ictype = IceCreamType.vanilla; break;
                default:
                    Console.WriteLine("We don't have such flavour, please try again!");
                    return;
            }

            IceCream.BuyIceCream(Visitor.SearchByID(id), ictype);
            Console.WriteLine($"Mmmm {Visitor.SearchByID(id).Name} bought some delicious {type} Ice cream, and his total spend now is: {Visitor.SearchByID(id).Totalspend:F2}$");

        }
        public static void RussianRoulette()
        {
            Console.WriteLine("\t WELCOME TO RUSSIAN ROLLETE WOHOOOO    \n\n");
            bool playAgain = true;
            Random random = new Random();
            int compNumber = random.Next(1, 7);

            while (playAgain)
            {
                Console.Write("Enter a number from 1 - 6: ");
                int myNumber = Convert.ToInt32(Console.ReadLine());

                if (myNumber == compNumber)
                {
                    Console.WriteLine("YOU DIED");
                    Console.WriteLine(@"
                    _______
                   /       \
                  |         |
                  |   X X   |
                  |    |    |
                  |   / \   |
                  |_________|
                   /     \
                  /       \
                 /_________\
                        ");
                    // compNumber = random.Next(1, 7);
                }
                else
                {
                    Console.WriteLine("You survived!");
                }
                Console.WriteLine("Do you want to play again Y/N");
                string answer = Console.ReadLine();
                answer = answer.ToUpper();

                if (answer == "Y")
                {
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                    Console.WriteLine("Thanks for playing");
                }

            }
        }
        public static void FunGame()
        {
            Console.WriteLine("\t WELCOME TO RUSSIAN ROLLETE WOHOOOO    \n\n");
            Random random = new Random();
            int compNumber = random.Next(1, 7);


            Console.Write("Enter a number from 1 - 6: ");
            int myNumber = Convert.ToInt32(Console.ReadLine());

            if (myNumber == compNumber)
            {
                Console.WriteLine("YOU DIED");
                Console.WriteLine(@"
                    _______
                   /       \
                  |         |
                  |   X X   |
                  |    |    |
                  |   / \   |
                  |_________|
                   /     \
                  /       \
                 /_________\
                        ");
            }
            else
            {
                Console.WriteLine("You survived!");
            }

        }
        public static void FeedAnAnimal()
        {
            Console.WriteLine("Write the name of the animal, you would like to feed:");
            string name = Console.ReadLine();

            Console.WriteLine($"The animal {AnimalAttraction.SearchByName(name).Name} in {AnimalAttraction.SearchByName(name).Location} is currently beeing fed by you \n and is very happy:)");
        }
        public static void GetAnimalFact()
        {
            Random random = new();
            int index = random.Next(animalFacts.Length);
            Console.WriteLine("You random fact is:) -> \n" + animalFacts[index]);
        }

        private static string[] animalFacts = new string[]
        {
                "Elephants can recognize themselves in mirrors.",
                "A group of lions is called a pride.",
                "Dolphins have been shown to use tools like sponges to forage for food.",
                "The peregrine falcon is the fastest bird, capable of diving at speeds of up to 240 mph.",
                "Some parrots can live over 80 years.",
                "Owls can rotate their heads up to 270 degrees.",
                "The green sea turtle can hold its breath for hours while resting underwater.",
                "Crocodiles are one of the few reptiles that care for their young.",
                "Chameleons can move their eyes independently of each other.",
                "Octopuses have three hearts and blue blood.",
                "Whales are the largest mammals on Earth, with the blue whale reaching up to 100 feet in length.",
                "Jellyfish have been around for over 500 million years.",
                "Ants can lift objects up to 50 times their own body weight.",
                "Dragonflies are expert fliers, capable of hovering and even flying backward.",
                "Honeybees communicate with each other through dance."
        };
    }
}