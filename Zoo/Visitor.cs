public class Visitor
{
    private int id;
    private string name;
    private int age;
    private VisitorType type;
    private List<AnimalAttraction> visitedAttractions = new List<AnimalAttraction>();

    public int Id { get => id; set => id = value; }
    public string Name { get => name; set => name = value; }
    public int Age { get => age; set => age = value; }
    public VisitorType Type { get => type; set => type = value; }
    private double totalspend;
    public List<AnimalAttraction> VisitedAttractions
    {
        get => visitedAttractions;
        set => visitedAttractions = value;
    }
    public double Totalspend { get => totalspend; set => totalspend = value; }

    public Visitor(int id, string name, int age, VisitorType type)
    {
        this.Id = id;
        this.Name = name;
        this.Age = age;
        this.Type = type;
        totalspend = 0;

    }
    public void visitAttraction(AnimalAttraction attraction)
    {
        visitedAttractions.Add(attraction);
        Ticket ticket = new Ticket(attraction.Name, 10, TicketType.ADULT_TICKET);

        switch (Type)
        {
            case VisitorType.ADULT:
                ticket = new Ticket(attraction.Name, 10, TicketType.ADULT_TICKET);
                break;
            case VisitorType.CHILD:
                ticket = new Ticket(attraction.Name, 10, TicketType.CHILD_TICKET);
                break;
            case VisitorType.STUDENT:
                ticket = new Ticket(attraction.Name, 10, TicketType.STUDENT_TICKET);
                break;

        }
        totalspend += attraction.GetAttractionPrice(ticket);
        AnimalAttraction.TotalVisits.Add(attraction);
    }
    public override string ToString()
    {
        return $"{Name}(№{Id}) is a/an {Type}({Age}).";
    }
}
public enum VisitorType
{ STUDENT, CHILD, ADULT }


