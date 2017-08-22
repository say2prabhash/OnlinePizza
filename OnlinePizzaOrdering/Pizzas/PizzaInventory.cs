using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzas
{
    public class PizzaInventory
    {
        public Dictionary<string,string> Pizza { get; private set; }
       public bool AddPizzaToInventory(string pizzaName,string size)
        {
            return true;
        }
    }
}
