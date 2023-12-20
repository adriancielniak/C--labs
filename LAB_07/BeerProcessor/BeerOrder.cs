using System;
using System.Threading;

namespace BeerProcessor
{
    public class BeerOrder : Common.IOrder
    {

        public string Title { get; set; }

        public void Process()
        {
            Console.WriteLine($"Preparing beer order: {Title}");

            string[] recipe = { "Mashing", "Boiling and Adding Hops", "Fermentation", "Maturation", "Bottling and Refermentation" };

            for (int i = 0; i < recipe.Length; i++)
            {
                Console.WriteLine(recipe[i]);
                Thread.Sleep(2000);
            }
        }
    }

}

