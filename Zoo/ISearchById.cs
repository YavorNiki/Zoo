namespace Zoo
{
    public interface ISearchById<T>
    {
        static T SearchByID(int id) => default;
    }
}
