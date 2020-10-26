using OrderManager.Lib.BLL.DTO;
using OrderManager.Lib.BLL.Interfaces;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
using Apex.MVVM;

namespace OrderManager.Lib.UI
{
    public class ApplicationViewModel : INotifyPropertyChanged
    {
        private readonly ICookerService _cookerService;
        private readonly ICookService _cookService;
        private readonly IDishService _dishService;
        private readonly IOrderService _orderService;

        private DishDTO _selectedDish;

        public DishDTO SelectedDish
        {
            get { return _selectedDish; }
            set
            {
                _selectedDish = value;
                OnPropertyChanged("SelectedDish");
            }
        }

        private string _message;

        public string Message
        {
            get { return _message; }
            set
            {
                _message = value;
                OnPropertyChanged("Message");
            }
        }

        public Command OrderDishCommand { get; }

        public IEnumerable<DishDTO> Dishes { get; set; }

        public ApplicationViewModel(ICookerService cookerService, ICookService cookService, 
            IDishService dishService, IOrderService orderService)
        {
            _dishService = dishService;
            _cookerService = cookerService;
            _cookService = cookService;
            _orderService = orderService;

            OrderDishCommand = new Command(OrderDish);

            Dishes = _dishService.GetDishes();            
        }

        public void OrderDish()
        {
            if (SelectedDish == null)
            {
                return;
            }

            TimeSpan cookingTime = _orderService.MakeOrder(SelectedDish, _cookerService, _cookService, _dishService);

            Message = $"The dish will be ready in {cookingTime.ToString(@"dd\.hh\:mm")}.";
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }

}
