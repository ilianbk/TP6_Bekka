namespace TP6
{
    public class BaconPizzaDecoration : PizzaDecoration
    {
        public BaconPizzaDecoration(Pizzas pizzas) : base(pizzas){}
        
        public override string CreatePizza()
        {
            return pizzas.CreatePizza() + AddBacon();
        }

        private string AddBacon()
        {
            return " : Bacon added"; 
        }
    }
}