using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {

            PizzaTopping topping = new PizzaTopping {Name = ToppingNames.Meat};

            PizzaBase pizzaBase = new PizzaBase(BaseNames.Regular);

            Pizza pizza = new Pizza(pizzaBase, "Pizza mea");

            pizza.AddTopping(topping);
            pizza.AddTopping(topping);

            pizza.Print();
        }

        private void EnumTests()
        {
            //topping.Name = (ToppingNames)Enum.Parse(typeof(ToppingNames), "Meat");

            //topping.Name = (ToppingNames)9;
        }
    }
}
