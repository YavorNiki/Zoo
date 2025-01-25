namespace Zoo
{
    public class IceCream
    {
        private IceCreamType type;
        private double price;
        public IceCreamType Type { get => type; set => type = value; }
        public double Price { get => price; set => price = value; }

        public IceCream(IceCreamType type)
        {
            price = 3;
            Type = type;
        }

        public static void BuyIceCream(Visitor visitor, IceCreamType type)
        {
            double k = 1;
            switch (visitor.Type)
            {
                case VisitorType.CHILD:
                    k = 0.7;
                    break;
                case VisitorType.STUDENT:
                    k = 0.8;
                    break;
                default:
                    break;
            }

            IceCream icecream = new IceCream(type);
            visitor.Totalspend += k * icecream.Price;
        }
    }

    public enum IceCreamType
    {
        vanilla,
        chocolate,
        strawberry,
    }
}
