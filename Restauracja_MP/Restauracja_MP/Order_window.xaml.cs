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

            foreach (Dish item in menu.allDishes)
            {
                MenuList.Items.Add(item);
            }
        }

        private void BackButtonClick(object sender, RoutedEventArgs e) //back_btn_click
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
        private void RemoveDishButtonClick(object sender, RoutedEventArgs e)
        {
           
                if(OrderList.SelectedItems.Count != 0);
                {
                    OrderList.Items.RemoveAt(OrderList.SelectedIndex);
                    myOrder.RemoveDishFromOrder((Dish)MenuList.SelectedItem);
                    TotalPriceBox.Text = myOrder.CalculateOrderCost() + "Pln";
                }
            
        }

        // add to order
        private void AddDishButtonClick(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(MenuList.SelectedItem);
            myOrder.AddDishToOrder((Dish)MenuList.SelectedItem);
            TotalPriceBox.Text = myOrder.CalculateOrderCost()+"Pln";
        }
    }
}
