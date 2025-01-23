namespace Zoo
{
    public abstract class Ids
    {
        private static int nextAnimalAttractionId = 1;
        private static int nextVisitorId = 1;
        private static int nextTicketId = 1;

        private int id;

        public int Id { get => id; set => id = value; }

        protected Ids()
        {
            if (this is AnimalAttraction)
            {
                Id = nextAnimalAttractionId++;
            }
            else if (this is Visitor)
            {
                Id = nextVisitorId++;
            }
            else if (this is Ticket)
            {
                Id = nextTicketId++;
            }
        }
    }
}