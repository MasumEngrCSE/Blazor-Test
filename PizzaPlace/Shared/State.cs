namespace PizzaPlace.Shared
{
    public class State
    {
        public Menu Menu { get; } = new Menu();
        public ShoppingBasket Basket { get; } = new ShoppingBasket();
        public UI UI { get; set; } = new UI();
    }
}
