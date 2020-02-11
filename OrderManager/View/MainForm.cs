using System;
using System.Collections.Generic;
using System.Windows.Forms;
using OrderManager.Model;
using OrderManager.Interfaces;

namespace OrderManager.Forms
{
    public partial class MainForm : Form, IMainView
    {
        public Dish Dish { get; set; }

        public event EventHandler DishOrdered;

        public MainForm()
        {
            InitializeComponent(); 

            btnSetClock.Click += SetClocks;
        }  

        private void SetClocks(object sender, EventArgs e)
        {
            Clock.Current = dtpClock.Value;
        }

        public void SetDishes(IEnumerable<Dish> dishes)
        {
            menuGrid.Rows.Clear();

            foreach (var dish in dishes)
                menuGrid.Rows.Add(dish);
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            Dish = (Dish)menuGrid.CurrentCell.Value;

            DishOrdered?.Invoke(this, EventArgs.Empty);
        }
    }
}
