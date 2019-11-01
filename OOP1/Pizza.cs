using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class Pizza
    {
        public PizzaBase Base { get; }

        public string Name { get; set; }

        private List<PizzaTopping> Toppings { get; set; }

        public Pizza(PizzaBase pizzaBase, string name)
        {
            this.Base = pizzaBase;
            this.Toppings = new List<PizzaTopping>();
            this.Name = name;
        }

        public void AddTopping(PizzaTopping topping)
        {
            if (topping != null)
            {
                Toppings.Add(topping);
            }
        }

        public decimal CalculateTotalCost()
        {
            decimal sum = Base.Cost;

            foreach (var pizzaTopping in Toppings)
            {
                sum += pizzaTopping.Cost;
            }

            return sum;
        }

        public void Print()
        {
            Console.WriteLine("Pizza " + this.Name);
            Base.Print();
            Console.WriteLine("Toppings:");
            foreach (var pizzaTopping in Toppings)
            {
                pizzaTopping.Print();
            }

            Console.WriteLine($"Total Cost: $[{this.CalculateTotalCost()}]");
        }
    }
}
