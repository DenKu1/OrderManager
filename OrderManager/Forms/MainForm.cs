using System;
using System.IO;
using System.Windows.Forms;
using OrderManager.Model;

namespace OrderManager.Forms
{
    public partial class MainForm : Form
    {
        string startDirectory;

        Restaurant restaurant;

        public MainForm()
        {
            InitializeComponent();

            Load += SetUpMenuGrid;
            btnOrder.Click += OrderDish;
            btnSetClock.Click += SetClocks;

            startDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;

            restaurant = new Restaurant(startDirectory + @"/Files/");  
        }

        private void OrderDish(object sender, EventArgs e)
        {
            string message = restaurant.Kitchen.MakeOrder((Dish)menuGrid.CurrentRow.Cells[0].Value);

            MessageBox.Show(message);
        }

        private void SetUpMenuGrid(object sender, EventArgs e)
        {
            menuGrid.Rows.Clear();

            foreach (var dish in restaurant.Kitchen.Dishes)
                menuGrid.Rows.Add(dish);
        }

        private void SetClocks(object sender, EventArgs e)
        {
            Clock.Current = dtpClock.Value;
        }
    }
}
