namespace TP6
{
    public class PizzaDecoration : Pizzas
    {
        protected Pizzas pizzas;

        public PizzaDecoration(Pizzas pizzas)
        {
            this.pizzas = pizzas;
        }

        public virtual string CreatePizza()
        {
            return pizzas.CreatePizza();
        }
    }
}