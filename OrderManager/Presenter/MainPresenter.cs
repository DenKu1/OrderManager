using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderManager.Interfaces;
using OrderManager.Model;

namespace OrderManager.Presenter
{
    public class MainPresenter
    {
        private readonly IMainView view;
        private readonly IMainModel model;

        public MainPresenter(IMainView view, IMainModel model)
        {
            this.view = view;
            this.model = model;

            view.DishOrdered += OrderDish;
            view.Load += LoadDishes;
            
        }

        void OrderDish(object sender, EventArgs e)
        {
            model.OrderDish(view.Dish);
        }

        void LoadDishes(object sender, EventArgs e)
        {           
            view.SetDishes(model.GetDishes());
        }
    }
}
