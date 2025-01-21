public class Ticket
{
    private string attraction;
    //private double price;
    private int id;
    private TicketType type;

    public string Attraction { get => attraction; set => attraction = value; }
    //public double Price { get => price; set => price = value; }
    public int Id { get => id; set => id = value; }
    public TicketType Type { get => type; set => type = value; }

    public Ticket(string attraction, int id, TicketType type)
    {
        this.Attraction = attraction;
        //this.Price = price;
        this.Id = id;
        this.Type = type;
    }
    public override string ToString()
    {
        return $"Tcket№{Id}({Type}) is for {Attraction}";
    }

}
public enum TicketType
{
    STUDENT_TICKET = 6, CHILD_TICKET = 4, ADULT_TICKET = 10 //posle gi razdelqme na 10
}

