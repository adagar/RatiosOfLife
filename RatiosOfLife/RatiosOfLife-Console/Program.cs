using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RatiosOfLife_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many plants are there?");
            var plants = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("How many herbivores are there?");
            var herbivores = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many carnivores are there?");
            var carnivores = Convert.ToInt32(Console.ReadLine());
            while(true)
            {
                plants = plants + (plants * Constants.PlantGrowthRate);
                Console.WriteLine("Plants: " + plants);
                Console.WriteLine("Herbivore status: ");
                Console.WriteLine("Carnivore status: ");
            }
            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
