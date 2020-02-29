using System.Windows;
using OrderManager.Lib.BLL.Services;
using OrderManager.Lib.UI;
using OrderManager.Lib.DAL.EF;

namespace OrderManager.App.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DataContext = new ApplicationViewModel(new DishService(new OrderContext()));
        }

        private void ListBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

        }
    }
}
