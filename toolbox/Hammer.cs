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
        public Hammer(string name, int weight) : base(name, weight)
        {
            _name = name;
            _weight = weight;
        }

        public override void Describe()
        {
            Console.WriteLine("Your tool is the hammer.");
        }
        public override void Use()
        {
            Console.WriteLine("Hammer is being used");
        }
    }
}
