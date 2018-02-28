using System.Collections.Generic;
using System.Linq;

namespace Restauracja_MP
{
    class Order
    {
        #region Variables 

        private List<Dish> dishList
        {
            get
            {
                return _dishList;
            }
            set
            {
                _dishList = value;
            }
        }
        public List<Dish> _dishList;

        public string comment
        {
            get
            {
                return _comment;
            }
            set
            {
                _comment = value;
            }
        }
        private string _comment;

        public string email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
            }
        }
        private string _email;

        public int totalPrice
        {
            get
            {
                return _totalPrice;
            }
            set
            {
                _totalPrice = value;
            }
        }
        private int _totalPrice;

        #endregion
        #region Constructors

        public Order()
        {
            this.dishList = new List<Dish>();
            this.totalPrice = 0;
            this.comment = "Brak zastrzezen";
            this.email = "Nie podano adresu";
        }

        public Order(Dish Dish, string Comment, string Email)
        {
            this.dishList = new List<Dish>();
            this.dishList.Add(Dish);
            this.comment = Comment;
            this.email = Email;
            this.totalPrice = CalculateOrderCost();
        }

        #endregion

        public void AddDishToOrder(Dish dish)
        {
            this.dishList.Add(dish);
        }

        public void RemoveDishFromOrder(Dish dish)
        {
            this.dishList.Remove(dish);
        }

        public int CalculateOrderCost()
        {
            this.totalPrice = 0;
            int DishListCount = dishList.Count();

            for (int i=0; i < DishListCount; i++)
            {
                this.totalPrice += dishList[i].price;
            }

            return this.totalPrice;
        }
        
        public string OrderInfo()
        {
            string opisZamowienia;
            string doklej = " ";
            foreach (Dish item in dishList)
            {
                opisZamowienia = item.GetDishInfoString();
                doklej = doklej + opisZamowienia;
            }
            return "Koszt Twojego zamówienia wynosi: " + CalculateOrderCost().ToString(); 
        }
    }


}
