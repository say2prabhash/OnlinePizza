using Pizzas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerOrder;

namespace BookingEngine
{
    public class Order:IOrder
    {
        PizzaInventory pizzas;

        OrderList pizzaList;
        public bool PlacingOrder(OrderList pizza)
        {
            pizzas = new PizzaInventory();
            pizzaList = new OrderList();
            foreach(var item in pizza.Orders)
            {
                if(pizzas.Pizza.ContainsKey(item.Key)&& pizzas.Pizza.Contains(item))
                {
                    pizzaList.Orders.Add(item.Key, item.Value);
                }
            }
            if(pizzaList.Orders.Count>=2)
            {
                return true;
            }
            return false;
        }
    }
}
