using System;
using System.Windows.Forms;
using OrderManager.Forms;
using OrderManager.Model;
using OrderManager.Presenter;

namespace OrderManager
{
    static class Program
    {        
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           
            MainForm view = new MainForm();
            MainModel model = new MainModel();
            MainPresenter presenter = new MainPresenter(view, model);
            Application.Run(view);
        }
    }
}
