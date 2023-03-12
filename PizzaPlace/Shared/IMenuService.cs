namespace PizzaPlace.Client.Shared
{
    public interface IMenuService
    {
        ValueTask<Menu> GetMenu();
    }
}
