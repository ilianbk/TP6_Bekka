namespace TP6
{
    public class Reine : Topping
    {
        public Topping _topping;
        
        public Reine()
        {
            _topping = new Topping()
                .SetName("Reine")
                .IsCheeseRequired(true)
                .IsTomatoRequired(true)
                .IsBaconRequired(true)
                .IsMushroomRequired(true);
        }
    }
}