using Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Builder.Parasite;

namespace Builder
{
    public class Plant 
    {
        private string name;
        private string sugarLevel;
        private int vitamins;
        private string color;
        private Parasite parasite;

        public static PlantBuilder Builder()
        {
            return new PlantBuilder();
        }

        public void PrintPlant()
        {
            Console.WriteLine(this.name + this.sugarLevel + this.vitamins + this.color);
            parasite.PrintParasite();
    }

        private Plant( string name,  string sugarLevel,  int vitamins, string color, Parasite parasite) 
       {
            this.name = name;
            this.sugarLevel = sugarLevel;
            this.vitamins = vitamins;
            this.color = color;
            this.parasite = parasite;
        }
        public class PlantBuilder
        {

            private string name;
            private string sugarLevel;
            private int vitamins;
            private string color;
            private Parasite parasite;

            // Fluent Interface - call a function on an object and the function will return something.
            // often used by builders
            // u can return the PlantBuilder itself in its setters:
            // like this, u can chain the commands below when using in Program.cs
            public PlantBuilder WithName(string name)
            {
                this.name = name;
                return this;
            }
            public PlantBuilder WithSugarLevel(string sugarLevel)
            {
                this.sugarLevel = sugarLevel;
                return this;
            }
            public PlantBuilder WithVitamins(int vitamins)
            {
                this.vitamins = vitamins;
                return this;
            }
            public PlantBuilder WithColor(string color)
            {
                this.color = color;
                return this;
            }
            public PlantBuilder WithParasite(Func <ParasiteBuilder, Parasite> callback )            {
                this.parasite = callback(new ParasiteBuilder());
                return this;
            }

            public Plant Build()
            {
                return new Plant(this.name,this.sugarLevel,this.vitamins,this.color,this.parasite);
            }
        }

    }

    public class Parasite
    {
        private int length;
        private Parasite(int length) {
            this.length = length;
        }

        public void PrintParasite()
        {
            Console.WriteLine("Würm, länge: "+ this.length);
        }

        public class ParasiteBuilder 
        {
            private int length;

            public ParasiteBuilder WithLength(int length)
            {
                this.length = length;
                return this;
            }
            public Parasite Build()
            {
                return new Parasite(this.length);
            }
        }
        
    }
}

