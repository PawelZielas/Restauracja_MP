using System.Collections.Generic;
using System.Linq;

namespace Restauracja_MP
{
    class CompleteMenu
    {
        public List<Dish> AllDishes { get; set; }

        public CompleteMenu ()
        {
            this.AllDishes = new List<Dish>();
            CreateCompleteMenu();
        }

        /// <summary>
        /// Returns all food with specific type
        /// </summary>
        /// <returns></returns>
        public List<Dish> FindByType (string foodType)
        {
            List<Dish> correctDishes = new List<Dish>();
            foreach (Dish item in AllDishes)
            {
                correctDishes.Add(AllDishes.Find( dish => dish.Name == foodType)  );
            }

            return correctDishes;
        }

        /// <summary>
        /// Return dish with specific name
        /// </summary>
        /// <param name="foodName"></param>
        /// <returns></returns>
        public Dish FindByName (string foodName)
        {
            Dish dish = new Dish();
            dish = AllDishes.Find( item => item.Name == foodName);

            return dish;
        }

        public void CreateCompleteMenu ()
        {
            // Pizze
            this.AllDishes.Add(new Dish("Pizza", "Margarita", 20));
            this.AllDishes.Add(new Dish("Pizza", "Vegetariana", 22));
            this.AllDishes.Add(new Dish("Pizza", "Tosca", 25));
            this.AllDishes.Add(new Dish("Pizza", "Venecia", 25));
            // dodatki do pizzy
            this.AllDishes.Add(new Dish("Pizza Dodatek", "Podwojny Ser", 2));
            this.AllDishes.Add(new Dish("Pizza Dodatek", "Salami", 2));
            this.AllDishes.Add(new Dish("Pizza Dodatek", "Szynka", 2));
            this.AllDishes.Add(new Dish("Pizza Dodatek", "Pieczarki", 2));
            // dania glowne
            this.AllDishes.Add(new Dish("Danie Glowne", "Schabowy z frytkami/ryżem/ziemniakami", 30));
            this.AllDishes.Add(new Dish("Danie Glowne", "Ryba z frytkami", 28));
            this.AllDishes.Add(new Dish("Danie Glowne", "Placek po wegiersku", 27));
            // dodatki glownego
            this.AllDishes.Add(new Dish("Danie Glowne dodatek", "Bar salatkowy", 6));
            this.AllDishes.Add(new Dish("Danie Glowne dodatek", "Zestaw sosow", 6));
            // zupy
            this.AllDishes.Add(new Dish("Zupa", "Pomidorowa", 12));
            this.AllDishes.Add(new Dish("Zupa", "Rosół", 10));

            // napoje
            this.AllDishes.Add(new Dish("Napoje", "Cofe", 5));
            this.AllDishes.Add(new Dish("Napoje", "Tea", 5));
            this.AllDishes.Add(new Dish("Napoje", "Coke", 5));
        }
    }
}
