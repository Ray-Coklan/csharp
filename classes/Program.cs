using System;
using System.Collections.Generic;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            human ray = new human("ray",100,3,3,3);
            human cole = new human("cole",3,3,3,3);
            ray.attack(cole);
            // Console.WriteLine($"{player.name} took {this.strength * 5} of damage");
            
        }
    }
}
