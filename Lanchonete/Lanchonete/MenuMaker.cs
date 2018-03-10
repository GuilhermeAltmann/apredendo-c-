using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lanchonete
{
    class MenuMaker
    {

        public Random Randomizer;

        string[] Meats = { "Roast beef", "Salami", "Turkey", "Ham", "Pastrami"};
        string[] Condiments = { "yellow mustard", "brown mustard", "hney mustard", "mayo",
                                "relish", "french dressing"};
        string[] Breads = { "rye", "white", "wheat", "pumpernickel", "italian bread", "a roll" };

        public string GetMenuItem() {

            string randomMeat = this.Meats[Randomizer.Next(this.Meats.Length)];
            string randomCondiment = this.Condiments[Randomizer.Next(this.Condiments.Length)];
            string randomBread = this.Breads[Randomizer.Next(this.Breads.Length)];
            return randomMeat + " with " + randomCondiment + " on " + randomBread;
        }
    }
}
