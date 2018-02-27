namespace Restauracja_MP
{
    class Dish
    {
        #region variables
        public string type
        {
            get
            {
                return _Type;
            }
            set
            {
                _Type = value;
            }
        }
        private string _Type;

        public string name
        {
            get
            {
                return _Name;
            }
            set
            {
                _Name = value;
            }
        }
        private string _Name;

        public int price
        {
            get
            {
                return _Price;
            }
            set
            {
                _Price = value;
            }
        }
        private int _Price;

        #endregion

        public Dish ()
        {
            this.type = "none";
            this.name = "none";
            this.price = 0;
        }

        public Dish(string type, string name, int price)
        {
            this.type = type;
            this.name = name;
            this.price = price;
        }

        /// <summary>
        /// Method return string with all data about dish.
        /// </summary>
        /// <returns></returns>
        public string GetDishInfoString()
        {
            string info;
            info = "Typ dania: " + this.type + " Nazwa: " + this.name + " Cena: " + this.price;

            return info;
        }
    }
}

