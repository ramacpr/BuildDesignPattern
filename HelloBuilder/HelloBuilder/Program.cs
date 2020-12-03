using HelloBuilder.Concretions;
using HelloBuilder.Exceptions;
using HelloBuilder.Globals;
using System;

namespace HelloBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var burgerMaker = new MakeYourOwnBurgerBuilder();
                var finishedBurger = burgerMaker.BunType(BunVariety.MultigrainBun)
                                                .PrepMethod(PrepMethods.CrispyFried)
                                                .PattyType(Patties.Mushroom)
                                                .SauseType(Sauses.Mayonnaise)
                                                .SauseType(Sauses.SouthWest)
                                                .SauseType(Sauses.Cheesy)
                                                .Topping(Toppings.Lettuce)
                                                .Topping(Toppings.Onions)
                                                .Topping(Toppings.Jalapeno)
                                                .PrepareBurger();
                Console.WriteLine(finishedBurger.Description());
            }
            catch(InvalidBurgerException ex)
            {
                Console.Error.WriteLine("Invalid Burger Creation Exception!");
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine("Unhandled Exception!");
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
