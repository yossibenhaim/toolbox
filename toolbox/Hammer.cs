using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toolbox
{
    internal class Hammer : Tool
    {
        private string _name;
        private int _weight;
        private string _toolCategory;
        public Hammer(string name, int weight, string toolCategory) : base(name, weight, toolCategory)
        {
            _name = name;
            _weight = weight;
            _toolCategory = toolCategory;
        }

        public override void Describe()
        {
            Console.WriteLine($"Tool: {_name}, Weight: {_weight}kg, Category: {_toolCategory}");
        }
        public override void Use()
        {
            Console.WriteLine("Hammer is being used");
        }
    }
}
