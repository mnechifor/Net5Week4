using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class PizzaBase
    {
        public PizzaBase(BaseNames name)
        {
            this.Name = name;
        }
        public BaseNames Name { get; set; }

        private decimal _baseCost = 8m;
        public decimal Cost
        {
            get
            {
                if (Name == BaseNames.Italian)
                {
                    return 1.5m * _baseCost;
                }

                return _baseCost;
            }
        }

        public void Print()
        {
            Console.WriteLine($"Base: [{Name}] ($[{Cost}])");
        }
    }
}
