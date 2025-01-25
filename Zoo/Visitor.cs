using Zoo;

public class Visitor : Ids, ISearchById<Visitor>
{

    private string name;
    private int age;
    private VisitorType type;
    private List<AnimalAttraction> visitedAttractions = new List<AnimalAttraction>();

    public string Name { get => name; set => name = value; }
    public int Age { get => age; set => age = value; }
    public VisitorType Type { get => type; set => type = value; }
    private double totalspend;
    private static List<Visitor> allVisitors = new List<Visitor>();

    public List<AnimalAttraction> VisitedAttractions
    {
        get => visitedAttractions;
        set => visitedAttractions = value;
    }
    public double Totalspend { get => totalspend; set => totalspend = value; }
    public static List<Visitor> AllVisitors { get => allVisitors; set => allVisitors = value; }

    public Visitor(string name, int age, VisitorType type)
    {
        this.Name = name;
        this.Age = age;
        this.Type = type;
        totalspend = 0;
        allVisitors.Add(this);

    }
    public static Visitor SearchByID(int id)
    {
        foreach (Visitor vis in AllVisitors)
        {
            if (id == vis.Id)
            {
                return vis;
            }

        }
        return null;
    }
    public static void VisitAttraction(Visitor visitor, AnimalAttraction attraction)
    {

        TicketType ticketType = visitor.Type switch
        {
            VisitorType.ADULT => TicketType.ADULT_TICKET,
            VisitorType.CHILD => TicketType.CHILD_TICKET,
            VisitorType.STUDENT => TicketType.STUDENT_TICKET,
            _ => TicketType.ADULT_TICKET
        };

        Ticket ticket = new Ticket(attraction.Name, ticketType);

        double price = attraction.GetAttractionPrice(ticket);

        visitor.VisitedAttractions.Add(attraction);

        visitor.Totalspend += price;

        AnimalAttraction.TotalVisits.Add(attraction);

        Console.WriteLine($"{visitor.Name} visited {attraction.Name} for {price:F2}$.");
    }
    public override string ToString()
    {
        return $"{Name}(with id:{Id}) is a/an {Type}({Age}).";
    }
}
public enum VisitorType
{ STUDENT, CHILD, ADULT }


