namespace Restauracja_MP
{
    class Dish
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

        public Dish ()
        {
            Type = "none";
            Name = "none";
            Price = 0;
        }

        public Dish(string type, string name, int price)
        {
            this.Type = type;
            this.Name = name;
            this.Price = price;
        }
        
        public string GetInfo()
        {
            string info;
            info = "Typ dania: " + this.Type + " Nazwa: " + this.Name + " Cena: " + this.Price;

            return info;
        }
    }
}

