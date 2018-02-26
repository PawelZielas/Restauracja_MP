using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Configuration;

namespace Restauracja_MP
{
    /// <summary>
    /// Logika interakcji dla klasy order_window.xaml
    /// </summary>
    public partial class Order_window : Window
    {
        Order myOrder = new Order();
        CompleteMenu menu = new CompleteMenu();

        public Order_window()
        {
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;

            foreach (Dish item in menu.AllDishes)
            {
                menuList.Items.Add(item);
            }
        }

        private void Back_btn_Click(object sender, RoutedEventArgs e) //back_btn_click
        {
            this.Close();
            App.Current.MainWindow.Show();
        }

        private void OpenAcceptWindow(object sender, RoutedEventArgs e)
        {
            Accept_Order_Window AcceptWindow = new Accept_Order_Window();
            AcceptWindow.DataContext = this;
            AcceptWindow.ShowDialog();
        }

        // remove from order
        private void rem_dish_btn_Click(object sender, RoutedEventArgs e)
        {
           
                if(orderList.SelectedItems.Count != 0);
                {
                    orderList.Items.RemoveAt(orderList.SelectedIndex);
                    myOrder.RemoveDishFromOrder((Dish)menuList.SelectedItem);
                    TotalPriceBox.Text = myOrder.CalculateOrderCost() + "Pln";
                }
            
        }

        // add to order
        private void add_dish_btn_Click(object sender, RoutedEventArgs e)
        {
            orderList.Items.Add(menuList.SelectedItem);
            myOrder.AddDishToOrder((Dish)menuList.SelectedItem);
            TotalPriceBox.Text = myOrder.CalculateOrderCost()+"Pln";
        }
    }
}
