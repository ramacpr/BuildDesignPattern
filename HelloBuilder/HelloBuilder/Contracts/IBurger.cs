using System.Collections.Generic;

namespace HelloBuilder.Contracts
{
    public interface IBurger
    {
        string BunType { get; set; }
        IEnumerable<string> Sauses { get; set; }
        string PattyType { get; set; }
        IEnumerable<string> Toppings { get; set; }
        string PrepMethod { get; set; }

        string Description();
        bool IsBurgerValid();
    }
}
