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

            PizzaTopping topping = new PizzaTopping();

            topping.Name = ToppingNames.Cheese;


            Console.WriteLine(topping.Cost);
        }

        private void EnumTests()
        {
            //topping.Name = (ToppingNames)Enum.Parse(typeof(ToppingNames), "Meat");

            //topping.Name = (ToppingNames)9;
        }
    }
}
