using System.Collections.Generic;
using System.Linq;

namespace Restauracja_MP
{
    class CompleteMenu
    {
        #region variables
        public List<Dish> allDishes
        {
            get
            {
                return _allDishes;
            }
            set
            {
                _allDishes = value;
            }
        }
        private List<Dish> _allDishes;
        #endregion
        public CompleteMenu ()
        {
            this.allDishes = new List<Dish>();
            CreateCompleteMenu();
        }

        /// <summary>
        /// Returns food List<Dish>  with specified type
        /// </summary>
        /// <returns></returns>
        public List<Dish> FindByType (string foodType)
        {
            List<Dish> CorrectDishes = new List<Dish>();
            foreach (Dish item in allDishes)
            {
                CorrectDishes.Add(this.allDishes.Find( dish => dish.name == foodType)  );
            }

            return CorrectDishes;
        }

        /// <summary>
        /// Return dish with specific name
        /// </summary>
        /// <param name="foodName"></param>
        /// <returns></returns>
        public Dish FindByName (string foodName)
        {
            Dish Dish = new Dish();
            Dish = this.allDishes.Find( item => item.name == foodName);

            return Dish;
        }

        public void CreateCompleteMenu ()
        {
            // Pizza
            this.allDishes.Add(new Dish("Pizza", "Margarita", 20));
            this.allDishes.Add(new Dish("Pizza", "Vegetariana", 22));
            this.allDishes.Add(new Dish("Pizza", "Tosca", 25));
            this.allDishes.Add(new Dish("Pizza", "Venecia", 25));
            // dodatki do pizzy
            this.allDishes.Add(new Dish("Pizza Dodatek", "Podwojny Ser", 2));
            this.allDishes.Add(new Dish("Pizza Dodatek", "Salami", 2));
            this.allDishes.Add(new Dish("Pizza Dodatek", "Szynka", 2));
            this.allDishes.Add(new Dish("Pizza Dodatek", "Pieczarki", 2));
            // dania glowne
            this.allDishes.Add(new Dish("Danie Glowne", "Schabowy z frytkami/ryżem/ziemniakami", 30));
            this.allDishes.Add(new Dish("Danie Glowne", "Ryba z frytkami", 28));
            this.allDishes.Add(new Dish("Danie Glowne", "Placek po wegiersku", 27));
            // dodatki glownego
            this.allDishes.Add(new Dish("Danie Glowne dodatek", "Bar salatkowy", 6));
            this.allDishes.Add(new Dish("Danie Glowne dodatek", "Zestaw sosow", 6));
            // zupy
            this.allDishes.Add(new Dish("Zupa", "Pomidorowa", 12));
            this.allDishes.Add(new Dish("Zupa", "Rosół", 10));
            // napoje
            this.allDishes.Add(new Dish("Napoje", "Cofe", 5));
            this.allDishes.Add(new Dish("Napoje", "Tea", 5));
            this.allDishes.Add(new Dish("Napoje", "Coke", 5));
        }
    }
}
