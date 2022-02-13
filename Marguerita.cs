namespace TP6
{
    public class Marguerita : Topping
    {
        public Topping _topping;
        public Marguerita()
        {
            _topping = new Topping()
                .SetName("Marguerita")
                .IsCheeseRequired(true)
                .IsTomatoRequired(true);
        }
    }
}