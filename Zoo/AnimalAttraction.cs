using Zoo;

public class AnimalAttraction : Ids, ISearchById<AnimalAttraction>
{
    private string name;
    private string location;
    private string description;
    private AttractionType type;

    public string Name { get => name; set => name = value; }
    public string Location { get => location; set => location = value; }
    public string Description { get => description; set => description = value; }
    public AttractionType Type { get => type; set => type = value; }
    public static List<AnimalAttraction> TotalVisits { get => totalVisits; set => totalVisits = value; }
    public static List<AnimalAttraction> AllAttractions { get => allAttractions; set => allAttractions = value; }

    private static List<AnimalAttraction> allAttractions = new List<AnimalAttraction>();

    public static List<AnimalAttraction> totalVisits = new List<AnimalAttraction>();



    public AnimalAttraction(string name, string location,
        string description, AttractionType type)
    {
        this.Name = name;
        this.Location = location;
        this.Description = description;
        this.Type = type;
        AllAttractions.Add(this);
    }

    public double getTicketPrice(TicketType ticketType)
    {
        switch (ticketType)
        {
            case TicketType.STUDENT_TICKET:
                return 0.6;
            case TicketType.CHILD_TICKET:
                return 0.4;
            case TicketType.ADULT_TICKET:
                return 1.0;
            default:
                return 1.0;
        }
    }
    public static AnimalAttraction SearchByID(int id)
    {
        foreach (AnimalAttraction attr in AllAttractions)
        {
            if (attr.Id == id)
                return attr;
        }
        return null;
    }

    public static AnimalAttraction SearchByName(string name)
    {
        foreach (AnimalAttraction attr in AllAttractions)
        {
            if (name.Equals(attr.name, StringComparison.OrdinalIgnoreCase))
                return attr;
        }
        return null;
    }
    public static void FilterByType(AttractionType type)
    {
        Console.Write($"The Attractions form type {type} are: ");

        foreach (AnimalAttraction attr in AllAttractions)
        {
            if (attr.type == type)
            {
                Console.Write(attr.name + ", ");
            }
        }
        Console.WriteLine();

    }
    public double GetAttractionPrice(Ticket ticket)
    {
        double k = getTicketPrice(ticket.Type);
        switch (Type)
        {
            case AttractionType.MAMMALS:
                return k * 20;
            case AttractionType.BIRDS:
                return k * 15;
            case AttractionType.REPTILES:
                return k * 10;
            case AttractionType.AQUATIC:
                return k * 25;
            case AttractionType.INSECTS:
                return k * 5;
            default:
                return 20;

        }
    }
    public override string ToString()
    {
        return $"Attraction with id: {Id} is {Name} in {Location}: \n{Description}.";
    }
    public static void MostVisitedAtt()
    {
        int mammal = 0;
        int birds = 0;
        int reptitles = 0;
        int aquatic = 0;
        int insects = 0;
        foreach (AnimalAttraction attr in totalVisits)
        {
            switch (attr.type)
            {
                case AttractionType.MAMMALS:
                    mammal++;
                    break;
                case AttractionType.BIRDS:
                    birds++;
                    break;
                case AttractionType.REPTILES:
                    reptitles++;
                    break;
                case AttractionType.AQUATIC:
                    aquatic++;
                    break;
                case AttractionType.INSECTS:
                    insects++;
                    break;
            }
        }
        int mostVisits = Math.Max(Math.Max(Math.Max(mammal, reptitles), birds), Math.Max(aquatic, insects));
        Console.WriteLine($"Most visits is: {mostVisits}");

        if (mostVisits == mammal)
        {
            Console.WriteLine("The most visited is the Mammal!");
        }
        if (mostVisits == birds)
        {
            Console.WriteLine("The most visited is the Bird!");
        }
        if (mostVisits == reptitles)
        {
            Console.WriteLine("The most visited is the Reptile!");
        }
        if (mostVisits == aquatic)
        {
            Console.WriteLine("The most visited is the Aquatic!");
        }
        if (mostVisits == insects)
        {
            Console.WriteLine("The most visited is the Insect!");
        }
    }
}
public enum AttractionType
{ MAMMALS = 20, BIRDS = 15, REPTILES = 10, AQUATIC = 25, INSECTS = 5 }

