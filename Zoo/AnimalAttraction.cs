public class AnimalAttraction
{
    private int id;
    private string name;
    private string location;
    private string description;
    private AttractionType type;

    public int Id { get => id; set => id = value; }
    public string Name { get => name; set => name = value; }
    public string Location { get => location; set => location = value; }
    public string Description { get => Description; set => Description = value; }
    public AttractionType Type { get => type; set => type = value; }
    public static List<AnimalAttraction> TotalVisits { get => totalVisits; set => totalVisits = value; }

    private static List<AnimalAttraction> allAttractions = new List<AnimalAttraction>();

    private static List<AnimalAttraction> totalVisits = new List<AnimalAttraction>();



    public AnimalAttraction(int id, string name, string location,
        string description, AttractionType type)
    {
        this.Id = id;
        this.Name = name;
        this.Location = location;
        this.Description = description;
        this.Type = type;
        allAttractions.Add(this);
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
    public AnimalAttraction SearchByName(string name)
    {
        foreach (AnimalAttraction attr in allAttractions)
        {
            if (name == attr.name)
                return attr;
        }
        return null;
    }
    public void FilterByType(AttractionType type)
    {
        Console.Write($"The Attractions form type {type} are: ");

        foreach (AnimalAttraction attr in allAttractions)
        {
            if (attr.type == type)
            {
                Console.WriteLine(attr.name + ", ");
            }
        }
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
        return $"Attraction№{Id} is {Name} in {Location}: \n{Description}.";
    }

}
public enum AttractionType
{ MAMMALS = 20, BIRDS = 15, REPTILES = 10, AQUATIC = 25, INSECTS = 5 }

