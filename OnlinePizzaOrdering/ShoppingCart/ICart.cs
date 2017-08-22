using CustomerOrder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    interface ICart
    {
        bool AddToCart(OrderList pizzaList);
    }
}
