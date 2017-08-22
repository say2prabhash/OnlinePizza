using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzas
{
    interface IPizzaInventory
    {
        Dictionary<string,string> Pizza { get; set; }
        bool AddPizzaToInventory(string pizzaName, string size);
    }
}
