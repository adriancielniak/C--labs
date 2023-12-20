using System;
using System.Threading;

namespace SandwichProcessor
{
    public class SandwichOrder : Common.IOrder
    {

        public string Title { get; set; }

        public void Process()
        {
            Console.WriteLine($"Preparing sandwich order: {Title}");

            string[] recipe = { "Choosing Ingredients", "Spreading Condiments", "Arranging Ingredients", "Assembling the Sandwich", "Cutting into Pieces" };

            for (int i = 0; i < recipe.Length; i++)
            {
                Console.WriteLine(recipe[i]);
                Thread.Sleep(1000);
            }
        }
    }

}

