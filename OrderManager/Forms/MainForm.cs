using System;
using System.Windows.Forms;
using OrderManager.Model;

namespace OrderManager.Forms
{
    public partial class MainForm : Form
    {
        Restaurant restaurant = new Restaurant();
        Order order = new Order();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {     
            SetUpMenuGrid();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            string message = restaurant.Kitchen.MakeOrder(order);
            order = new Order();
            MessageBox.Show(message);

            SetUpMenuGrid();
        } 
        
        private void SetUpMenuGrid()
        {
            menuGrid.Rows.Clear();

            foreach (var dish in restaurant.Kitchen.Dishes)
            {
                menuGrid.Rows.Add(0, dish);
            }
        }

        private void menuGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = menuGrid.Rows[e.RowIndex];
           
            bool isChecked = !Convert.ToBoolean(row.Cells[0].Value);            

            if (isChecked)            
                order.AddDish((Dish)row.Cells[1].Value);
            else           
                order.RemoveDish((Dish)row.Cells[1].Value);            

            row.Cells[0].Value = isChecked;
        }

        
    }
}
