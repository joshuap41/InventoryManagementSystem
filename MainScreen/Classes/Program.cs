using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PASoftware1Project
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            #region prepopulate the dataGridViews

            //parts
            InHouse NewPart = new InHouse("Tire", 200.50, 32, 2, 50, 5);
            Inventory.AddPart(NewPart);
            //a clean input
            Inventory.AddPart(new InHouse("Motor", 9000.50, 32, 2, 50, 5));
            Inventory.AddPart(new Outsourced("Transmission", 7000.00, 3, 1, 50, "Excel Gear"));
            Inventory.AddPart(new Outsourced("Seats", 700.25, 5, 1, 50, "Speco"));


            //products
            Inventory.Products.Add(new Product("Toyota Tundra", 57000.50, 5, 1, 50));
            Inventory.Products.Add(new Product("Ford Mustang", 35000.75, 7, 1, 50));
            Inventory.Products.Add(new Product("Toyota Highlander", 45000.50, 7, 1, 50));
            Inventory.Products.Add(new Product("Ford Fusion", 20000.50, 7, 1, 50));
            #endregion

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainScreenForm());
        }
    }
}
