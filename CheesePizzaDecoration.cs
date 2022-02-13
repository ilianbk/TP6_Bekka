namespace TP6
{
    public class CheesePizzaDecoration : PizzaDecoration
    {
        public CheesePizzaDecoration(Pizzas pizzas) : base(pizzas)
        {
            
        }

        public override string CreatePizza()
        {
            return pizzas.CreatePizza() + AddCheese();
        }

        private string AddCheese()
        {
            return " : Cheese added"; 
        }
    }
}