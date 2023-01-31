using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3SampleApp
{
    public class Menu
    {
        public int PrintMenu() {
            string[] names = Enum.GetNames(typeof(OptionsEnum));
            int[] values = (int[])Enum.GetValues(typeof(OptionsEnum));

            int length = names.Length;
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine($"Press {values[i]} for {names[i]}");
            }
            Console.WriteLine("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            return choice;
        }
        
    }
}
