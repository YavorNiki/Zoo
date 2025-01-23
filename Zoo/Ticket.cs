using Zoo;

public class Ticket : Ids, ISearchById<Ticket>
{
    private string attraction;

    private TicketType type;

    public string Attraction { get => attraction; set => attraction = value; }
    public TicketType Type { get => type; set => type = value; }
    public static List<Ticket> AllTickets { get => allTickets; set => allTickets = value; }

    private static List<Ticket> allTickets = new List<Ticket>();

    public Ticket(string attraction, TicketType type)
    {
        this.Attraction = attraction;
        this.Type = type;
        allTickets.Add(this);
    }
    public static Ticket SearchByID(int id)
    {
        foreach (Ticket tic in AllTickets)
        {
            if (tic.Id == id)
                return tic;
        }
        return null;
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

