using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Car
    {
        public Car()
        {
            
        }

        public string Make { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }

        public void Data()
        {
            Console.WriteLine($"You are asking about your {Year} {Make} {Model}");
           
        }
        
    
    
        
    }
}
