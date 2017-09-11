using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CroweHorwath.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            DateTime dat = DateTime.Now;
            Console.WriteLine("\nToday is {0:d} at {0:T}.", dat);
            Console.Write("\nPress H to print static string using WCF services. ");
            var enteredString = Console.ReadLine();
            // test 23
            while (enteredString.ToLower() != "h")
            {
                Console.Write("\nYou entered another char. ");
                Console.Write("\nPress H to print static string using WCF services. ");
                enteredString = Console.ReadLine();
            }

            CroweHorwathService.ICHService objService = new CroweHorwathService.CHServiceClient();
            var result = objService.GetData();
            Console.WriteLine(result);

            Console.Write("\nPress any string and hit enter to print dynamic string using WCF services. ");
            enteredString = Console.ReadLine();
            result = objService.GetUserData(enteredString);
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
