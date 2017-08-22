using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerOrder;

namespace ShoppingCart
{
    public class Cart : ICart
    {
        public bool AddToCart(OrderList pizzaList)
        {
            return true;
        }
    }
}
