namespace TP6
{
    public class Pizza
    {
        private float Price = 0;
        private Topping topping;
        
        public Topping getTopping()
        {
            return topping;
        }

        public void setTopping(Topping topping)
        {
            this.topping = topping;
        }
        
        public float getPrice() {
            return Price;
        }
 
        public void addToPrice(float price) {
            this.Price = Price + price;
        }
    }
    
}