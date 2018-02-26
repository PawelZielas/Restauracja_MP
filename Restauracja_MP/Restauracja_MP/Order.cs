using System.Collections.Generic;
using System.Linq;

namespace Restauracja_MP
{
    class Order
    {
        #region Variables public for now (change later)


        public List<Dish> dishList;
        public string comment;
        public string email;
        public int totalPrice;

        #endregion
        #region Constructors

        /// <summary>
        /// Construct without initial data
        /// </summary>
        public Order()
        {
            this.dishList = new List<Dish>();
            this.totalPrice = 0;
            this.comment = "Brak zastrzezen";
            this.email = "Nie podano adresu";
        }

        /// <summary>
        /// Constructor accepts dish var and setting orderPrice
        /// </summary>
        /// <param name="dish"></param>
        /// <param name="priceValue"></param>
        public Order(Dish dish, string comment, string email)
        {
            //Initialize list object adding dish to order.

            this.dishList = new List<Dish>();
            this.dishList.Add(dish);
            this.comment = comment;
            this.email = email;
            this.totalPrice = CalculateOrderCost();
        }

        #endregion
        /// <summary>
        /// Add dish to current order.
        /// </summary>
        /// <param name="dish"></param>
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
            int dishListCount = dishList.Count();

            for (int i=0; i < dishListCount; i++)
            {
                totalPrice += dishList[i].Price;
            }

            return this.totalPrice;
        }
        
        public string OrderInfo()
        {
            string OpisZamowienia;
            string doklej = " ";
            foreach (Dish item in dishList)
            {
                OpisZamowienia = item.GetInfo();
                doklej = doklej + OpisZamowienia;
            }

            return "Koszt Twojego zamówienia wynosi: " + CalculateOrderCost().ToString(); ;
        }
    }


}
