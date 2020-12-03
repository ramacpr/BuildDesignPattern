using HelloBuilder.Contracts;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloBuilder.Concretions
{
    public class Burger : IBurger
    {
        public string BunType { get; set; }
        public IEnumerable<string> Sauses { get; set; }
        public string PattyType { get; set; }
        public IEnumerable<string> Toppings { get; set; }
        public string PrepMethod { get; set; }

        public Burger()
        {
            Sauses = new List<string>();
            Toppings = new List<string>();
        }

        string StringifyList(IEnumerable<string> itemList)
        {
            var sauses = new StringBuilder();
            int count = itemList.Count() - 1;
            for (int index = 0; index <= count; index++)
            {
                if (index == 0)
                    sauses.Append(itemList.ElementAt(index));
                else if (index == count)
                    sauses.Append($" and {itemList.ElementAt(index)}");
                else
                    sauses.Append($", {itemList.ElementAt(index)}");
            }
            return sauses.ToString();
        }

        public string Description()
        {
            return new StringBuilder()
                .AppendLine($"Your {BunType} bun burger with {PrepMethod} {PattyType} patty.")
                .AppendLine($"Topped with {StringifyList(Toppings)}.")
                .AppendLine($"With {StringifyList(Sauses)} sauses is ready.")
                .AppendLine("Enjoy!")
                .ToString();
        }

        public bool IsBurgerValid()
        {
            return (
                this.BunType != default(string) ||
                this.PattyType != default(string) ||
                this.PrepMethod != default(string) ||
                this.Sauses != default(IEnumerable<string>) ||
                this.Toppings != default(IEnumerable<string>)
            );
        }
    }
}
