using System.Runtime.Remoting.Messaging;

namespace TP6
{
    public class Topping
    {
        private static string _name;
        private static bool _cheese = false;
        private static bool _pepperoni = false;
        private static bool _bacon = false;
        private static bool _chicken = false;
        private static bool _tomato = false;
        private static bool _mushroom = false;
        
        internal static string Name
        {
            get { return _name; }
        }
        internal static bool Cheese { get { return _cheese; } }
        internal static bool Pepperoni { get { return _pepperoni; } }
        internal static bool Bacon { get { return _bacon; } }
        internal static bool Chicken { get { return _chicken; } }
        internal static bool Tomato { get { return _tomato; } }
        internal static bool Mushroom { get { return _mushroom; } }

        public Topping SetName(string name)
        {
            _name = name;
            return this;
        }
        public Topping IsCheeseRequired(bool value)
        {
            _cheese = value;
            return this;
        }

        public Topping IsPepperoniRequired(bool value)
        {
            _pepperoni = value;
            return this;
        }

        public Topping IsBaconRequired(bool value)
        {
            _bacon = value;
            return this;
        }

        public Topping IsTomatoRequired(bool value)
        {
            _tomato = value;
            return this;
        }

        public Topping IsChickenRequired(bool value)
        {
            _chicken = value;
            return this;
        }

        public Topping IsMushroomRequired(bool value)
        {
            _mushroom = value;
            return this;
        }
    }
}