public class Ticket
{
    private string attraction;
    private static int nextId = 1;
    private int id;
    private TicketType type;

    public string Attraction { get => attraction; set => attraction = value; }
    public int Id { get => id; set => id = value; }
    public TicketType Type { get => type; set => type = value; }
    public static List<Ticket> AllTickets { get => allTickets; set => allTickets = value; }

    private static List<Ticket> allTickets = new List<Ticket>();

    public Ticket(string attraction, TicketType type)
    {
        this.Attraction = attraction;
        Id = nextId++;
        this.Type = type;
        allTickets.Add(this);
    }
    public override string ToString()
    {
        return $"Tcket with Id: {Id}({Type}) is for {Attraction}";
    }

}
public enum TicketType
{
    STUDENT_TICKET = 6, CHILD_TICKET = 4, ADULT_TICKET = 10
}

