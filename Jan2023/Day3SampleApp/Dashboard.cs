using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3SampleApp
{
    //Create a menu, implement logic at only the dashboard level;
    public class Dashboard
    {
        Menu menu;
        CustomerFactory custF;
        public Dashboard()
        {
            menu = new Menu();
            custF = new CustomerFactory();
        }
        public void Run()
        {
            int choice = menu.PrintMenu();
            BaseCustomer b = custF.GetObject(choice);
            b.LogInformation();
            
        }
    }
}
