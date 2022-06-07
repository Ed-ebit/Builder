using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public interface IPlant { }
    public class Plant : IPlant
    {
        private string name;
        private string sugarLevel;
        private int vitamins;
        private string color;

        private Plant() { }

        public class PlantBuilder
        {
            private readonly Plant plant;
            public PlantBuilder()
            {
                plant = new Plant();
            }

            public PlantBuilder WithName(string name)
            {
                plant.name = name;
                return this;
            }
            public PlantBuilder WithSugarLevel(string sugarLevel)
            {
                plant.sugarLevel = sugarLevel;
                return this;
            }
            public PlantBuilder WithVitamins(int vitamins)
            {
                plant.vitamins = vitamins;
                return this;
            }
            public PlantBuilder WithColor(string color)
            {
                plant.color = color;
                return this;
            }
            public Plant Build()
            {
                return plant;
            }
        }
    }
}
