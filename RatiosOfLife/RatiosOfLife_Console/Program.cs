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
            while (true)
            {
                plants = plants + (plants * Constants.PlantGrowthRate);
                plants -= herbivores;
                if(plants < 0)
                {
                    Console.WriteLine("Plants extinct");
                    break;
                }
                Console.WriteLine("Plants: " + plants);

                if (herbivores < 0)
                {
                    Console.WriteLine("Herbivores extinct");
                    break;
                }
                herbivores = Convert.ToInt32(herbivores + (herbivores * Constants.HerbivoreGrowthRate));
                herbivores -= carnivores / 2;
                Console.WriteLine("Herbivore status: " + herbivores);

                if (carnivores < 0)
                {
                    Console.WriteLine("Carnivores extinct");
                    break;
                }
                carnivores = Convert.ToInt16(carnivores + (carnivores * Constants.CarnivoreGrowthRate));
                Console.WriteLine("Carnivore status: " + carnivores);
            }
            

            
        }
    }
}
