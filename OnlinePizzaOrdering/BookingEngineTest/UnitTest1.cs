using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BookingEngine;
using CustomerOrder;
using Pizzas;
using ShoppingCart;

namespace BookingEngineTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PlacingOrderTest()
        {
            Order ordering = new Order();
            OrderList order = new OrderList();
            Assert.IsTrue(ordering.PlacingOrder(order));
        }
        [TestMethod]
        public void AddPizzaToInventoryTest()
        {
            PizzaInventory pizza = new PizzaInventory();
            Assert.IsTrue(pizza.AddPizzaToInventory("Cheese Pizza", "M"));
        }
        [TestMethod]
        public void AddToCartTest()
        {
            Cart pizzaShoppingCart = new Cart();
            OrderList order = new OrderList();
            Assert.IsTrue(pizzaShoppingCart.AddToCart(order));
        }
      
    }
}
