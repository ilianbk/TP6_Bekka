using System;

namespace TP6
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            PizzaBuilder pizza = new PizzaBuilder(new Marguerita()._topping);
            pizza.DisplayOrder(); 
            
            PizzaBuilder pizza2 = new PizzaBuilder(new Reine()._topping);
            pizza2.DisplayOrder(); 
            
            BasicPizza basicpizza = new BasicPizza();
            string basicPizza = basicpizza.CreatePizza();
            Console.WriteLine(basicPizza);
            PizzaDecoration cheesePizzaDecoration = new CheesePizzaDecoration(basicpizza);
            string cheesePizza = cheesePizzaDecoration.CreatePizza();
            Console.WriteLine("\n" + cheesePizza);
            BaconPizzaDecoration baconPizzaDecoration = new BaconPizzaDecoration(basicpizza);
            string baconPizza = baconPizzaDecoration.CreatePizza();
            Console.WriteLine("\n" + baconPizza);
            Console.Read();
        }
    }
}