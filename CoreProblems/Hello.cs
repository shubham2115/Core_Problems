using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreProblems
{
    internal class Hello
    {
        public void Helo()
        {
            Console.WriteLine("Hey user good moring");
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
           Console.WriteLine($"Hey {name} good morning");
            Console.ReadLine(); 
        }
    }
}
