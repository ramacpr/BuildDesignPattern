namespace HelloBuilder.Contracts
{
    public interface IBurgerBuilder
    {
        IBurgerBuilder BunType(string bunVariety);
        IBurgerBuilder SauseType(string sause);
        IBurgerBuilder PattyType(string patty);
        IBurgerBuilder Topping(string topping);
        IBurgerBuilder PrepMethod(string prepMethod);
        IBurger PrepareBurger();
    }
}
