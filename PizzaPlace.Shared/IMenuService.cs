using PizzaPlace.Shared;

namespace PizzaPlace.Shared
{
    public interface IMenuService
    {
        ValueTask<Menu> GetMenu();
    }
}
