using System;

namespace TP6
{
    public class PizzaBuilder
    {
        private string name;
        private bool cheese;
        private bool pepperoni;
        private bool bacon;
        private bool chicken;
        private bool tomato;
        private bool mushroom;

        public PizzaBuilder(Topping topping)
        {
            name = Topping.Name;
            cheese = Topping.Cheese;
            pepperoni = Topping.Pepperoni;
            bacon = Topping.Bacon;
            chicken = Topping.Chicken;
            tomato = Topping.Tomato;
            mushroom = Topping.Mushroom;
        }

        public void DisplayOrder()
        {
            
            string strItems = "Pizza " + name + " contains : "
                              + (mushroom ? "Mushroom, " : "")
                              + (chicken ? "Chicken, " : "")
                              + (cheese ? "Cheese, " : "")
                              + (pepperoni ? "Pepperoni, " : "")
                              + (bacon ? "Bacon, " : "")
                              + (tomato ? "Tomato, " : "");
            Console.WriteLine(strItems);
            Console.WriteLine(Environment.NewLine);
        }  
    }
}
