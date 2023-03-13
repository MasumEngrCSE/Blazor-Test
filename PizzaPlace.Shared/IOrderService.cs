//using PizzaPlace.Shared;

namespace PizzaPlace.Shared
{
    public interface IOrderService
    {
        ValueTask PlaceOrder(ShoppingBasket basket);
    }
}
