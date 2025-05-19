using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toolbox
{
    internal class PipeCutter : Tool
    {
        private string _name;
        private int _weight;
        public PipeCutter(string name, int weight) : base(name, weight)
        {
            _name = name;
            _weight = weight;
        }

        public override void Describe()
        {
            Console.WriteLine("Your tool is the PipeCutter.");
        }
        public override void Use()
        {
            Console.WriteLine("PipeCutter is being used");
        }
    }
}
