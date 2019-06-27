using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects.Exercises
{

    class Customer
    {
        int ID {get; set; }
        string name { get; set; }
        int age { get; set; }
    }
    class AddupNumbers
    {
        public int AddNumbers()
        {
            int output = 0;
            Console.WriteLine("Enter a number");
            int numberInput = Convert.ToInt32(Console.ReadLine());

            if (String.IsNullOrEmpty(numberInput.ToString()))
                { }
           
            return output;   
        }
        public List<Customer> CustomerID()
        {            
            return CustomerID() ;
        }
    }
}
