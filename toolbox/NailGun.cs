using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toolbox
{
    internal class NailGun : Tool
    {
        private string _name;
        private int _weight;
        protected string _toolCategory;
        private int _counter;

        public NailGun(string name, int weight, string toolCategory) : base(name, weight, toolCategory)
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
            counting();
            Console.WriteLine("NailGun is being used");
        }
        public override string returnCategory()
        {
            return _toolCategory;
        }
        public override void counting()
        {
            _counter++;
        }
        public override int ReturnCount()
        {
            return _counter;
        }
        public override string ReturnName()
        {
            return _name;
        }
    }
}
