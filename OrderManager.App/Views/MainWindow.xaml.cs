using System.Windows;
using OrderManager.Lib.BLL.Services;
using OrderManager.Lib.UI;
using OrderManager.Lib.DAL.EF;
using OrderManager.Lib.DAL.Interfaces;
using OrderManager.Lib.DAL;

namespace OrderManager.App.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            IUnitOfWork uof = new UnitOfWork();

            DataContext = new ApplicationViewModel(
                new CookerService(uof),
                new CookService(uof),
                new DishService(uof),
                new OrderService(uof)
                );
        }
    }
}
