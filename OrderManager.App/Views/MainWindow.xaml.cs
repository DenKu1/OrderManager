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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace OrderManager.App.Views
{
    public partial class MainWindow : Window
    {


        public MainWindow()
        {
            InitializeComponent();

           // btnSetClock.Click += SetClocks;
        }

        /*
        private void SetClocks(object sender, EventArgs e)
        {
            Clock.Current = dtpClock.Value;
        }
        */
        /*
        public void SetDishes(IEnumerable<Dish> dishes)
        {
            menuGrid.ItemsSource = dishes;
        }

        private void ButtonOrderClick(object sender, EventArgs e)
        {
            Dish = (Dish)menuGrid.SelectedItem;

            DishOrdered?.Invoke(this, EventArgs.Empty);
        }

        private void WindowLoaded(object sender, RoutedEventArgs e)
        {
            Load?.Invoke(this, EventArgs.Empty);
        }
        */
    }
}
