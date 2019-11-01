using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class PizzaTopping
    {
        private ToppingNames _name;

        private Dictionary<ToppingNames, decimal> prices;

        public PizzaTopping()
        {
            prices = new Dictionary<ToppingNames, decimal>
            {
                {ToppingNames.Cheese, 20}, 
                {ToppingNames.Meat, 15}, 
                {ToppingNames.Vegetable, 18}

            };
        }

        public ToppingNames Name
        {
            get { return _name; }
            set
            {
                if (value == ToppingNames.Cheese ||
                    value == ToppingNames.Meat ||
                    value == ToppingNames.Vegetable)
                {
                    _name = value;
                }
                else
                {
                    Console.WriteLine("Please enter a correct value for Topping Name");
                }
            }
        }

        public decimal Cost
        {
            get { return prices[this.Name]; }
        }

        public void Print()
        {
            string toppingName = this.Name.ToString();

            if (Name == ToppingNames.Meat)
            {
                toppingName = this.Name.ToString().ToUpper();
            }
          
           Console.WriteLine($"\t{toppingName} (${this.Cost})");
        }
    }
}
