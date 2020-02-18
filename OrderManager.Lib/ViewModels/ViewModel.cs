using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManager.Lib.ViewModels
{
    class ViewModel 
    {
        private readonly IView view;
        private readonly IModel model;

        public ViewModel(IView view, IModel model)
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
            ///
            view.SetDishes(model.GetDishes());
        }
    }

}
