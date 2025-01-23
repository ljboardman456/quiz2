using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ask for item price
            Console.WriteLine("Enter item price");
            //wait for user input
            double price = Convert.ToDouble(Console.ReadLine());
            //ask for sales tax
            Console.WriteLine("Enter sales tax (enter decimal number for percentage such as 0.05 for 5%)");
            //wait for user input
            double tax = Convert.ToDouble(Console.ReadLine());
            //ask for promotion discount
            Console.WriteLine("Enter promotion discount (enter decimal number for percentage such as 0.05 for 5%)");
            //wait for user input
            double discount = Convert.ToDouble(Console.ReadLine());
            //calculate total
            double total = price * tax / discount;
            //disp total
            Console.WriteLine("Total cost: " + total);
            //pause for user input
            Console.ReadLine();

        }
    }
}
